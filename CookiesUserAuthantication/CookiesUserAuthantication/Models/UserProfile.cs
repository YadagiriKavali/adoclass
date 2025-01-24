using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookiesUserAuthantication.Models
{
    public class UserProfile
    {
        [Required]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
    public class UserProfileHelper
    {
        private HttpContext context;

        public UserProfileHelper(HttpContextAccessor httpContextAccessor)
        {
            context = httpContextAccessor.HttpContext;
        }
        public string UserName
        {
            get
            {
                return context.Request.Cookies["Authcookie"];
            }
        }
    }
}
