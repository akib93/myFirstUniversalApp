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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IDB_BISEW
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            TraineeInfo traineeInfo = new TraineeInfo
            {
                ID = "1",
                TraineeName = "Akib",
                Email = "mdakib@gmail.com",
                PHone = "018244599614",
                
            };

            this.DataContext = traineeInfo;

            this.InitializeComponent();
           
            this.button4.Click +=Login_Click;
        }
        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            if (userID.Text == "Akib" && Password.Text == "12345")
            {
                this.Frame.Navigate(typeof(Information));
            }
            else
            {
                ContentDialog dialog = new ContentDialog()
                {
                    Title="Error!!!",MaxWidth=this.ActualWidth,Height=this.ActualHeight,PrimaryButtonText="OK",
                    Content=new TextBlock
                    {
                        Text="Incorrect Username OR Password!!!",
                        FontSize=25
                    },
                };
                await dialog.ShowAsync();
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Information));
        }
    }
}
