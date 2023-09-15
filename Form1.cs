using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDA
{
    public partial class frmTienda : Form
    {
        public frmTienda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos oProdutos = new Produtos();
            oProdutos.grabar (Convert.ToInt32(txtCodigoP.Text), txtNombreP.Text, Convert.ToInt32(txtStockP.Text)); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produtos oProdutos = new Produtos();
            oProdutos.listar(dataGridView1);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produtos oProdutos = new Produtos();
            oProdutos.eliminar(Convert.ToInt32(txtCodigoP.Text));


        }
    }
}
