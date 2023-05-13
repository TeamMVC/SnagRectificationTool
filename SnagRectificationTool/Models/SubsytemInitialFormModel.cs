using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnagRectificationTool.Models
{
    public class SubsytemInitialFormModel
    {
        public string RefId { get; set; }
        public string Unit { get; set; }
        public string AC_No { get; set; }
        public DateTime StartDate { get; set; }
        public string AFHrs { get; set; }
        public int AFVal { get; set; }
        public string ENGHrs { get; set; }
        public int ENGVal { get; set; }
        public string BriefOfSnag { get; set; }
        public string ENGOilLife { get; set; }
        public string SpareOnEXTN { get; set; }

        public DateTime Date { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        
    }
}


  
         