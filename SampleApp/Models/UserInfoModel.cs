using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SampleApp.Models
{
    public class UserInfoModel
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime createdAt { get; set; }
    }
}
