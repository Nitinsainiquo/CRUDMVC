using BillRiembursement.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillRiembursement.BAL
{
    public interface IBillRiembursementBLL
    {
        IEnumerable<BillRiembursementModelBLL> GetList();
        void AddBill(BillRiembursementModelBLL Bill);
        BillRiembursementModelBLL? GetById(int? id);
        void UpdateBill(BillRiembursementModelBLL Bill);
        void Delete(int? id);

    }
}
