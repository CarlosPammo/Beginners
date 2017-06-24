using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfDelegates.Model;

namespace WpfDelegates
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnRegisterPerson_Mode_Click(object sender, RoutedEventArgs e)
        {
            Person mode = new Person();
            MainWindow modeMainWindow = new MainWindow();
            modeMainWindow.Show();
        }
    }
}
