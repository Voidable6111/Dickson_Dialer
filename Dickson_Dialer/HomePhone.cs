using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Dialer
{
    class HomePhone : Phone
    {
        public string pInfo;
        public string pNum;
        public string pCall;
        public HomePhone(string phoneDetails, string number, string name) : base(phoneDetails, number, name)
        {
            pInfo = phoneDetails;
            pNum = number;
            pCall = name;
        }
    }
}
