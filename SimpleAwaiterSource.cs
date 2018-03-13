using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asparlose.Async
{
    public class SimpleAwaiterSource
    {
        readonly TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();

        public IAwaiter GetAwaiter() => new TaskAwaiterWrapper(taskCompletionSource.Task.GetAwaiter());

        public void SetResult() => taskCompletionSource.SetResult(null);
    }

    public class SimpleAwaiterSource<T>
    {
        readonly TaskCompletionSource<T> taskCompletionSource = new TaskCompletionSource<T>();

        public IAwaiter<T> GetAwaiter() => new TaskAwaiterWrapper<T>(taskCompletionSource.Task.GetAwaiter());

        public void SetResult(T result) => taskCompletionSource.SetResult(result);
    }

}
