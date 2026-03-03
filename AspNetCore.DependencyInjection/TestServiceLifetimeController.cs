using AspNetCore.DependencyInjection.ServiceLifetime;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.DependencyInjection
{
    [ApiController]
    [Route("test")]
    public class TestServiceLifetimeController : ControllerBase
    {
        private readonly ITransientGuid _transientGuid1;
        private readonly ITransientGuid _transientGuid2;

        private readonly IScopedGuid _scopedGuid1;
        private readonly IScopedGuid _scopedGuid2;

        private readonly ISingletonGuid _singletonGuid1;
        private readonly ISingletonGuid _singletonGuid2;


        public TestServiceLifetimeController(ITransientGuid transientGuid1, ITransientGuid transientGuid2,
                              IScopedGuid scopedGuid1, IScopedGuid scopedGuid2,
                              ISingletonGuid singletonGuid1, ISingletonGuid singletonGuid2)
        {
            _transientGuid1 = transientGuid1;
            _transientGuid2 = transientGuid2;
            _scopedGuid1 = scopedGuid1;
            _scopedGuid2 = scopedGuid2;
            _singletonGuid1 = singletonGuid1;
            _singletonGuid2 = singletonGuid2;
        }

        [HttpGet("getGuid")]
        public string Get()
        {
            return $"transient1 : {_transientGuid1.getGuid()} \n" +
                $"transient2 : {_transientGuid2.getGuid} \n" +
                $"scoped1 : {_scopedGuid1} \n" +
                $"scoped2 : {_scopedGuid2} \n" +
                $"singleton1 : {_singletonGuid1} \n" +
                $"singleton2 : {_singletonGuid2}";
        }
    }
}
