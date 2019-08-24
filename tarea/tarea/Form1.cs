using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            string nombre = TbName.Text;
            string contraseña = TbPassword.Text;
            if (nombre == "Juancho" && contraseña == "123tamarindo")
            {
                   MessageBox.Show("Bienvenido al feis de los avengadores");
               
            }
            else
            {
                MessageBox.Show("Tas mal mijo");
            }
        }
    }
}
