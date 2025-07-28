using LeaveManagementSystem.Application.Models.LeaveTypes;
using LeaveManagementSystem.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace LeaveManagementSystem.Controllers
{
    [Authorize(Roles = "Supervisor")]
    public class LeaveTypesController(ILeaveTypeService leaveTypeService) : Controller
    {
        private readonly ILeaveTypeService _leaveTypeService = leaveTypeService;

        //  private readonly ApplicationDbContext _context;
        //  private readonly IMapper _mapper;

        //  public LeaveTypesController(ApplicationDbContext context)
        // {
        //      _context = context;
        //   this._mapper = mapper;
        //  }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var data = await _leaveTypeService.GetAllLeaveTypesAsync();
            // Manually mapping the data to the view model is not necessary if you are using AutoMapper.
            //     var viewData = data.Select(x => new LeaveTypeReadOnlyVM
            //          {
            //            Id = x.Id,
            //            Name = x.Name,
            //            Days = x.Days
            //         });

            return View(data);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var leaveType = await _context.LeaveTypes
            //    .FirstOrDefaultAsync(m => m.Id == id);

            var leaveType = await _leaveTypeService.Get<LeaveTypeReadOnlyVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }

            // Manually mapping the data to the view model is not necessary if you are using AutoMapper.

            //  var viewData = new LeaveTypeReadOnlyVM
            //  {
            //     Id = leaveType.Id,
            //      Name = leaveType.Name,
            //      Days = leaveType.NumberOfDays
            // };


            return View(leaveType);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {



            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeCreateVM leaveTypeCreateVM)
        {
            // Check if leave type name already exists

            if (await _leaveTypeService.IsNameExistsAsync(leaveTypeCreateVM.Name))
            {
                ModelState.AddModelError("Name", "Leave type with this name already exists.");
            }

            if (ModelState.IsValid)
            {
                //   var leaveType = new LeaveType
                //   {
                //       Name = leaveTypeCreateVM.Name,
                //       NumberOfDays = leaveTypeCreateVM.Days
                //   };
                //   _context.Add(leaveType);
                //  await _context.SaveChangesAsync();
                await _leaveTypeService.CreateLeaveTypeAsync(leaveTypeCreateVM);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeCreateVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            //  var leaveType = await _context.LeaveTypes.FindAsync(id);
            var leaveType = await _leaveTypeService.GetEditVMAsync(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }


            // Manually mapping the data to the view model is not necessary if you are using AutoMapper.
            // var leaveTypeEditVM = new LeaveTypeEditVM
            //  {
            //      Id = leaveType.Id,
            //     Name = leaveType.Name,
            //     Days = leaveType.Days
            //  };

            //  return View(leaveTypeEditVM);
            return View(leaveType);


        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeEditVM leaveTypeEditVM)
        {
            if (id != leaveTypeEditVM.Id)
            {
                return NotFound();
            }

            // Check if leave type name already exists
            //   if (await _context.LeaveTypes.AnyAsync(x => x.Name == leaveTypeEditVM.Name))
            //   {
            //       ModelState.AddModelError("Name", "Leave type with this name already exists.");
            //   }

            if (await _leaveTypeService.IsNameExistsAsync(leaveTypeEditVM.Name))
            {
                ModelState.AddModelError("Name", "Leave type with this name already exists.");
            }


            if (ModelState.IsValid)
            {
                try
                {
                    //    var leaveType1 = new LeaveType
                    //    {
                    //       Id = leaveTypeEditVM.Id,
                    //        Name = leaveTypeEditVM.Name,
                    //        NumberOfDays = leaveTypeEditVM.Days
                    //    };
                    //    _context.Update(leaveType1);
                    //    await _context.SaveChangesAsync();

                    await _leaveTypeService.UpdateLeaveTypeAsync(leaveTypeEditVM);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_leaveTypeService.LeaveTypeExists(leaveTypeEditVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeEditVM);
        }

        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //  var leaveType = await _context.LeaveTypes
            //      .FirstOrDefaultAsync(m => m.Id == id);

            var leaveType = await _leaveTypeService.Get<LeaveTypeReadOnlyVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //    var leaveType = await _context.LeaveTypes.FindAsync(id);
            //    if (leaveType != null)
            //    {
            //        _context.LeaveTypes.Remove(leaveType);
            //   }

            //  await _context.SaveChangesAsync();
            await _leaveTypeService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //   private bool LeaveTypeExists(int id)
        //   {
        //       return _context.LeaveTypes.Any(e => e.Id == id);
        //   }
    }
}
