using Framework.Abstracts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Implementations.Contracts
{
    public abstract class DeleteResponse<T> : IDeleteResponse<T> where T : class, IExternalObject
    {
        public T Object { get; set; }
        public bool IsDeleted { get; set; }
    }
}
