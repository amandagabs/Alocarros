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
    /// Interaction logic for TelaCadastroFuncionario.xaml
    /// </summary>
    public partial class TelaCadastroFuncionario : Window
    {
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tela = new MainWindow();
            tela.Show();
            Close();

        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.Nasc = txtNasc.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Empresa = txtEmpresa.Text;
            funcionarioController.Adicionar(funcionario);
        }
    }
}
