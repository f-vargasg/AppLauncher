using AppLauncher.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLauncher.ALGenCallsSabNetSrv
{
    public partial class FrmPrincCallSabNet : Form
    {

        private bool hideExitButton;
        public FrmPrincCallSabNet()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["frmCaption"];
            txtServName.Text = ConfigurationManager.AppSettings["defServiceName"];
            txtDbOwner.Text = ConfigurationManager.AppSettings["dbOwner"];
            txtEntityName.Text = "entTest";
            txtEntityOption.Text = "0";


            this.hideExitButton = Convert.ToBoolean(ConfigurationManager.AppSettings["hideExitButton"]);
            var btnRead = tlStripOptions.Items.Find("tlStrpSalir", true);  // get BtnRead on toolstrip Item.Find
            btnRead[0].Visible = !this.hideExitButton; // disable/Enable btn
        }

        private void tlStrpSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlsButExecute_Click(object sender, EventArgs e)
        {
            try
            {
                OracleMetadataBL ometaBL = new OracleMetadataBL();
                string scrap = ometaBL.ObtCallCSharp(txtServName.Text, txtServName.Text, txtEntityName.Text,
                               Convert.ToInt32(txtEntityOption.Text), txtDbOwner.Text);
                txtCSharpInvok.Text = scrap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
