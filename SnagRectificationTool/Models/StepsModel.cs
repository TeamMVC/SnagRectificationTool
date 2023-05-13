using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnagRectificationTool.Models
{
    public class StepsModel
    {
        public int RectificationStepId { get; set; }
        public int RectificationId { get; set; }
        public string StepName { get; set; }
        public string StepDetails { get; set; }
    }
}
 
 