using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcViewData.Models
{
    public class info
    {
        public int personid { get; set; }
        public string personname { get; set; }
        public List<string> persons { get; set; }
    }
}