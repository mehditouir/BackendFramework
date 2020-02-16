using Framework.Abstracts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Implementations.Contracts
{
    public abstract class DeleteRequest : IDeleteRequest
    {
        public long Id { get; set; }
    }
}
