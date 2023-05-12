using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnagRectificationTool.Models
{
    public class Symptoms
    {
        public int SymptonId { get; set; }
        public int RectificationId { get; set; }
        public string Symptom { get; set; }
    }
}
