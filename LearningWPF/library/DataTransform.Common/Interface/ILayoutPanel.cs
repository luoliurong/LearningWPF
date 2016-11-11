using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransform.Common
{
	public interface ILayoutPanel
	{
		string ContentId { get; set; }
		bool IsActive { get; set; }
	}

	public interface IDockablePanel : ILayoutPanel
	{
		bool IsPanelVisible { get; set; }
	}

	public interface ITransformationPanel : ILayoutPanel
	{

	}
}
