using System;

namespace blazorsqliteexperiment
{
    public class Todo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string TaskDesc { get; set; }
        public bool Completed { get; set; }
    }
}
