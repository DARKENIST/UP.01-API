using NATKCollegeSchedule.Data;
using NATKCollegeSchedule.DTO;
using NATKCollegeSchedule.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using NATKCollegeSchedule.Services;

namespace NATKCollegeSchedule.Services
{
    public class GroupService : IGroupService
    {
        private readonly AppDbContext _db;

        public GroupService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GroupDto>> GetAllGroups()
        {
            return await _db.StudentGroups
                .Include(g => g.Specialty)
                .OrderBy(g => g.GroupName)
                .Select(g => new GroupDto
                {
                    Name = g.GroupName,
                    Course = g.Course,
                    Specialty = g.Specialty.Name
                })
                .ToListAsync();
        }
    }
}

