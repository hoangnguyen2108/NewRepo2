using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Services
{
    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly ApplicationDbContext _context;

        public LeaveTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypesAsync()
        {
            var leaveTypes = await _context.LeaveTypes.ToListAsync();

            return leaveTypes.Select(x => new LeaveTypeReadOnlyVM
            {
                Id = x.Id,
                Name = x.Name,
                Days = x.NumberOfDays
            }).ToList();
        }

        public async Task<bool> IsNameExistsAsync(string name)
        {
            return await _context.LeaveTypes.AnyAsync(x => x.Name == name);
        }

        public async Task CreateLeaveTypeAsync(LeaveTypeCreateVM vm)
        {
            var leaveType = new LeaveType
            {
                Name = vm.Name,
                NumberOfDays = vm.Days
            };

            _context.LeaveTypes.Add(leaveType);
            await _context.SaveChangesAsync();
        }

        public async Task<LeaveTypeEditVM?> GetEditVMAsync(int id)
        {
            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType == null) return null;

            return new LeaveTypeEditVM
            {
                Id = leaveType.Id,
                Name = leaveType.Name,
                Days = leaveType.NumberOfDays
            };
        }

        public async Task UpdateLeaveTypeAsync(LeaveTypeEditVM vm)
        {
            var leaveType = await _context.LeaveTypes.FindAsync(vm.Id);
            if (leaveType == null) return;
            leaveType.Name = vm.Name;
            leaveType.NumberOfDays = vm.Days;
            _context.LeaveTypes.Update(leaveType);
            await _context.SaveChangesAsync();

        }

           public bool LeaveTypeExists(int id)
          {
               return _context.LeaveTypes.Any(e => e.Id == id);
          }

        public async Task<T?> Get<T>(int id) where T : class
        {
            var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null) return null;
            return new LeaveTypeReadOnlyVM
            {
                Id = leaveType.Id,
                Name = leaveType.Name,
                Days = leaveType.NumberOfDays
            } as T;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.LeaveTypes.AnyAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType != null)
            {
                _context.LeaveTypes.Remove(leaveType);
                await _context.SaveChangesAsync();
            }
        }
    }
}