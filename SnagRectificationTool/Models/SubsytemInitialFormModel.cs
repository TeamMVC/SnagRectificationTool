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
        public DateTime? DateOfCompletion { get; set; }
        public string TimeForRepairHrs { get; set; }
        public string Status { get; set; }
        public string MANPOWER_UTILISED { get; set; }
        public string AIR_FRAME { get; set; }
        public string ELECT { get; set; }
        public string AEROENGINE { get; set; }

    }
}


  
         