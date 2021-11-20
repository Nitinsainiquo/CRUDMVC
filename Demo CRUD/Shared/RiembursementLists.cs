namespace Demo_CRUD.Shared
{
    public class RiembursementLists
    {
        public static List<string> GetAmountTransfer()
        {
            return new List<string> { "UPI", "CASH", "BANK", "CHEQUE" };
        }

        public static List<string> GetReimbursementType()
        {
            return new List<string> { "TRAVEL", "FOOD", "MEDICAL", "TAX" };
        }
    }
}
