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
    public partial class StepDetails : Form
    {
        List<Models.StepsData> _listSteps;
        List<Models.ReqtificationItems> _listRectmodel;
        List<Models.StepsModel> _listStepsmodel;
        List<Models.StepReferenceData> _listStepsReferenceData;
        BussinessLogic.BusinessModel bm = new BussinessLogic.BusinessModel();
        string _referenceId;
        string _rectId;
        string _StepId;
        int _stepcount;
        public StepDetails()
        {
            InitializeComponent();
        }

        public void GetStepsdata(List<Models.StepsData> stepsModel, string referenceId, string RectID, string stepId, int StepCount)
        {
            _listSteps = stepsModel;
            _referenceId = referenceId;
            _rectId = RectID;
            _StepId = stepId;
            _stepcount = StepCount;
        }

        private void StepDetails_Load(object sender, EventArgs e)
        {
            var listAllSteps = _listSteps;
            _listRectmodel = bm.GetRectdataByRectfid(Convert.ToInt32(_rectId));
            _listStepsmodel = bm.SendStepsByRectfid(Convert.ToInt32(_rectId), Convert.ToInt32(_StepId));
            _listStepsReferenceData = bm.GetModelStepsReferenceData(_listStepsmodel[0].RectificationStepId);
            StringBuilder messageBuilder1 = new StringBuilder(200);
            lblheaderRect.Text = _listRectmodel[0].RectificationItems;
            lblstep.Text = _listStepsmodel[0].StepName + ' ' + _listStepsmodel[0].StepDetails;
            lnklblcomponent.Text = "COMPONENT ILLUSTRATIONS";
            if (_listStepsReferenceData != null && _listStepsReferenceData.Count > 0)
            {
                messageBuilder1.Append(_listStepsReferenceData[0].RefMaterialTitle);
                messageBuilder1.Append(Environment.NewLine);
                messageBuilder1.Append(_listStepsReferenceData[0].RefMaterialContent);
                lnklblrefence.Text = messageBuilder1.ToString();
            }
            StringBuilder messageBuilder = new StringBuilder(200);

            messageBuilder.Append("TECH PUB REQD.");
            messageBuilder.Append(Environment.NewLine);
            messageBuilder.Append(Environment.NewLine);
            messageBuilder.Append("\t\u2022 MAINT MANUAL VOL IV");
            messageBuilder.Append(Environment.NewLine);
            messageBuilder.Append("\t\u2022 MAINT MANUAL ARTOUSTE IIIB,B1 ENG");
            messageBuilder.Append(Environment.NewLine);
            messageBuilder.Append("\t\u2022 IPC ENG");
            messageBuilder.Append(Environment.NewLine);
            messageBuilder.Append("\t\u2022 TGSI ENG /01");
            lbldetail.Text = messageBuilder.ToString();
        }

        private void lnklblcomponent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Component sbobj = new Component();
            //  var AllStepsResult = bdsystem.GetModelStepsData(Convert.ToInt32(buttonDynamic.Name));
            sbobj.GetStepsComponentdata(_referenceId, _rectId, _StepId);
            this.Hide();
            sbobj.Show();
        }

        private void lnklblrefence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StepReferences sbobj = new StepReferences();
            sbobj.GetStepsReferencedata(_referenceId, _rectId, _StepId, _stepcount);
            this.Hide();
            sbobj.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            StepReferences sbobj = new StepReferences();
            sbobj.GetStepsReferencedata(_referenceId, _rectId, _StepId, _stepcount);
            this.Hide();
            sbobj.Show();
        }

        private void btnskip_Click(object sender, EventArgs e)
        {
            int StepId = Convert.ToInt32(_StepId);
            StepDetails sbobj = new StepDetails();
            var AllStepsResult = bm.GetModelStepsComponentData(++StepId);
            if (StepId > _stepcount)
            {
                SnagCompletionForm Sc = new SnagCompletionForm();
                Sc.getFormInformation(Convert.ToInt32(_rectId));
                this.Hide();
                Sc.Show();
            }
            else
            {
                sbobj.GetStepsdata(AllStepsResult, _referenceId, Convert.ToString(_rectId), Convert.ToString(StepId), _stepcount);
                this.Hide();
                sbobj.Show();
            }
        }
    }
}
