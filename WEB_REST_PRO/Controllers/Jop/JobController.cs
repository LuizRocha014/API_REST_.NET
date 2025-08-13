using Microsoft.AspNetCore.Mvc;
using Quartz;
using Quartz.Impl;

namespace WEB_REST_PRO.Controllers.Jop
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
