using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Resources;

namespace App_Multi_Idioma
{
    class Idioma
    {
        public static void AjustaCultura(Form frm, string Cultura)
        {
            AlteraIdioma(Cultura);

            ComponentResourceManager resx = new System.ComponentModel.ComponentResourceManager(frm.GetType());

            AlteraCultura(frm, resx);
        }

        private static void AlteraIdioma(string Cultura)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Cultura, true);

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Cultura, true);
        }

        private static void AlteraCultura(Form frm, ComponentResourceManager resx)
        {
            frm.Text = resx.GetObject("$this.Text", Thread.CurrentThread.CurrentCulture).ToString();

            foreach(Control x in frm.Controls)
            {
                resx.ApplyResources(x, x.Name, Thread.CurrentThread.CurrentCulture);
            }
        }

        public static string RetornaMensagem(string NomeMensagem)
        {
            ResourceManager resx = new ResourceManager(typeof(Mensagem));

            return resx.GetString(NomeMensagem, Thread.CurrentThread.CurrentCulture);
        }
    }
}
