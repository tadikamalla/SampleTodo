namespace SampleTodo.Repository
{
    using System;
    using NHibernate;
    using NHibernate.Context;

    /// <summary>
    /// The NHibernate Session Source
    /// </summary>
    public static class SessionSource
    {
        /// <summary>
        /// The LCK
        /// </summary>
        private static readonly object Lck = new object();

        /// <summary>
        /// The factory
        /// </summary>
        private static ISessionFactory factory;

        /// <summary>
        /// Sets the factory.
        /// </summary>
        /// <param name="f">The factory.</param>
        public static void SetFactory(ISessionFactory f)
        {
            lock (Lck)
            {
               factory = f;
            }
        }

        /// <summary>
        /// Gets the session.
        /// </summary>
        /// <returns>An <see cref="NHibernate.ISession"/></returns>
        /// <exception cref="System.InvalidOperationException">NHibernate SessionFactory cannot be null</exception>
        public static ISession GetSession()
        {
            if (factory == null)
            {
                throw new InvalidOperationException("NHibernate SessionFactory cannot be null");
            }

            ISession session;
            if (CurrentSessionContext.HasBind(factory))
            {
                session = factory.GetCurrentSession();
            }
            else
            {
                session = factory.OpenSession();
                CurrentSessionContext.Bind(session);
            }

            return session;
        }

        /// <summary>
        /// Ends the context session.
        /// </summary>
        public static void EndContextSession()
        {
            var session = CurrentSessionContext.Unbind(factory);
            if (session != null && session.IsOpen)
            {
                try
                {
                    if (session.Transaction != null && session.Transaction.IsActive)
                    {
                        // an unhandled exception has occurred and no db commit should be made
                        session.Transaction.Rollback();
                    }
                }
                finally
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
    }
}
