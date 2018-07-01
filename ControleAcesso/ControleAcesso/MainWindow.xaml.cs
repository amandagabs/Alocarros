using ControleAcesso.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControleAcesso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CadastroFuncionario_Click(object sender, RoutedEventArgs e)
        {
            TelaCadastroFuncionario tela = new TelaCadastroFuncionario();
            tela.Show();
            Close();

        }

        private void ListarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            TelaListarFuncionario tela = new TelaListarFuncionario();
            tela.Show();
            Close();
        }

        private void EditarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            TelaEditarFuncionario tela = new TelaEditarFuncionario();
            tela.Show();
            Close();
        }

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
