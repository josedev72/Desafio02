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
    public partial class FormVenta : Form
    {
        private int id;
        public FormVenta(int id)
        {
            InitializeComponent();
            this.id = id;
        }
    }
}
