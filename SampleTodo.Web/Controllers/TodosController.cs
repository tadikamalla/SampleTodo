namespace SampleTodo.Web.Controllers
{
    using System.Collections.Generic;
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

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="System.String"/></returns>
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        /// <summary>
        /// Posts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Puts the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="value">The value.</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Deletes the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        public void Delete(int id)
        {
        }
    }
}
