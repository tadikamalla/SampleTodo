namespace SampleTodo.Repository
{
    using System.Linq;
    using NHibernate.Linq;
    using System.Collections.Generic;
    using SampleTodo.Domain;

    /// <summary>
    /// The repository for the <see cref="Todo" /> object.
    /// </summary>
    public class TodoRepository : ITodoRepository
    {
        /// <summary>
        /// Attaches the specified <see cref="Todo" />.
        /// </summary>
        /// <param name="todo">The <see cref="Todo" />.</param>
        public void Attach(Todo todo)
        {
            using (var session = SessionSource.GetSession())
            {
                using(var t = session.BeginTransaction())
                {
                    session.SaveOrUpdate(todo);
                    t.Commit();
                }
            }
        }

        /// <summary>
        /// All <see cref="Todo" /> instances in the system.
        /// </summary>
        /// <returns>
        /// An <see cref="IList{T}" /> of <see cref="Todo" /> objects
        /// </returns>
        public IList<Todo> All()
        {
            IList<Todo> results;
            using (var session = SessionSource.GetSession())
            {
                using (var t = session.BeginTransaction())
                {
                    results = session.Query<Todo>().OrderBy(todo => todo.Task).ToList();
                    t.Commit();
                }
            }
            return results;
        }
    }
}
