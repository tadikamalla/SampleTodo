namespace SampleTodo.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Todo
    {
        public virtual int Id { get; set; }
        public virtual string Task { get; set; }
        public virtual bool IsComplete { get; set; }
    }
}
