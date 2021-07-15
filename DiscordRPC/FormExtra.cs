using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordRPC
{
    public partial class FormExtra : Form
    {
        // private CustomRPCManager customRPCManager;
        
        public FormExtra()
        {
            InitializeComponent();
        }

        private void FormExtra_Load(object sender, EventArgs e)
        {
            // this.customRPCManager = parent.GetRPCManager();
        }

        private void LoadRPCManager()
        {
            // dis_enable_extra.Checked = this.customRPCManager.extra_enabled;
        }

        private void dis_enable_extra_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
