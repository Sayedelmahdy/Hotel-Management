using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Entities.Login
{
    public class frontend
    {
        
        [MaxLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string user_name {  get; set; }
        
        [MaxLength(50)]
        public string pass_word { get; set; }
    }
}
