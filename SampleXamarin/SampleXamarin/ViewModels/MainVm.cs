using SampleXamarin.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleXamarin.ViewModels
{
    public class MainVm : BaseViewModel
    {
        public override Page View { get; set; } = new Views.MainPage();

    }
}
