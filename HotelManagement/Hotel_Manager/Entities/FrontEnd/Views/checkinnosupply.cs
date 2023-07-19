using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Entities.FrontEnd.Views
{
    [Keyless]
    public class checkinnosupply
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }



        public string room_type { get; set; }



        public string room_floor { get; set; }



        public string room_number { get; set; }


        public int break_fast { get; set; }


        public int lunch { get; set; }


        public int dinner { get; set; }


        public bool cleaning { get; set; }


        public bool towel { get; set; }


        public bool s_surprise { get; set; }


        public bool supply_status { get; set; }

        public int food_bill { get; set; }

    }
}
