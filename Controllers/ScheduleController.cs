using NATKCollegeSchedule.Data;
using NATKCollegeSchedule.Models;
using NATKCollegeSchedule.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NATKCollegeSchedule.Controllers
{
        [ApiController]
        [Route("api/schedule")]
        public class ScheduleController : ControllerBase
        {
            private readonly IScheduleService _service;
            public ScheduleController(IScheduleService service, AppDbContext db)
            {
                _service = service;
            }

             public async Task<IActionResult> GetSchedule(string groupName, DateTime start, DateTime end)
            {
                var result = await _service.GetScheduleForGroup(groupName, start.Date, end.Date);
                return Ok(result);
            }
        }
}
