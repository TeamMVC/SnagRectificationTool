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
    public partial class DataCapturingAeroEngine : Form
    {
        string _SubsystemName = string.Empty;
        string _SubsystemId = string.Empty;
        BusinessModel bdsystem = new BusinessModel();

        public DataCapturingAeroEngine()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void getSubstemInformation(string SubsystemId,string SubsystemName)
        {
            _SubsystemId = SubsystemId;
            _SubsystemName = SubsystemName;
        }
        private void DataCapturingAeroEngine_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.SubsytemInitialFormModel sb = new Models.SubsytemInitialFormModel();
            sb.Unit = txtunit.Text;
            sb.AC_No = txtacc.Text;
            sb.StartDate = dtofstrt.Value;
            sb.AFHrs = cbAf.SelectedItem.ToString();
            sb.AFVal = Convert.ToInt32(txtafhrsval.Text);
            sb.ENGHrs = cbEng.SelectedItem.ToString();
            sb.ENGVal = Convert.ToInt32(txtenghrs.Text);
            sb.BriefOfSnag = txtbriefsnag.Text;
            sb.ENGOilLife = txtengOil.Text;
            sb.SpareOnEXTN = txtspareExt.Text;
            sb.Date = txtdtend.Value;

            Random r = new Random();
            int randNum = r.Next(0, 1000000);
            string sixDigitNumber = randNum.ToString("SNG00");
            sb.RefId = sixDigitNumber;

            bdsystem.SaveAeroEngineSubstemForm(sb);
            MessageBox.Show("Please Note your Reference Id "+sb.RefId);
            var rectdata= bdsystem.GetRectItems(Convert.ToInt32(_SubsystemId));
            this.Hide();

            RectificationForm rectificationForm = new RectificationForm();
            rectificationForm.ShowRectForm(rectdata);
            rectificationForm.Show();

        }
    }
}
