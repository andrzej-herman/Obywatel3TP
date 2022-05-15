using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.PeselLogic
{
    public class AddCitizenModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int SexId { get; set; }



        public void Clear()
        {
            FirstName = LastName = String.Empty;
            DateOfBirth = DateTime.MinValue;
            SexId = 0;
        }
    }
}