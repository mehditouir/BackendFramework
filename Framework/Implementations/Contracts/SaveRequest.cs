using Framework.Abstracts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Implementations.Contracts
{
    public abstract class SaveRequest<T> : ISaveRequest<T> where T : class, IExternalObject
    {
        public T Object { get; set; }
    }
}
