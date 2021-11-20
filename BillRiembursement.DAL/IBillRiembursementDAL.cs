using BillRiembursement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillRiembursement.DAL
{
    public interface IBillRiembursementDAL
    {
       IEnumerable<BillRiembursementModel> GetList();
        void AddBill(BillRiembursementModel Bill);
        BillRiembursementModel? GetById(int? id);
        void UpdateBill(BillRiembursementModel Bill);
        void Delete(int? id);


    }
}
