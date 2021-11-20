using BillRiembursement.DAL;
using AutoMapper;
using BillRiembursement.DAL.Entities;
using BillRiembursement.BAL.Models;

namespace BillRiembursement.BAL
{
    public class BillRiembursementBLL: IBillRiembursementBLL
    {
        private readonly IBillRiembursementDAL _context;
        private readonly Mapper _mapper;
        public BillRiembursementBLL(IBillRiembursementDAL context)
        {
            _context = context;
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<BillRiembursementModel, BillRiembursementModelBLL>().ReverseMap()));    
        }

        public IEnumerable<BillRiembursementModelBLL> GetList()
        {
           IEnumerable<BillRiembursementModel> _dal = _context.GetList();
           IEnumerable<BillRiembursementModelBLL> bill = _mapper.Map<IEnumerable<BillRiembursementModel>, IEnumerable<BillRiembursementModelBLL>>(_dal);
            return bill;
        }
        public void AddBill(BillRiembursementModelBLL Bill)
        {
            BillRiembursementModel _bill = _mapper.Map<BillRiembursementModelBLL,BillRiembursementModel>(Bill);
            _context.AddBill(_bill);
            
        }
        public BillRiembursementModelBLL? GetById(int? id)
        {
            BillRiembursementModel _bill = _context.GetById(id);
            BillRiembursementModelBLL bill = _mapper.Map<BillRiembursementModel,BillRiembursementModelBLL>(_bill);
            return bill == null ? null : bill;
        }
        public void UpdateBill(BillRiembursementModelBLL Bill)
        {
            BillRiembursementModel _bill = _mapper.Map<BillRiembursementModelBLL, BillRiembursementModel>(Bill);
            _context.UpdateBill(_bill);
        }

        public void Delete(int? id)
        {
            _context.Delete(id);
        }

    }
}