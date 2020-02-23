using System;
using System.Collections.Generic;
using System.Text;

namespace RCSS.Infra.Identity.Dtos
{
    public class TokenAuthentication
    {
        public DateTime Expires { get; set; }
        public string StrToken { get; set; }
        public string RefreshToken { get; set; }

    }
}
