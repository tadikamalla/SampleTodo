namespace SampleTodo.Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using SampleTodo.Domain;
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

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Todo"/> objects</returns>
        public IEnumerable<Todo> Get()
        {
            return this.todoRepository.All();
        }

        /// <summary>
        /// Posts the specified task.
        /// </summary>
        /// <param name="todo"></param>
        public void Post(Todo todo)
        {
            this.todoRepository.Attach(todo);
        }
    }
}
