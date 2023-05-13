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
    public partial class Steps : Form
    {
        List<Models.StepsModel>  _listSteps;
        string _referenceId;
        public Steps()
        {
            InitializeComponent();
        }

        private void Steps_Load(object sender, EventArgs e)
        {
            var listAllSteps = _listSteps;

            int x = 33, y = 29;
            int top = 80;
            int left = 50;
            //lblSystemTitle.Text = sysObj.SystemName + "SELECT SUBSYSTEM";
            for (int i = 0; i < listAllSteps.Count; i++)
            {

                Panel pd = new Panel();
                LinkLabel buttonDynamic = new LinkLabel();
                buttonDynamic.Left = left;
                buttonDynamic.Top = top;
                buttonDynamic.Text = listAllSteps[i].StepName;
                top += buttonDynamic.Height + 2;
                buttonDynamic.Width = 500;
                buttonDynamic.BackColor = Color.AliceBlue;
                buttonDynamic.ForeColor = Color.White;
                buttonDynamic.Name = Convert.ToString(listAllSteps[i].RectificationId);
                buttonDynamic.Click += ButtonDynamic_Click;
                pd.Width = 800;
                pd.Height = 500;
                pd.Controls.Add(buttonDynamic);

            }
           this.Controls.Add(panel1);
        }
        public void GetAllStepsDetail(List<Models.StepsModel> stepsModel,string referenceId)
        {
            _listSteps = stepsModel;
            _referenceId = referenceId;
        }

        private void ButtonDynamic_Click(object sender, EventArgs e)
        {
            DataCapturingAeroEngine sbobj = new DataCapturingAeroEngine();
            Button buttonDynamic = (Button)sender;
            sbobj.getSubstemInformation(buttonDynamic.Name, buttonDynamic.Text);
            this.Hide();
            sbobj.Show();
        }

        private void Steps_Load_1(object sender, EventArgs e)
        {

        }
    }
}
