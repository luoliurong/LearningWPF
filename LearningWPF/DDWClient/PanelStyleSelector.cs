using DataTransform.Common;
using System.Windows;
using System.Windows.Controls;

namespace DataTransform
{
	public class PanelStyleSelector : StyleSelector
	{
		public Style DockablePanelStyle { get; set; }
		public Style TransformationPanelStyle { get; set; }
		public override Style SelectStyle(object item, DependencyObject container)
		{
			if(item is IDockablePanel)
			{
				return DockablePanelStyle;
			}

			if(item is ITransformationPanel)
			{
				return TransformationPanelStyle;
			}

			return base.SelectStyle(item, container);
		}
	}
}
