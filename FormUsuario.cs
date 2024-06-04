using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02
{
    public partial class FormUsuario : Form
    {
        private int id;
        public FormUsuario(int id)
        {
            InitializeComponent();
            this.id = id;
        }
    }
}
