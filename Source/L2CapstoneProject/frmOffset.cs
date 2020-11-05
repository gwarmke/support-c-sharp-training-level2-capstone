using NationalInstruments.Restricted;
using System;
using System.Windows.Forms;

namespace L2CapstoneProject
{
    public partial class frmOffset : Form
    {
        public enum Mode { Add, Edit }

        public Mode ViewMode { get; }

        public frmOffset(Mode mode)
        {
            InitializeComponent();
            ViewMode = mode;

            switch (ViewMode)
            {
                case Mode.Add:
                    this.Text = "Add New Offset";
                    break;
                case Mode.Edit:
                    this.Text = "Edit Offset";
                    break;
            }


        }

        public decimal getPhase()
        {
            return numPhase.Value;
        }

        public decimal getAmp()
        {
            return numAmp.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void numPhase_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void numAmp_ValueChanged(object sender, EventArgs e)
        {
            decimal ampValue = numAmp.Value;
        }
    }
}
