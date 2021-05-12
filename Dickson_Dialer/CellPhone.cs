using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Dialer
{
    class CellPhone : Phone
    {
        public string pInfo;
        public string pNum;
        public string pCall;
        public CellPhone(string phoneDetails, string number, string name) : base(phoneDetails, number, name)
        {
            pInfo = phoneDetails;
            pNum = number;
            pCall = name;
        }
        public override string Dial() {
            return pCall + " is being dialed using " + "1+" + pNum + "...";
        }
    }
}
