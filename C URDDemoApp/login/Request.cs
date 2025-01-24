using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    public class Request
    {
        public string Tid { get; set; }
        public string MobileNo { get; set; }
        public string Channel { get; set; }
        public string DigitalId { get; set; }
        public string Language { get; set; }
        public string IMEI { get; set; }
        public string Email { get; set; }
        public string ReqAmount { get; set; }

        public string OTP { get; set; }

        public string otpRefId { get; set; }


    }

    public class LoginUser : Request
    {
        public string Pwd { get; set; }
    }
}
