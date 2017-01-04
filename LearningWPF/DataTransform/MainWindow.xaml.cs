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
using Ron.WPF.Controls;

namespace DataTransform
{
	public partial class MainWindow : MetroWindow
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

		private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("New command triggered.");
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
