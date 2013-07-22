namespace SampleTodo.Web.Filters
{
    using System.Web.Mvc;
    using SampleTodo.Repository;

    /// <summary>
    /// An <see cref="ActionFilterAttribute"/> that closes any open NHibernate session
    /// </summary>
    public class NHibernateSessionAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NHibernateSessionAttribute" /> class.
        /// </summary>
        public NHibernateSessionAttribute()
        {
            this.Order = 100;
        }

        /// <summary>
        /// Called by the ASP.NET MVC framework after the action result executes.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (filterContext.IsChildAction)
            {
                return;
            }

            SessionSource.EndContextSession();
        }
    }
}