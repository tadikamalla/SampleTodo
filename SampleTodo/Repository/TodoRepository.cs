namespace SampleTodo.Repository
{
    using System;
    using System.Collections.Generic;
    using SampleTodo.Domain;

    /// <summary>
    /// The repository for the <see cref="Todo" /> object.
    /// </summary>
    public class TodoRepository : ITodoRepository
    {
        /// <summary>
        /// Attaches the specified <see cref="Todo" />.
        /// </summary>
        /// <param name="todo">The <see cref="Todo" />.</param>
        public void Attach(Todo todo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Detaches the specified <see cref="Todo" />.
        /// </summary>
        /// <param name="todo">The <see cref="Todo" />.</param>
        public void Detach(Todo todo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// All <see cref="Todo" /> instances in the system.
        /// </summary>
        /// <param name="done">Filter the results by their done status</param>
        /// <returns>
        /// An <see cref="IList{T}" /> of <see cref="Todo" /> objects
        /// </returns>
        public IList<Todo> All(bool? done = null)
        {
            throw new NotImplementedException();
        }
    }
}
