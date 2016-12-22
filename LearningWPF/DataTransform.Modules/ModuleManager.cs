using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransform.Modules.Views;

namespace DataTransform.Modules
{
	public class ModuleManager : IModule
	{
		IRegionManager _regionManager;
		public ModuleManager(IRegionManager regionManager)
		{
			_regionManager = regionManager;
		}
		public void Initialize()
		{
			_regionManager.RegisterViewWithRegion("SchemaTreeRegion", typeof(SchemaTreeView));
			_regionManager.RegisterViewWithRegion("TopMenuRegion", typeof(TopMenuView));
			_regionManager.RegisterViewWithRegion("TransformationTreeRegion", typeof(TransformationTreeView));
			_regionManager.RegisterViewWithRegion("ErrorListRegion", typeof(ErrorListView));
		}
	}
}
