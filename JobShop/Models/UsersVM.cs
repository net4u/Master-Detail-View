using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobShop.Models
{
    class UsersVM
    {
        //As List
        public List<AspNetUsers> listUsers { get; set; }
        public List<AspNetRoles> listRoles { get; set; }
        public List<AspNetUserClaims> listClaims { get; set; }
        public List<AspNetUserDetails> listDetails { get; set; }
        public List<AspNetUserLogins> listLogins { get; set; }

        //As IEnumerable
        public IEnumerable<AspNetUsers> enumUsers { get; set; }
        public IEnumerable<AspNetRoles> enumRoles { get; set; }
        public IEnumerable<AspNetUserClaims> enumClaims { get; set; }
        public IEnumerable<AspNetUserDetails> enumDetails { get; set; }
        public IEnumerable<AspNetUserLogins> enumLogins { get; set; }
    }
}
