using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenInsa.Web
{
    [Serializable]
    public class Profile
    {
        public int seq {get;set;}
        public string MEMBER_NAME { get; set; }
        public string MEMBER_PWD { get; set; }
        public string EMAIL { get; set; }
    }
}