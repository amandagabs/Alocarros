using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso.View
{
    public partial class Visitante : Form
    {
        public Visitante()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lbDateTime.Text = "Data: " + dataHora.ToShortDateString() + "Hora: " + dataHora.ToLongDateString();
        }
        private void Visitante_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
        }
    }
}
