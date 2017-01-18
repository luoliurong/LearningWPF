using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataTransform.Modules.ViewModels
{
	public class TopMenuViewModel:BindableBase
	{
		public TopMenuViewModel()
		{
			this.NewRepositoryRequest = new InteractionRequest<INotification>();
			this.CustomPopupViewRequest = new InteractionRequest<INotification>();
			this.RaiseNewRepositoryCommand = new DelegateCommand(RaiseNewRepositoryNotification);
			this.LoadSchemaCommand = new DelegateCommand(this.RaiseCustomPopupView);
		}
		public InteractionRequest<INotification> NewRepositoryRequest { get; private set; }
		public InteractionRequest<INotification> CustomPopupViewRequest { get; private set; }
		public ICommand RaiseNewRepositoryCommand { get; private set; }
		public ICommand LoadSchemaCommand { get; private set; }

		public void RaiseNewRepositoryNotification()
		{
			this.NewRepositoryRequest.Raise(
				new Notification { Content = "Notification Message", Title = "Notification" }
				);
		}

		public void RaiseAboutCommandNotification()
		{

		}

		private void RaiseCustomPopupView()
		{
			// In this case we are passing a simple notification as a parameter.
			// The custom popup view we are using for this interaction request does not have a DataContext of its own
			// so it will inherit the DataContext of the window, which will be this same notification.
			//this.InteractionResultMessage = "";
			this.CustomPopupViewRequest.Raise(
				new Notification { Content = "Message for the CustomPopupView", Title = "Custom Popup" });
		}
	}
}
