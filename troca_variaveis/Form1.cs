using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace troca_variaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, temp;

            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            temp = numero1;
            numero1 = numero2;
            numero2 = temp;


            // Exibe a mensagem de sucesso com os valores trocados
            MessageBox.Show("Os valores foram trocados com sucesso!\nNúmero 1 = " + numero1 + "\nNúmero 2 = " + numero2, "TCHARAM");
        }
    }
    }

