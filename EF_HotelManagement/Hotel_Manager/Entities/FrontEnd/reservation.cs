using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Entities.FrontEnd
{
    public class reservation
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string first_name { get; set; }
        [Required]
        [MaxLength(50)]
        public string last_name { get; set; }
        [Required]
        [MaxLength(50)]
        public string birth_day { get; set; }
        [Required]
        [MaxLength(50)]
        public string gender { get; set; }
        [Required]
        [MaxLength(50)]
        public string phone_number { get; set; }
        [Required]
        [MaxLength(int.MaxValue)]
        public string email_address { get; set; }
        [Required]
        public int number_guest { get; set; }
        [Required]
        [MaxLength(int.MaxValue)]
        public string street_address { get; set; }
        [Required]
        [MaxLength(50)]
        public string apt_suite { get; set; }
        [Required]
        [MaxLength(int.MaxValue)]
        public string city { get; set; }
        [Required]
        [MaxLength(50)]
        public string state { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar")]
        public string zip_code { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar")]
        public string room_type { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar")]
        public string room_floor { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar")]
        public string room_number { get; set; }
        [Required]
        public double total_bill { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar")]
        public string payment_type { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar")]
        public string card_type { get; set; }
        [Required]
        [MaxLength(50)]
        public string card_number { get; set; }
        [Required]
        [MaxLength(50)]
        public string card_exp { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar")]
        public string card_cvc { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime arrival_time { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime leaving_time { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool check_in { get; set; }
        [Required]

        public int break_fast { get; set; }
        [Required]

        public int lunch { get; set; }
        [Required]

        public int dinner { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool cleaning { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool towel { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool s_surprise { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool supply_status { get; set; }
        [Required]
        public int food_bill { get; set; }

    }
}
