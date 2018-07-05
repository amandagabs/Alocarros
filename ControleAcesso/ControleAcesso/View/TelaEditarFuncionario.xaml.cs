using ControleAcesso.Controller;
using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControleAcesso.View
{
    /// <summary>
    /// Lógica interna para TelaEditarFuncionario.xaml
    /// </summary>
    public partial class TelaEditarFuncionario : Window
    {
        private static Funcionario funcionario;
        public TelaEditarFuncionario(Funcionario func)
        {
            InitializeComponent();
            
            funcionario = func;
            try
            {

                txtNome.Text = func.Nome;
                CPF.Text = func.CPF;
                Nasc.Text = func.Nasc;
                Telefone.Text = func.Telefone;
                Empresa.Text = func.Empresa;
                Matricula.Text = func.Matricula;

            }
            catch { }
             
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tela = new MainWindow();
            tela.Show();
            Close();
        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            funcionario.Nome = txtNome.Text;
            funcionario.CPF = CPF.Text;
            funcionario.Nasc = Nasc.Text;
            funcionario.Telefone = Telefone.Text;
            funcionario.Empresa = Empresa.Text;
            funcionario.Matricula = Matricula.Text;
            funcionarioController.Atualizar(funcionario);

            MessageBox.Show("Funcionário Editado com sucesso.");
        }
    }
}
