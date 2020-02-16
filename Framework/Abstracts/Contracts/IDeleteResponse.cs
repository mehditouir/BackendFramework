using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Abstracts.Contracts
{
    public interface IDeleteResponse<T> where T : IExternalObject
    {
        T Object { get; set; }
        bool IsDeleted { get; set; }
    }
}
