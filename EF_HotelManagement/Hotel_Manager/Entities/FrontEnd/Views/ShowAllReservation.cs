using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Manager.Entities.FrontEnd.Views
{
    [Keyless]
    public class ShowAllReservation
    {
        public int Id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string birth_day { get; set; }

        public string gender { get; set; }

        public string phone_number { get; set; }

        public string email_address { get; set; }

        public int number_guest { get; set; }

        public string street_address { get; set; }

        public string apt_suite { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zip_code { get; set; }

        public string room_type { get; set; }

        public string room_floor { get; set; }

        public string room_number { get; set; }

        public double total_bill { get; set; }

        public string payment_type { get; set; }
        public string card_type { get; set; }
        public string card_number { get; set; }
        public string card_exp { get; set; }
        public string card_cvc { get; set; }
        public DateTime arrival_time { get; set; }
        public DateTime leaving_time { get; set; }
        [Column(TypeName = "bit")]
        public bool check_in { get; set; }

        public int break_fast { get; set; }

        public int lunch { get; set; }


        public int dinner { get; set; }
        [Column(TypeName = "bit")]
        public bool cleaning { get; set; }
        [Column(TypeName = "bit")]
        public bool towel { get; set; }
        [Column(TypeName = "bit")]
        public bool s_surprise { get; set; }
        [Column(TypeName = "bit")]
        public bool supply_status { get; set; }

        public int food_bill { get; set; }
    }
}
