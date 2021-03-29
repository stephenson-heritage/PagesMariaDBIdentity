using System;
using Microsoft.AspNetCore.Identity;

namespace PagesMariaDB.Models
{

    public class WebUser : IdentityUser
    {

        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime Birthday { get; set; }

    }

}