﻿using System;
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
	/// Interaction logic for TransformationTreeView.xaml
	/// </summary>
	public partial class TransformationTreeView : UserControl
	{
		public TransformationTreeView()
		{
			InitializeComponent();


			List<TransformationTree> schemaTree = new List<View.TransformationTree>();

			for (var i = 1; i <= 10; i++)
			{
				TransformationTree tree = new View.TransformationTree() { Name = "Transformation" + i.ToString() };
				tree.Nodes.Add(new Node() { Name = "SourceDatabase" });
				tree.Nodes.Add(new Node() { Name = "TargetDatabase" });
				schemaTree.Add(tree);
			}

			this.TransformationTree.ItemsSource = schemaTree;
		}
	}

	public class TransformationTree
	{
		public ObservableCollection<Node> Nodes { get; set; }
		public TransformationTree()
		{
			this.Nodes = new ObservableCollection<View.Node>();
		}

		public string Name { get; set; }
	}
}