namespace SampleTodo.Repository
{
    using System.Collections.Generic;
    using SampleTodo.Domain;

    /// <summary>
    /// The <see cref="Todo"/> Repository
    /// </summary>
    public interface ITodoRepository
    {
        /// <summary>
        /// Attaches the specified <see cref="Todo"/>.
        /// </summary>
        /// <param name="todo">The <see cref="Todo"/>.</param>
        void Attach(Todo todo);

        /// <summary>
        /// Detaches the specified <see cref="Todo"/>.
        /// </summary>
        /// <param name="todo">The <see cref="Todo"/>.</param>
        void Detach(Todo todo);

        /// <summary>
        /// All <see cref="Todo" /> instances in the system.
        /// </summary>
        /// <param name="done">Filter the results by their done status</param>
        /// <returns>
        /// An <see cref="IList{T}" /> of <see cref="Todo" /> objects
        /// </returns>
        IList<Todo> All(bool? done = null);
    }
}
