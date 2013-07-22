namespace SampleTodo.Web
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Routing;
    using SampleTodo.Web.App_Start;

    /// <summary>
    /// The MVC Application
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// The application start method
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}