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
	public class SchemaTreeModule : IModule
	{
		IRegionManager _regionManager;
		public SchemaTreeModule(IRegionManager regionManager)
		{
			_regionManager = regionManager;
		}
		public void Initialize()
		{
			_regionManager.RegisterViewWithRegion("SchemaTreeRegion", typeof(SchemaTreeView));
		}
	}
}
