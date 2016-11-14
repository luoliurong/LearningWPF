using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Interactivity.InteractionRequest;
using System.Windows.Input;

namespace DataTransform.ViewModel
{
	public class TopMenuViewModel : BindableBase
	{
		public TopMenuViewModel()
		{
			this.NewRepositoryRequest = new InteractionRequest<INotification>();
			this.RaiseNewRepositoryCommand = new DelegateCommand(RaiseNewRepositoryNotification);
		}
		public InteractionRequest<INotification> NewRepositoryRequest { get; private set; }
		public ICommand RaiseNewRepositoryCommand { get; private set; }

		public void RaiseNewRepositoryNotification()
		{
			this.NewRepositoryRequest.Raise(
				new Notification { Content = "Notification Message", Title = "Notification" }
				);
		}
	}
}
