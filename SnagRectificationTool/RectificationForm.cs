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
    public partial class RectificationForm : Form
    {
        BusinessModel bdsystem = new BusinessModel();
        Models.System sysObj = new Models.System();
        List<Models.ReqtificationItems> _listRectificationItems = new List<Models.ReqtificationItems>();
        public RectificationForm()
        {
            InitializeComponent();
        }

        public void ShowRectForm(List<Models.ReqtificationItems> listRectificationItems)
        {
            _listRectificationItems = listRectificationItems;
        }

        private void RectificationForm_Load(object sender, EventArgs e)
        {
            int x = 33, y = 29;
            int top = 80;
            int left = 50;
           // lblSystemTitle.Text = sysObj.SystemName + "SELECT SUBSYSTEM";
            for (int i = 0; i < _listRectificationItems.Count; i++)
            {

                Button buttonDynamic = new Button();
                buttonDynamic.Left = left;
                buttonDynamic.Top = top;
                buttonDynamic.Text = _listRectificationItems[i].RectificationItems;
                top += buttonDynamic.Height + 2;
                buttonDynamic.Width = 500;
                buttonDynamic.Name = Convert.ToString(_listRectificationItems[i].RectID);
                buttonDynamic.Click += ButtonDynamic_Click;
                panel1.Controls.Add(buttonDynamic);

            }
            this.Controls.Add(panel1);

        }

        private void ButtonDynamic_Click(object sender, EventArgs e)
        {
            //DataCapturingAeroEngine sbobj = new DataCapturingAeroEngine();
            //Button buttonDynamic = (Button)sender;
            //sbobj.getSubstemInformation(buttonDynamic.Name, buttonDynamic.Text);
            //this.Hide();
            //sbobj.Show();


        }

    }
}
