using SnagRectificationTool.BussinessLogic;
using SnagRectificationTool.Models;
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
    public partial class SnagCompletionForm : Form
    {
        List<Models.ReqtificationItems> _listRectmodel;
        BusinessModel bdsystem = new BusinessModel();
        int _RectID;
        public SnagCompletionForm()
        {
            InitializeComponent();
        }
        public void getFormInformation(int RectID)
        {
            _RectID = RectID;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SubsytemInitialFormModel sm = new SubsytemInitialFormModel();
            if (!string.IsNullOrEmpty(txtGeneratedReference.Text))
            {
                var validReference = bdsystem.validReferenceId(txtGeneratedReference.Text);
                if (validReference == null) { MessageBox.Show("Wrong Reference Id "); return; } 
                if (validReference.DateOfCompletion != null)
                {
                    MessageBox.Show("This Rectification Process is Already Completed");
                    return;
                }

                if (validReference.RefId != null && validReference.DateOfCompletion==null)
                {
                    sm.AC_No = txtAcNo.Text;
                    sm.RefId = txtGeneratedReference.Text;
                    sm.TimeForRepairHrs = txtTimeForRepair.Text;
                    sm.ELECT = txtElect.Text;
                    sm.AEROENGINE = txtaeroEngine.Text;
                    sm.AIR_FRAME = txtAirFrame.Text;
                    sm.MANPOWER_UTILISED = txtManPower.Text;
                    sm.DateOfCompletion = dtcompletion.Value;


                    int result = bdsystem.UpdateCompletionForm(sm);

                    if (result > 0)
                    {
                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Reference Id");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Reference Id cannot be null");
                return;
            }
        }

        private void SnagCompletionForm_Load(object sender, EventArgs e)
        {
            _listRectmodel = bdsystem.GetRectdataByRectfid(_RectID);
            label2.Text= "SUMMARY OF RECTIFICATION :" + _listRectmodel[0].RectificationItems;
        }
    }
}
