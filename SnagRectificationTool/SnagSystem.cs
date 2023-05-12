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
        public SnagSystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SnagSystem_Load(object sender, EventArgs e)
        {
          
            //btnAeroEngine.Click+= btnAeroEngine_Click;
            //btnAeroEngine.Click -= btnAeroEngine_Click;

        }
        SubSystem sub = new SubSystem();

        private void btnAeroEngine_Click(object sender, EventArgs e)
        {
            //DataCapturingAeroEngine dtcpae = new DataCapturingAeroEngine();
            this.Hide();
            // dtcpae.Show();
           
            sub.subSystemofAero();
            sub.Show();


        }
    }
}
