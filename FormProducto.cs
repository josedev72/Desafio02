using Desafio02.Models;
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
    public partial class FormProducto : Form
    {
        private int Id;

        public FormProducto(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
