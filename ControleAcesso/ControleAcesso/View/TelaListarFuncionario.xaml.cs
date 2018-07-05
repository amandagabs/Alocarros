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
    /// < summary>
    /// Lógica interna para TelaListarFuncionario.xaml
    /// </summary>
    public partial class TelaListarFuncionario : Window
    {
        public TelaListarFuncionario()
        {
            InitializeComponent();
            AtualizarGrid();
            Nome.Text = "";
        }

        private void AtualizarGrid(string find = "")
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            Lista_de_Cadastros.ItemsSource = funcionarioController.ListarFuncionarios(find);
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i == 0) Lista_de_Cadastros.Columns[i].Visibility = Visibility.Hidden;
                }
                
                    }
            catch { }
        }
        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Funcionario funcionario = (Funcionario)Lista_de_Cadastros.Items[Lista_de_Cadastros.SelectedIndex];
                if (funcionario.FuncionarioID > 0)
                {
                    MessageBoxResult result = MessageBox.Show("Deseja mesmo remover este funcionário?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        Controller.FuncionarioController funcionarioController = new FuncionarioController();
                        funcionarioController.Desativar(funcionario);
                        MessageBox.Show("Funcionário removido com sucesso.");
                        AtualizarGrid(Nome.Text);
                    }
                }
            }
            catch { }
        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            AtualizarGrid(Nome.Text);
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tela = new MainWindow();
            tela.Show();
            Close();

        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Funcionario funcionario = (Funcionario)Lista_de_Cadastros.Items[Lista_de_Cadastros.SelectedIndex];
                if (funcionario.FuncionarioID > 0)
                {
                    TelaEditarFuncionario tela = new TelaEditarFuncionario(funcionario);
                    tela.Show();
                    Close();
                }
            }
            catch { }
        }

        private void Lista_de_Cadastros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }
    }
    
}
