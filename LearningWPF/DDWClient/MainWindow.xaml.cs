using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Xceed.Wpf.AvalonDock.Layout;
using Xceed.Wpf.AvalonDock.Layout.Serialization;
using Xceed.Wpf.AvalonDock;

namespace DataTransform
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void OnDocumentPanelCreated(Xceed.Wpf.AvalonDock.Controls.LayoutDocumentPaneControl obj)
		{
		}

		private void PreviewMouseDown(object sender, MouseButtonEventArgs e)
		{

		}

		//private void OnLoadLayout(object sender, RoutedEventArgs e)
		//{
		//	var currentContentsList = dockManager.Layout.Descendents().OfType<LayoutContent>().Where(c => c.ContentId != null).ToArray();

		//	string fileName = (sender as MenuItem).Header.ToString();
		//	var serializer = new XmlLayoutSerializer(dockManager);
		//	using (var stream = new StreamReader(string.Format(@".\AvalonDock_{0}.config", fileName)))
		//		serializer.Deserialize(stream);
		//}

		//private void AddTwoDocuments_click(object sender, RoutedEventArgs e)
		//{
		//	var firstDocumentPane = dockManager.Layout.Descendents().OfType<LayoutDocumentPane>().FirstOrDefault();
		//	if (firstDocumentPane != null)
		//	{
		//		LayoutDocument doc = new LayoutDocument();
		//		doc.Title = "Test1";
		//		firstDocumentPane.Children.Add(doc);

		//		LayoutDocument doc2 = new LayoutDocument();
		//		doc2.Title = "Test2";
		//		firstDocumentPane.Children.Add(doc2);
		//	}
		//}

		//private void OnShowWinformsWindow(object sender, RoutedEventArgs e)
		//{
		//	var winFormsWindow = dockManager.Layout.Descendents().OfType<LayoutAnchorable>().Single(a => a.ContentId == "WinFormsWindow");
		//	if (winFormsWindow.IsHidden)
		//		winFormsWindow.Show();
		//	else if (winFormsWindow.IsVisible)
		//		winFormsWindow.IsActive = true;
		//	else
		//		winFormsWindow.AddToLayout(dockManager, AnchorableShowStrategy.Bottom | AnchorableShowStrategy.Most);
		//}
		//private void OnShowToolWindow1(object sender, RoutedEventArgs e)
		//{
		//	var toolWindow1 = dockManager.Layout.Descendents().OfType<LayoutAnchorable>().Single(a => a.ContentId == "toolWindow1");
		//	if (toolWindow1.IsHidden)
		//		toolWindow1.Show();
		//	else if (toolWindow1.IsVisible)
		//		toolWindow1.IsActive = true;
		//	else
		//		toolWindow1.AddToLayout(dockManager, AnchorableShowStrategy.Bottom | AnchorableShowStrategy.Most);
		//}

		//private void OnToolWindow1Hiding(object sender, System.ComponentModel.CancelEventArgs e)
		//{
		//	if (MessageBox.Show("Are you sure you want to hide this tool?", "AvalonDock", MessageBoxButton.YesNo) == MessageBoxResult.No)
		//		e.Cancel = true;
		//}
	}
}
