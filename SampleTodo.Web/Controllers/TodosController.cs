namespace SampleTodo.Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using SampleTodo.Repository;

    public class TodosController : ApiController
    {
        private readonly ITodoRepository todoRepository;

        public TodosController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        // GET api/todo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/todo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/todo
        public void Post([FromBody]string value)
        {
        }

        // PUT api/todo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/todo/5
        public void Delete(int id)
        {
        }
    }
}
