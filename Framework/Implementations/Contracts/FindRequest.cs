using Framework.Abstracts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Implementations.Contracts
{
    public abstract class FindRequest : IFindRequest
    {
        public long? Id { get; set; }
    }
}
