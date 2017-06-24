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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDelegates.Model;

namespace WpfDelegates
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<Person> Persons { get; set; }

		public MainWindow()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
            Persons = new List<Person>
				           {
							   new Person
                                   {
                                        Name = "Marcelo",
                                        LastnameDad="catari",
                                        Telephone = "44898310",
                                        Celular="67689411",
                                        Address="villa pagador",
                                        Correo="marcelo_ticona"
                                   },
								   new Person
                                   {
										Name = "Briam",
                                        LastnameDad="Felipe",
										Telephone = "4445202",
                                        Celular="65324969",
                                        Address="españa",
                                        Correo="jhom_briam"
                                   },
				           };

            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
        }

		private void BtnCerrar_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void BtnNew_Click(object sender, RoutedEventArgs e)
		{
            EditarContacto editor = new EditarContacto();
			editor.OnAccept += AddNewCoctact;
			editor.Show();

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Person selected = (Person)DGListPerson.SelectedItem;
            EditarContacto editor = new EditarContacto(selected);
            editor.OnAccept += AddNewCoctact;
            editor.Show();
        }
        private void AddNewPerson(Person person)
        {
            Persons.Add(person);
            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
        }

		private void AddNewCoctact(Contact contact)
		{

            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
		}

        private void DGContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Person mode = new Person();
            Mas modeMas = new Mas();
            modeMas.Show();
        }

        private void DGListPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //la clave
           /*EditarContacto editor = new EditarContacto();
            editor.OnAccept += AddNewCoctact;
            editor.Show();*/

            /*Person mode = new Person();
            Mas modeMas = new Mas();
            modeMas.Show();*/
        }
        private void Updatee_Click(object sender, RoutedEventArgs e)
        {
            Person mode = new Person();
            Mas modeMas = new Mas();
            modeMas.Show(); 
        }
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
