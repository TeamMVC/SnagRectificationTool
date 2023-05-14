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
    public partial class Steps : Form
    {
        BusinessModel bdsystem = new BusinessModel();
        List<Models.StepsModel>  _listSteps;
        string _referenceId;
        int stepcount;
        int _RectificationId;
        List<Models.ReqtificationItems> _listRectmodel;
        public Steps()
        {
            InitializeComponent();
        }

        public void GetAllStepsDetail(List<Models.StepsModel> stepsModel,string referenceId,int RectificationId)
        {
            _listSteps = stepsModel;
            _referenceId = referenceId;
            _RectificationId = RectificationId;
        }

        private void ButtonDynamic_Click(object sender, EventArgs e)
        {
         
            StepDetails sbobj = new StepDetails();
            LinkLabel buttonDynamic = (LinkLabel)sender;
            var AllStepsResult = bdsystem.GetModelStepsComponentData(Convert.ToInt32(buttonDynamic.Name));
            sbobj.GetStepsdata(AllStepsResult, _referenceId,Convert.ToString(_RectificationId), buttonDynamic.Name, stepcount);
            this.Hide();
            sbobj.Show();
        }

        private void Steps_Load_1(object sender, EventArgs e)
        {
            var listAllSteps = _listSteps;
            stepcount = listAllSteps.Count;
            int x = 33, y = 29;
            int top = 200;
            int left = 390;
            //lblSystemTitle.Text = sysObj.SystemName + "SELECT SUBSYSTEM";
            _listRectmodel = bdsystem.GetRectdataByRectfid(Convert.ToInt32(_RectificationId));       
            label2.Text = "SNAG:" + _listRectmodel[0].RectificationItems;
            for (int i = 0; i < listAllSteps.Count; i++)
            {
                 
                LinkLabel buttonDynamic = new LinkLabel();
                buttonDynamic.Left = left;
                buttonDynamic.Top = top;
                buttonDynamic.BorderStyle= BorderStyle.FixedSingle;
                buttonDynamic.Text = listAllSteps[i].StepName + ' ' + listAllSteps[i].StepDetails;
                top += buttonDynamic.Height + 2;
                buttonDynamic.Width = 500;
                buttonDynamic.BackColor = ColorTranslator.FromHtml("#B9D1EA");
                buttonDynamic.ForeColor = Color.Black;
                buttonDynamic.Font = new Font("Yu Gothic Medium", 12);
                buttonDynamic.Name = Convert.ToString(listAllSteps[i].RectificationId);
                buttonDynamic.Click += ButtonDynamic_Click;
               
                panel1.Controls.Add(buttonDynamic);
            }
            this.Controls.Add(panel1);
        }

        private void btncomplete_Click_1(object sender, EventArgs e)
        {
            SnagCompletionForm sbobj = new SnagCompletionForm();
            sbobj.getFormInformation(_RectificationId);
            this.Hide();
            sbobj.Show();
        }
    }
}
