using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public partial class Form1 : Form
    {
        Stack<String> pilha = new Stack<String>(); //global

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {

        }

        void mostraPilha()
        {
            listHistorico.Items.Clear();
            foreach(String url in pilha)
            {
                listHistorico.Items.Add(url+"\r\n");
            }
        }
        //-------------------------------
        private void btnIr_Click(object sender, EventArgs e)
        {
            pilha.Push(txtUrl.Text);
            webNavegador.Navigate(txtUrl.Text);
            mostraPilha();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (pilha.Count > 1)
            {
                pilha.Pop(); // tirando o endereço atual do topo
                txtUrl.Text = pilha.Pop();
                webNavegador.Navigate(txtUrl.Text);
                mostraPilha();
            }// fim if
            else
                MessageBox.Show("Não tenho para onde voltar :(");
        }// fim metodo voltar
    }
}
