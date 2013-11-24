namespace SampleTodo.Web.Controllers
{
    using System.Web.Http;
    using SampleTodo.Repository;
    using SampleTodo.Domain;
using System.Collections.Generic;

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
        /// Get list of all todo tasks
        /// </summary>
        public IList<Todo> Get()
        {
            return todoRepository.All();
        }

        /// <summary>
        /// add a new list to task
        /// </summary>
        public void Put(Todo data)
        {
            todoRepository.Attach(data);
        }

        /// <summary>
        /// update the status
        /// </summary>
        public void Post(Todo data)
        {
            todoRepository.Attach(data);
        }
    }
}
