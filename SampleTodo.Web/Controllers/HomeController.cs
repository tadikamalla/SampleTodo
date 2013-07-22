namespace SampleTodo.Web.Controllers
{
    using System.Web.Mvc;
    using SampleTodo.Repository;

    public class HomeController : Controller
    {
        private readonly ITodoRepository todoRepository;

        public HomeController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
