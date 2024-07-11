using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifetimesController : ControllerBase
    {
        private readonly ITransientOperation transient;
        private readonly ITransientOperation transient2;
        private readonly ISingletonOperation singleton;
        private readonly ISingletonOperation singleton2;
        private readonly IScopedOperation scoped;
        private readonly IScopedOperation scoped2;

        public LifetimesController(
        ITransientOperation transient,
        ITransientOperation transient2,
        ISingletonOperation singleton,
        ISingletonOperation singleton2,
        IScopedOperation scoped,
        IScopedOperation scoped2)
        {
            this.transient = transient;
            this.transient2 = transient2;
            this.singleton = singleton;
            this.singleton2 = singleton2;

            this.scoped = scoped;
            this.scoped2 = scoped2;
        }

        [HttpGet("transient")]
        public string Get()
        {
            return $"LifetimeId-1:{transient.LifetimeId} \nLifetimeId-2:{transient2.LifetimeId}";
        }

        [HttpGet("scoped")]
        public string Scoped()
        {
            return $"LifetimeId-1:{scoped.LifetimeId} \nLifetimeId-2:{scoped2.LifetimeId}";
        }

        [HttpGet("singleton")]
        public string Singleton()
        {
            return $"LifetimeId-1:{singleton.LifetimeId} \nLifetimeId-2:{singleton2.LifetimeId}";
        }

        [HttpGet("singletonvsscoped")]
        public string SingletonVsScoped()
        {
            return $"Singleton:{singleton.LifetimeId} \nScoped:{scoped.LifetimeId}";
        }


    }
}
