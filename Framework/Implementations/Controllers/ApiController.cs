using Framework.Abstracts.Contracts;
using Framework.Abstracts.Controllers.Api;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Framework.Implementations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    abstract public class ApiController<T1, T2, T3, T4, T5, T6, T7> : IApiController<T1, T2, T3, T4, T5, T6, T7>
        where T1 : class, IExternalObject
        where T2 : class, IFindRequest
        where T3 : class, IFindResponse<T1>
        where T4 : class, ISaveRequest<T1>
        where T5 : class, ISaveResponse<T1>
        where T6 : class, IDeleteRequest
        where T7 : class, IDeleteResponse<T1>
    {
        [HttpGet]
        public abstract T3 Get(T2 request);

        [HttpPost]
        public abstract T5 Post(T4 request);

        [HttpDelete]
        public abstract T7 Delete(T7 request);
    }
}
