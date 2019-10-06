using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IDB_BISEW
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Information : Page
    {
        public Information()
        {
            this.InitializeComponent();
            this.button2.Click += Button2_Click;

            TraineeInformation traineeInformation = new TraineeInformation
            {
                Name = "Akib",
                Round = "39",
                CourseName = "C#",
                BachNo = "ESAD-CS/NVIT-A/39/01",
                TSPName = "NVIT",
                TrainerName = "Mr. MD Faysal Wahid"
            };

            this.DataContext = traineeInformation;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

       

       
    }
}
