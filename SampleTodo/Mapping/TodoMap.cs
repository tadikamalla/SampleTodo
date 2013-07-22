namespace SampleTodo.Mapping
{
    using FluentNHibernate.Mapping;
    using SampleTodo.Domain;

    /// <summary>
    /// Maps the <see cref="Todo"/> class to a database table.
    /// </summary>
    public class TodoMap : ClassMap<Todo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoMap"/> class.
        /// </summary>
        public TodoMap()
        {
            this.Table("Todo");

            this.Id(cm => cm.Id).GeneratedBy.Identity();

            this.Map(cm => cm.IsComplete);
            this.Map(cm => cm.Task).Length(80000);
        }
    }
}
