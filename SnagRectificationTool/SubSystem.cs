using SnagRectificationTool.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnagRectificationTool
{
    public partial class SubSystem : Form
    {
        BusinessModel bdsystem = new BusinessModel();
        Models.System sysObj = new Models.System();
        List<Models.SubSystem> SubsysObj = new List<Models.SubSystem>();
        
        public SubSystem()
        {
            InitializeComponent();
        }

        public void subSystemofAero()
        {
            var resultSystem = bdsystem.GetSystem(1);
            sysObj.SystemID = resultSystem.SystemID;
            sysObj.SystemName = resultSystem.SystemName;

            SubsysObj = bdsystem.GetSubSystem(sysObj.SystemID);
             



        }
        private void SubSystem_Load(object sender, EventArgs e)
        {
            int x = 33, y = 29;
            lblSystemTitle.Text = sysObj.SystemName +"Select SubSystem";
            for (int i = 0; i < SubsysObj.Count; i++)
            {
            

                Button btn = new Button();
                btn.Location = new Point(x,y);
                btn.Text = SubsysObj[i].SubSystemName;
                btn.Name = "btn" + SubsysObj[i].SubSystemName;
                btn.Height = 40;
                btn.Width = 200;
                
                this.Controls.Add(btn);
                
            }


        }
    }
}
