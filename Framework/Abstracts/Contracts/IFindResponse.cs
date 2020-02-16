using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Abstracts.Contracts
{
    public interface IFindResponse<T> where T : IExternalObject
    {
        IList<T> Values { get; set; }
    }
}
