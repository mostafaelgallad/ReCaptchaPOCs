using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCaptchaPOCs.Models
{
    public class IndexModel : CaptchaModel
    {
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
