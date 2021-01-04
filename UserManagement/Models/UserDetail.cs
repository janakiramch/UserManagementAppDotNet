using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class UserDetail
    {
        [Key]
        public int UserDetailId { get; set; }

        [Column(TypeName ="nvarchar(40)")]
        public string UserFirstName { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string UserLastName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string UserEmail { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string UserPhone { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string UserAddress { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string UserGender { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string UserActive { get; set; }


    }
}
