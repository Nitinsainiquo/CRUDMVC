using BillRiembursement.BAL;
using BillRiembursement.BAL.Models;
using Demo_CRUD.Models;
using Demo_CRUD.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo_CRUD.Controllers
{
    public class BillRiembursementController : Controller
    {
        private readonly IBillRiembursementBLL _context;

        public BillRiembursementController(IBillRiembursementBLL context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            try
            {
                IEnumerable<BillRiembursementModelBLL> Bills = _context.GetList();
                return View(Bills);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }

        public IActionResult Create()
        {
            ViewBag.ReimbursementType = RiembursementLists.GetReimbursementType();
            ViewBag.TransferMedium = RiembursementLists.GetAmountTransfer();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BillRiembursementModelBLL Bill)
        {
            ViewBag.ReimbursementType = RiembursementLists.GetReimbursementType();
            ViewBag.TransferMedium = RiembursementLists.GetAmountTransfer();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.AddBill(Bill);
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    RedirectToAction(nameof(Index));
                }
            }
            return View(Bill);
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.ReimbursementType = RiembursementLists.GetReimbursementType();
            ViewBag.TransferMedium = RiembursementLists.GetAmountTransfer();
            if (id == null) return BadRequest();
            try
            {
                var EditBills = _context.GetById(id);
                if (EditBills == null) return NotFound();
                else return View(EditBills);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString()); 
            }
            finally
            {
                RedirectToAction(nameof(Index));
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BillRiembursementModelBLL Bill)
        {
            ViewBag.ReimbursementType = RiembursementLists.GetReimbursementType();
            ViewBag.TransferMedium = RiembursementLists.GetAmountTransfer();
            if (!ModelState.IsValid) return View(Bill);
            else
            {
                try
                {
                    _context.UpdateBill(Bill);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                     RedirectToAction(nameof(Index)); 
                }
            }
            
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var DeleteBill =_context.GetById(id);
            if (DeleteBill == null) return NotFound();
            else
            {
                try
                {
                    _context.Delete(id);
                    return RedirectToAction((nameof(Index)));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    RedirectToAction(nameof(Index));
                }  
            }
        }
    }
}
