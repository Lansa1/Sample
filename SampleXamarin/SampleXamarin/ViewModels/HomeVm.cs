using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SampleXamarin.Core;
using SampleXamarin.Models;
using Xamarin.Forms;

namespace SampleXamarin.ViewModels
{
    public class HomeVm:BaseViewModel
    {
        private Track selectedTrack;
        
        public HomeVm()
        {
            CommandAdd = new LockCommand(this, ActionAdd);
        }

        public Track SelectedTrack { 
            get => selectedTrack;
            set {  
                selectedTrack = value;
                ActionSelectTrack(value);
            } 
        }

        public LockCommand CommandAdd { get; set; }
        public LockCommand CommandSelectTrack { get; set; }
        public ObservableCollection<Track> Tracks { get; set; } = new ObservableCollection<Track>();

        public override Page View { get; set; } = new Views.Home();

        private void ActionAdd()
        {
            var item = new Track
            {
                Position = Tracks.Count + 1,
                Artist = "FACE",
                Name = "Я роняю запад",
                Path = "C:/Musics/MyMusics",
            };
            Tracks.Add(item);
        }

        private void ActionSelectTrack(object obj)
        {
            if (obj is Track track)
            {

            }
        }
    }
}
