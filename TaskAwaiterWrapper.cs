using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Asparlose.Async
{
    class TaskAwaiterWrapper : IAwaiter
    {
        readonly TaskAwaiter<object> awaiter;
        public TaskAwaiterWrapper(TaskAwaiter<object> awaiter)
        {
            this.awaiter = awaiter;
        }

        public bool IsCompleted => awaiter.IsCompleted;

        public void GetResult() { }

        public void OnCompleted(Action continuation) => awaiter.OnCompleted(continuation);
    }

    class TaskAwaiterWrapper<T> : IAwaiter<T>
    {
        readonly TaskAwaiter<T> awaiter;

        public TaskAwaiterWrapper(TaskAwaiter<T> awaiter)
        {
            this.awaiter = awaiter;
        }

        public bool IsCompleted => awaiter.IsCompleted;

        public T GetResult() => awaiter.GetResult();

        public void OnCompleted(Action continuation) => awaiter.OnCompleted(continuation);
    }
}
