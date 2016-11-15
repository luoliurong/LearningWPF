using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransform.Modules.ViewModels
{
	public class SchemaTreeViewModel:BindableBase
	{
		public List<SchemaTree> treeList = new List<SchemaTree>();
		public List<SchemaTree> TreeList
		{
			get { return treeList; }
			set { SetProperty(ref treeList, value); }
		}
		public SchemaTreeViewModel()
		{
			for (var i = 1; i <= 10; i++)
			{
				SchemaTree tree = new SchemaTree() { Name = "Database" + i.ToString() };
				tree.Nodes.Add(new Node() { Name = "DATASET1" });
				tree.Nodes.Add(new Node() { Name = "DATASET2" });
				treeList.Add(tree);
			}
		}
	}

	public class SchemaTree
	{
		public ObservableCollection<Node> Nodes { get; set; }
		public SchemaTree()
		{
			this.Nodes = new ObservableCollection<Node>();
		}

		public string Name { get; set; }
	}

	public class Node
	{
		public string Name { get; set; }
		public string Other { get; set; }
	}
}
