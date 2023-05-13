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
    public partial class Component : Form
    {
        List<Models.StepsModel> _listStepsmodel;
        BussinessLogic.BusinessModel bm = new BussinessLogic.BusinessModel();
        string _referenceId;
        string _rectId;
        string _StepId;
        public Component()
        {
            InitializeComponent();
        }
        public void GetStepsComponentdata(string referenceId, string RectID, string StepId)
        {
            _referenceId = referenceId;
            _rectId = RectID;
            _StepId = StepId;
        }
        private void Component_Load(object sender, EventArgs e)
        {
            var AllStepsResult = bm.GetModelStepsComponentData(Convert.ToInt32(_StepId));
            int x = 33, y = 29;
            int top = 80;
            int left = 50;
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + @"\Images\Component\";
            List<PictureBox> pictureBoxList = new List<PictureBox>();
            //lblSystemTitle.Text = sysObj.SystemName + "SELECT SUBSYSTEM";
            for (int i = 0; i < AllStepsResult.Count; i++)
            {
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = new Size(316, 320),
                    Location = new Point(i * 316, 1),                               
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
             
                picture.Image = Image.FromFile(path + AllStepsResult[i].ProcedureLinkPath.ToString());             
                pictureBoxList.Add(picture);

            }
            foreach (PictureBox p in pictureBoxList)
            {
                panel1.Controls.Add(p);
            }
            this.Controls.Add(panel1);
            label1.Text = AllStepsResult[0].ProcedureTitle;
        }
    }
}
