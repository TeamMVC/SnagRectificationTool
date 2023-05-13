using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnagRectificationTool.BussinessLogic;
namespace SnagRectificationTool
{
    public partial class SnagSystem : Form
    {
        SubSystem sub = new SubSystem();
        BusinessModel bm = new BusinessModel();
        public SnagSystem()
        {
            InitializeComponent();
        }

        private void SnagSystem_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            List<Models.SubSystem> subSystems = new List<Models.SubSystem>();
            subSystems = bm.GetAllSubSystem();
            
            comboBox1.DataSource = subSystems;
            comboBox1.DisplayMember = "SubSystemName";
            comboBox1.ValueMember = "SubSystemId";

            foreach (var p in bm.GetAllSubSystem())
                ac.Add(p.SubSystemName);
            comboBox1.AutoCompleteCustomSource = ac;
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;

            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //txtautobox.AutoCompleteCustomSource = ac;

        }
       
        private void btnAeroEngine_Click(object sender, EventArgs e)
        {
            //DataCapturingAeroEngine dtcpae = new DataCapturingAeroEngine();
            this.Hide();
            // dtcpae.Show();

            sub.subSystemofAero(1);
            sub.Show();


        }

        private void BtnElect_Click(object sender, EventArgs e)
        {
            this.Hide();
            // dtcpae.Show();

            sub.subSystemofAero(2);
            sub.Show();

        }

        private void btnAirFrame_Click(object sender, EventArgs e)
        {
            this.Hide();
            // dtcpae.Show();

            sub.subSystemofAero(3);
            sub.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.SelectedItem) == "")
                MessageBox.Show("Please select sub-system.");

            else
            {
                DataCapturingAeroEngine sbobj = new DataCapturingAeroEngine();               
                sbobj.getSubstemInformation(comboBox1.SelectedValue.ToString(), comboBox1.SelectedText.ToString());
                this.Hide();
                sbobj.Show();
            }
          
        }
    }
}
