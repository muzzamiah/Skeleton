using System;

namespace Testing1
{
    internal class StaffName
    {
        public int StaffId { get; internal set; }
        public DateTime DOB { get; internal set; }
        public string Street { get; internal set; }
        public string PostCode { get; internal set; }
        public string Role { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public bool Attendance { get; internal set; }
        public bool Gender { get; internal set; }

        internal bool Find(int staffID)
        {
           return true;
        }
    }
}