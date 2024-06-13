using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using california.e.BO;

namespace california.e.UI
{
    public partial class telaFuncionario : Form
    {
        public telaFuncionario()
        {
            InitializeComponent();
        }

       
        private void CadFun_Click(object sender, EventArgs e)
        {
            funcionario classFuncionario = new funcionario();

           
                classFuncionario.cargoFunc = cargoFuncTxt.Text;
                classFuncionario.usuarioFunc = usrFuncTxt.Text;
                classFuncionario.senhaFunc = pwdFuncTxt.Text;
                classFuncionario.nomeFunc = nomeFuncTxt.Text;
                classFuncionario.cpfFunc = cpfFuncTxt.Text;
                classFuncionario.telefoneFunc = telFuncTxt.Text;
                classFuncionario.enderecoFunc = endFuncTxt.Text;

                try
                {
                    classFuncionario.dtNascimento = DateTime.Parse(dtNacFuncTxt.Text);
                }
                catch
                {
                    MessageBox.Show("data de nascimento esta errada");
                }

            if (cargoFuncTxt.Text == "" || usrFuncTxt.Text=="" || pwdFuncTxt.Text=="" || nomeFuncTxt.Text=="" || cpfFuncTxt.Text==""|| dtNacFuncTxt.Text=="" || telFuncTxt.Text=="" || endFuncTxt.Text=="")
            {
                MessageBox.Show("Por favor preencha os campos");
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }


            cargoFuncTxt.Text = "";
            usrFuncTxt.Text = ""; 
            pwdFuncTxt.Text = "";
            nomeFuncTxt.Text = ""; 
            cpfFuncTxt.Text = ""; 
            dtNacFuncLbl.Text = "";
            telFuncTxt.Text = "";
            endFuncTxt.Text = ""; 
            
        }

        private void lnkVoltarCli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkVoltarFun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }

        private void telaFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
