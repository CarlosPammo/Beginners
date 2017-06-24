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
    /// Lógica de interacción para Mas.xaml
    /// </summary>
    public partial class Mas : Window
    {
        private List<Person> mas { get; set; }
        public Mas()
        {
            InitializeComponent();
            InitRP();
        }
        public void InitRP()
        {
            mas = new List<Person>
                           {
                               new Person
                                   {
                                       //Id=1,
                                        dir= "calle viva",
                                        fax="4315027",
                                        trabajo="4448746",
                                        referencia = "4684159",
                                        otros="marcelo@hotmail.es",
                                   },
                                   new Person
                                   {
                                       //Id=2,
                                        dir = "av oquendo",
                                        fax="4745872",
                                        trabajo="4444478",
                                        referencia = "4475846",
                                        otros="briam@hotmail.es",
                                   }
                           };

            DGmas.DataContext = mas;
            DGmas.Items.Refresh();
        }

        private void DGmas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //boton atras
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
