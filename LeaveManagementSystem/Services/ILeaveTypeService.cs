using LeaveManagementSystem.Models.LeaveTypes;

namespace LeaveManagementSystem.Services
{
    public interface ILeaveTypeService
    {
        Task CreateLeaveTypeAsync(LeaveTypeCreateVM vm);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypesAsync();
        Task<LeaveTypeEditVM?> GetEditVMAsync(int id);
        Task<bool> IsNameExistsAsync(string name);
        bool LeaveTypeExists(int id);

        Task UpdateLeaveTypeAsync(LeaveTypeEditVM vm);
    }
}