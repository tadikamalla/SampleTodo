namespace SampleTodo.Web.Controllers
{
    using System.Web.Http;
    using SampleTodo.Repository;

    /// <summary>
    /// The to-do API controller
    /// </summary>
    public class TodosController : ApiController
    {
        /// <summary>
        /// The to-do repository
        /// </summary>
        private readonly ITodoRepository todoRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TodosController"/> class.
        /// </summary>
        /// <param name="todoRepository">The to-do repository.</param>
        public TodosController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }
    }
}
