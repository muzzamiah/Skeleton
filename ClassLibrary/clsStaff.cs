using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool Active { get; set; }
        public int StaffId { get; set; }
        public DateTime DateAdded { get; set; }
        public int CountyNo { get; set; }
        public string HouseNo { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
    }
}