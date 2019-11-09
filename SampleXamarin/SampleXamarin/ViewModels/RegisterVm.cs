using System;
using System.Collections.Generic;
using System.Text;
using SampleXamarin.Core;
using Xamarin.Forms;

namespace SampleXamarin.ViewModels
{
    public class RegisterVm : BaseViewModel
    {
        public override Page View { get; set; } = new Views.Registration();


    }
}
