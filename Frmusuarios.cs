using datos.accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioLogin
{
    public partial class Frmusuarios : Form
    {
        public Frmusuarios()
        {
            InitializeComponent();
        }
        usuarioDAA usuarioDAA = new usuarioDAA();
      
        private void Frmusuarios_Load(object sender, EventArgs e)
        {
            Listadesuarios();
        }
        private void Listadesuarios()
        {
            usuariodGV.DataSource = usuarioDAA.ListadeUsuarios();

        }
    }
}
