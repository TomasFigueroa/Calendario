using System;
using Backend;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        private Fecha day = new Fecha();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtA.Text !="" || TxtDia.Text != "" || TxtMes.Text !="")
            {
                day.fecha = Convert.ToInt32(TxtA.Text);
                day.dia = Convert.ToInt32(TxtDia.Text);
                day.mes = Convert.ToInt32(TxtMes.Text);


                texto.Text =(  day.fechacom()+" "+ "de" +" "+ day.Mes()+ " de "+ day.fecha);

            }
        }
    }
}
