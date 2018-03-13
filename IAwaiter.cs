using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Asparlose.Async
{
    public interface IAwaiter : INotifyCompletion
    {
        bool IsCompleted { get; }
        void GetResult();
    }

    public interface IAwaiter<T> : INotifyCompletion
    {
        bool IsCompleted { get; }
        T GetResult();
    }

}
