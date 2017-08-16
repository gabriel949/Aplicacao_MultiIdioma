using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Multi_Idioma
{
    public partial class frmMI : Form
    {
        public frmMI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void pctBR_Click(object sender, EventArgs e)
        {
            Idioma.AjustaCultura(this, "pt-BR");
        }

        private void pctFR_Click(object sender, EventArgs e)
        {
            Idioma.AjustaCultura(this, "fr-FR");
        }

        private void pctGB_Click(object sender, EventArgs e)
        {
            Idioma.AjustaCultura(this, "en-GB");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Idioma.RetornaMensagem("MensagemEnvio"), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
