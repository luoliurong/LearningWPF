using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DataTransform.Modules;
using Prism.Modularity;
using Microsoft.Practices.Unity;

namespace DataTransform
{
	public class Bootstrapper : UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return Container.Resolve<MainWindow>();
		}
		protected override void InitializeShell()
		{
			base.InitializeShell();
		}
		protected override void ConfigureModuleCatalog()
		{
			ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
			catalog.AddModule(typeof(Modules.ModuleManager));
		}
	}
}
