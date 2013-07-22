namespace SampleTodo.Web.App_Start
{
    using System.Web.Mvc;
    using SampleTodo.Web.Filters;

    /// <summary>
    /// The Filter configuration
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Registers the global filters.
        /// </summary>
        /// <param name="filters">The filters.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new NHibernateSessionAttribute());
        }
    }
}