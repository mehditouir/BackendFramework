using Framework.Abstracts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Abstracts.Controllers.Api
{
    public interface IApiController<T1, T2, T3, T4, T5, T6, T7>
        where T1 : IExternalObject
        where T2 : IFindRequest
        where T3 : IFindResponse<T1>
        where T4 : ISaveRequest<T1>
        where T5 : ISaveResponse<T1>
        where T6 : IDeleteRequest
        where T7 : IDeleteResponse<T1>
    {
        T3 Get(T2 request);
        T5 Post(T4 request);
        T7 Delete(T7 request);
    }
}
