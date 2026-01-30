using NATKCollegeSchedule.Data;
using NATKCollegeSchedule.DTO;
using NATKCollegeSchedule.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NATKCollegeSchedule.Services;

namespace NATKCollegeSchedule.Controllers
{
    [ApiController]
    [Route("api/group")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _service;

        public GroupController(IGroupService service, AppDbContext db)
        {
            _service = service;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetGroups()
        {
            List<GroupDto> result = await _service.GetAllGroups();
            return Ok(result);
        }
    }
}