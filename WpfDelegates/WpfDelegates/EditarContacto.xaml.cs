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
	/// Interaction logic for EditarContacto.xaml
	/// </summary>
	public partial class EditarContacto : Window
	{
        private Person Person { get; set; }
		public delegate void GetContact(Person contact);
		public event GetContact OnAccept;

        public EditarContacto()
        {
            InitializeComponent();
            Person = new Person();
        }

		public EditarContacto(Person persons) : this()
		{
            TbName.Text = persons.Name;
            TbLastnameDad.Text = persons.LastnameDad;
            TbTelephone.Text = persons.Telephone;

            TbAddress.Text = persons.Address;

            Person = persons;
        }

       
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void BtnAccept_Click(object sender, RoutedEventArgs e)
		{
            Person.Name = TbName.Text;
            Person.LastnameDad = TbLastnameDad.Text;
            Person.Telephone = TbTelephone.Text;
            Person.Address = TbAddress.Text;

            OnAccept(Person);
            Close();
        }

        private void TbLastnameDad_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TbTelephone_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
