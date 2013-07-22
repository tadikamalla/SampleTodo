namespace SampleTodo.Web.Controllers
{
    using System.Web.Mvc;
    using SampleTodo.Repository;

    /// <summary>
    /// The default home controller for this application
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The to-do repository
        /// </summary>
        private readonly ITodoRepository todoRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="todoRepository">The to-do repository.</param>
        public HomeController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>The default view</returns>
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
