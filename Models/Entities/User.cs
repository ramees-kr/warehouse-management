using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_management.Models.Entities
{
    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime? DateCreated { get; set; }


        //Method to return User detials
        public string GetUserDetails()
        {
            return $"Id: {Id}\nName: {Firstname} {Lastname} \n Email: {Email}";
        }


    }
}
