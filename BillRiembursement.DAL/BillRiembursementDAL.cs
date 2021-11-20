using BillRiembursement.DAL.Data;
using BillRiembursement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BillRiembursement.DAL
{
    public class BillRiembursementDAL : IBillRiembursementDAL
    {
        private readonly BillRiembursementContext _context;
        public BillRiembursementDAL(BillRiembursementContext context)
        {
            _context = context;
        }
        public IEnumerable<BillRiembursementModel> GetList()
        {
            return  _context.BillRiembursementModels.ToList();
        }
        public void AddBill(BillRiembursementModel Bill)
        {
            _context.BillRiembursementModels.Add(Bill);
            _context.SaveChanges();
        }
        public BillRiembursementModel? GetById(int? id)
        {
            return _context.BillRiembursementModels.FirstOrDefault(e => e.Id == id);
        }
        public void UpdateBill(BillRiembursementModel Bill)
        {
            _context.Attach(Bill);
            _context.Entry(Bill).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            BillRiembursementModel DeleteBill = _context.BillRiembursementModels.FirstOrDefault(e => e.Id == id);
            _context.BillRiembursementModels.Remove(DeleteBill);
            _context.SaveChanges();
        }

    }
}