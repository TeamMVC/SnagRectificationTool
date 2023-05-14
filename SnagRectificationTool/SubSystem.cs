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

        public void subSystemofAero(int id)
        {
            var resultSystem = bdsystem.GetSystem(id);
            sysObj.SystemID = resultSystem.SystemID;
            sysObj.SystemName = resultSystem.SystemName;

            SubsysObj = bdsystem.GetSubSystem(sysObj.SystemID);

        }
        private void SubSystem_Load(object sender, EventArgs e)
        {
            int x = 33, y = 29;
            int top = 150;
            int left = 350;
            lblSystemTitle.Text = sysObj.SystemName +" SELECT SUBSYSTEM";
            for (int i = 0; i < SubsysObj.Count; i++)
            {
                Button buttonDynamic = new Button();
                buttonDynamic.Font = new Font("Yu Gothic Medium", 9);
                buttonDynamic.BackColor = Color.MediumSlateBlue;
                buttonDynamic.ForeColor =Color.White;
                buttonDynamic.Left = left;
                buttonDynamic.Top = top;
                buttonDynamic.Text = SubsysObj[i].SubSystemName;
                top += buttonDynamic.Height + 2;
                buttonDynamic.Width = 500;
                buttonDynamic.Name = Convert.ToString(SubsysObj[i].SubSystemId);
                buttonDynamic.Click += ButtonDynamic_Click;
                panel1.Controls.Add(buttonDynamic);
               
            }
            this.Controls.Add(panel1);
        }
        
        private void ButtonDynamic_Click(object sender, EventArgs e)
        {
            DataCapturingAeroEngine sbobj = new DataCapturingAeroEngine();
            Button buttonDynamic = (Button)sender;
            sbobj.getSubstemInformation(buttonDynamic.Name, buttonDynamic.Text);
            this.Hide();
            sbobj.Show();
        }
    }
}
