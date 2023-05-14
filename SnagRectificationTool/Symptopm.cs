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
    public partial class Symptopm : Form
    {
        BusinessModel bdsystem = new BusinessModel();
        int _RectificationId;
        string _refId;
        List<Models.ReqtificationItems> _listRectmodel;
        public Symptopm()
        {
            InitializeComponent();
        }

        public void RectificationId(int id, string refid)
        {
            _RectificationId = id;
            _refId = refid;
        }
        private void Symptopm_Load(object sender, EventArgs e)
        {
            var listSymptom = bdsystem.GetSymptom(_RectificationId);
            _listRectmodel = bdsystem.GetRectdataByRectfid(Convert.ToInt32(_RectificationId));
            int x = 33, y = 29;
            int top = 150;
            int left = 350;
            label1.Text = _listRectmodel[0].RectificationItems;
            //lblSystemTitle.Text = sysObj.SystemName + "SELECT SUBSYSTEM";
            for (int i = 0; i < listSymptom.Count; i++)
            {
                Button buttonDynamic = new Button();
                buttonDynamic.Font = new Font("Yu Gothic Medium", 9);
                buttonDynamic.BackColor = ColorTranslator.FromHtml("#B9D1EA");
                //  buttonDynamic.BackColor = Color.LightSteelBlue;// "B9D1EA";
                buttonDynamic.ForeColor = Color.Black;
                buttonDynamic.Left = left;
                buttonDynamic.Top = top;
                buttonDynamic.Text = listSymptom[i].Symptom;
                top += buttonDynamic.Height + 2;
                buttonDynamic.Width = 500;
                buttonDynamic.Height = 30;
                buttonDynamic.Name = Convert.ToString(listSymptom[i].RectificationId);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            bdsystem.RemovedInitialFormData(_refId);
            home.Show();
        }

        private void btnSymptonAnalyse_Click(object sender, EventArgs e)
        {
            Steps stepObj = new Steps();
            var AllStepsResult = bdsystem.SendStepsByRectfid(_RectificationId);
            stepObj.GetAllStepsDetail(AllStepsResult, _refId, _RectificationId);
            this.Hide();
            stepObj.Show();

        }
    }
}
