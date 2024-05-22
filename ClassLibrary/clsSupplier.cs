using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public clsSupplier()
        {
        }

        public bool Active { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
    }
}