using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deDupeTOMIS
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FrState.ippConnect = false;
            FrState.ippLocal = true;
            Update_Status();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Update_Status();
        }

        public void Update_Status()
        {
            if (FrState.ippConnect)
            {
                ippConStatus.Text = "CONNECTED";
                ippConStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                ippConStatus.Text = "NOT CONNECTED";
                ippConStatus.ForeColor = System.Drawing.Color.Red;
            }

            if (FrState.ippLocal)
            {
                ippEndPtStat.Text = "LOCAL";
                ippEndPtStat.ForeColor = System.Drawing.Color.Green;
            } else
            {
                ippEndPtStat.Text = "REMOTE";
                ippEndPtStat.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            FrState.ippLocal = !FrState.ippLocal;
            Update_Status();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!FrState.ippConnect)
            {
                btnConnect.Text = "Disconnect From IPP";
                FrState.ippConnect = btnDeDupStart.Enabled = btnGenerateTemplate.Enabled = btnGenTemplates.Enabled = true;
            } else
            {
                btnConnect.Text = "Connect To IPP";
                FrState.ippConnect = btnDeDupStart.Enabled = btnGenerateTemplate.Enabled = btnGenTemplates.Enabled = false;
            }
            Update_Status();
        }
    }
}
