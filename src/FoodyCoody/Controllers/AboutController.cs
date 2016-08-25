using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodyCoody.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+62-8292-32983";
        }

        [Route("[action]")]
        public string Country()
        {
            return "Indonesia";
        }
    }
}
