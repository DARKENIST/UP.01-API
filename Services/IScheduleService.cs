using NATKCollegeSchedule.DTO;

namespace NATKCollegeSchedule.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
startDate, DateTime endDate);
    }
}
