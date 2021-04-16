using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace NewLibraries
{
    public partial class MainWindow : MetroWindow
    {
        public UInt32 timer = 0;

        public MainWindow()
        {
            InitializeComponent();
            Label1.Visibility = Visibility.Hidden;
            ProgressBar1.Visibility = Visibility.Hidden;
        }

        private void MetroProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    Label1.Visibility = Visibility.Visible;
                }
                else
                {
                    Label1.Visibility = Visibility.Hidden;
                }
            }
        }

        private void ToggleSwitch_Toggled1(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    ProgressBar1.Visibility = Visibility.Visible;
                }
                else
                {
                    ProgressBar1.Visibility = Visibility.Hidden;
                }
            }
        }

    }
}