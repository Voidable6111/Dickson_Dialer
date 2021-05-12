using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Dialer
{
    class Phone
    {
        public string phoneInfo;
        public string pNumber;
        public string pName;
        public Phone(string phoneDetails, string number, string name)
        {
            phoneInfo = phoneDetails;
            pNumber = number;
            pName = name;
        }
        
        public virtual string Dial()
        {
            return pName + " is being dialed using " + pNumber + "...";
        }
    }
}
