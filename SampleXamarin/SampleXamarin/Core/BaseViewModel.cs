using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleXamarin.Core
{
    public abstract class BaseViewModel : BaseNotify
    {
        public BaseViewModel()
        {
            View.BindingContext = this; // привязка к странице 
        }

        public bool IsBusy { get; set; }

        public abstract Page View { get; set; }

        public async Task NavigateTo(BaseViewModel vm)
        {
            await View.Navigation.PushAsync(vm.View);
        }
    }
}
