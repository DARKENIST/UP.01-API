using NATKCollegeSchedule.DTO;

namespace NATKCollegeSchedule.Services
{
    public interface IGroupService
    {
        Task<List<GroupDto>> GetAllGroups();
    }
}
