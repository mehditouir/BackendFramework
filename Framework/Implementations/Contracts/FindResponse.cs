using Framework.Abstracts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Implementations.Contracts
{
    public abstract class FindResponse<T> : IFindResponse<T> where T : class, IExternalObject
    {
        public IList<T> Values { get; set; }
    }
}
