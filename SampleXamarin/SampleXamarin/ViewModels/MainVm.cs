using SampleXamarin.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleXamarin.ViewModels
{
    public class MainVm : BaseViewModel
    {
        public MainVm()
        {
            CommandRegister = new LockCommand(this, ActionRegister);
            CommandAuth = new LockCommand(this, ActionAuth);
        }

        public LockCommand CommandRegister { get; set; }
        public LockCommand CommandAuth { get; set; }

        public override Page View { get; set; } = new Views.MainPage();

        private async Task ActionRegister()
        {
            var vm = new RegisterVm();
            await NavigateTo(vm);
        }
        private async Task ActionAuth()
        {
            var vm = new HomeVm();
            await NavigateTo(vm);
        }
    }
}
