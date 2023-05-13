using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnagRectificationTool.Models
{
   public class StepReferenceData
    {
        public int RectificationStepId { get; set; }
        public string LinkPath { get; set; }
        public string LinkType { get; set; }
        public string RefMaterialTitle { get; set; }
        public string RefMaterialContent { get; set; }
        public string ProcedureLinkType { get; set; }
    }
}
