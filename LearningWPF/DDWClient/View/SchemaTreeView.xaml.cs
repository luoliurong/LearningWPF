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
using System.Collections.ObjectModel;

namespace DataTransform.View
{
	/// <summary>
	/// Interaction logic for SchemaTreeView.xaml
	/// </summary>
	public partial class SchemaTreeView : UserControl
	{
		public SchemaTreeView()
		{
			InitializeComponent();

			List<SchemaTree> schemaTree = new List<View.SchemaTree>();

			for (var i = 1; i <= 10; i++)
			{
				SchemaTree tree = new View.SchemaTree() { Name = "Database"+i.ToString() };
				tree.Nodes.Add(new Node() { Name = "DATASET1" });
				tree.Nodes.Add(new Node() { Name = "DATASET2" });
				schemaTree.Add(tree);
			}

			this.SchemaTree.ItemsSource = schemaTree;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("you clicked me at time " + DateTime.Now.ToString());
		}
	}

	public class SchemaTree
	{
		public ObservableCollection<Node> Nodes { get; set; }
		public SchemaTree() {
			this.Nodes = new ObservableCollection<View.Node>();
		}

		public string Name { get; set; }
	}

	public class Node
	{
		public string Name { get; set; }
		public string Other { get; set; }
	}
}
