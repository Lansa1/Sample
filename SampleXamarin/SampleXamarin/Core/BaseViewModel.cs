using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleXamarin.Core
{
    public abstract class BaseViewModel : BaseNotify
    {
        public BaseViewModel()
        {

        }

        public abstract Page View { get; set; }
    }
}
