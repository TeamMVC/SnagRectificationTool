using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnagRectificationTool.Models
{
  public  class StepsData
    {
        public int RectificationProcedureId { get; set; }
        public int RectificationStepId { get; set; }
        public string ProcedureTitle { get; set; }
        public string ProcedureContent { get; set; }
        public string ProcedureLinkPath { get; set; }
        public string ProcedureLinkType { get; set; }
    }
}
