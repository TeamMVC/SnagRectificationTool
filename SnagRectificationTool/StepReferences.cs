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

    public partial class StepReferences : Form
    {
        List<Models.ReqtificationItems> _listRectmodel;
        List<Models.StepsModel> _listStepsmodel;
        BussinessLogic.BusinessModel bm = new BussinessLogic.BusinessModel();
        string _referenceId;
        string _rectId;
        static string _StepId;
        int _stepcount;
        static int _refernceCount;
        int maxrefCount;
        public StepReferences()
        {
            InitializeComponent();
        }
        public void GetStepsReferencedata(string referenceId, string RectID, string StepId, int StepCount)
        {
            _referenceId = referenceId;
            _rectId = RectID;
            _StepId = StepId;
            _stepcount = StepCount;
        }
        private void StepReferences_Load(object sender, EventArgs e)
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + @"\Images\Reference\";
            _listRectmodel = bm.GetRectdataByRectfid(Convert.ToInt32(_rectId));
            lblheader.Text = _listRectmodel[0].RectificationItems;
            StringBuilder messageBuilder = new StringBuilder(200);
            var AllStepsResult = bm.GetModelStepsReferenceData(Convert.ToInt32(_StepId));
            maxrefCount = AllStepsResult.Count;
            if (_refernceCount == 0)
                _refernceCount = 1;

            if (maxrefCount > 0)
            {
                if (_refernceCount == maxrefCount && Convert.ToInt32(_StepId) == _stepcount)
                {
                    btnnext.Text = "Procedure completed click to close";
                    btnlast.Text = "";
                    btnlast.Visible = false;
                }
                else if (Convert.ToInt32(_StepId) == _stepcount && _refernceCount < maxrefCount && _refernceCount > 1)
                {
                    btnnext.Text = "Next";
                    btnlast.Text = "Skip";
                    btnlast.Visible = false;
                }
                else if (Convert.ToInt32(_StepId) < _stepcount && _refernceCount == maxrefCount)
                {
                    btnnext.Text = "IF SNAG RECTIFIED COMPLETE";
                    btnlast.Text = "IF NOT  RECTIFIEDNEXT";
                    btnlast.Visible = true;
                }
                else
                {
                    btnnext.Text = "Next";
                    btnlast.Text = "Skip";
                    btnlast.Visible = false;
                }
                var AllStepsResultByID = bm.GetModelStepsReferenceData(Convert.ToInt32(_StepId), _refernceCount);
                for (int i = 0; i < AllStepsResultByID.Count; i++)
                {
                    pictureBox1.Image = Image.FromFile(path + AllStepsResultByID[i].LinkPath.ToString());

                    messageBuilder.Append(AllStepsResultByID[i].RefMaterialTitle);
                    messageBuilder.Append(Environment.NewLine);
                    messageBuilder.Append(AllStepsResultByID[i].RefMaterialContent);
                    lblContent.Text = messageBuilder.ToString();
                }
            }
          
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int StepId = Convert.ToInt32(_StepId);
            if (StepId > _stepcount)
            {
                SnagCompletionForm Sc = new SnagCompletionForm();
                Sc.getFormInformation(Convert.ToInt32(_rectId));
                this.Hide();
                Sc.Show();
            }
            else
            {
                StepReferences sbobj = new StepReferences();
                _refernceCount += 1;
                sbobj.GetStepsReferencedata(_referenceId, _rectId, _StepId, _stepcount);
                this.Hide();
                sbobj.Show();
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            int StepId = Convert.ToInt32(_StepId);
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
                StepDetails sbobj = new StepDetails();                
                _refernceCount = 1;
                sbobj.GetStepsdata(AllStepsResult, _referenceId, Convert.ToString(_rectId), Convert.ToString(StepId), _stepcount);
                this.Hide();
                sbobj.Show();
            }
        }
    }
}
