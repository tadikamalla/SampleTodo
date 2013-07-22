namespace SampleTodo.Domain
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a to-do item in the system
    /// </summary>
    [JsonObject(MemberSerialization.OptOut)]
    public class Todo
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the task.
        /// </summary>
        /// <value>
        /// The task.
        /// </value>
        public virtual string Task { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is complete.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is complete; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsComplete { get; set; }
    }
}
