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
using Wpf_naz.bd_main;
using Wpf_naz.Class;

namespace Wpf_naz.Page_Main
{
	/// <summary>
	/// Логика взаимодействия для Page_qw.xaml
	/// </summary>
	public partial class Page_qw : Page
	{
		public Page_qw()
		{
			InitializeComponent();
		}

		private void bt_vhod_Click(object sender, RoutedEventArgs e)
		{
			var userObj = AppData.db.User.FirstOrDefault(
				x => x.Login == tb_login.Text && x.Password == tb_pass.Text);

			if (userObj == null)
			{
				MessageBox.Show("Такого пользователя не сущевствует");
			}
			else
			{
				switch (userObj.Role_Id)
				{
					case 1:
						MessageBox.Show("Ваш профиль admin");
						break;
						case 2:
						MessageBox.Show("Ваш профиль user");
						break;
				}
			}
					
		}
	}
}
