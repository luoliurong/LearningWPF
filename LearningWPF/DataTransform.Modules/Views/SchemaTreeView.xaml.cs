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

namespace DataTransform.Modules.Views
{
	/// <summary>
	/// Interaction logic for SchemaTreeView.xaml
	/// </summary>
	public partial class SchemaTreeView : UserControl
	{
		public SchemaTreeView()
		{
			InitializeComponent();
			var vm = new ViewModels.SchemaTreeViewModel();
			base.DataContext = vm;
			this.schemaTree.ItemsSource = vm.treeList;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("HELLO");
		}
	}
}
