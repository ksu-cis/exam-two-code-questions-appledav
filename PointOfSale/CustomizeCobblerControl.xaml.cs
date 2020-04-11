using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {

        public Cobbler cobbler { get; set; }

        public CustomizeCobblerControl()
        {
            InitializeComponent();
            cobbler = new Cobbler();
            
        }


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "Peach":
                    cobbler.Fruit = FruitFilling.Peach;
                    cobbler.InvokePropertyChanged("Fruit");
                    break;

                case "Cherry":
                    cobbler.Fruit = FruitFilling.Peach;
                    cobbler.InvokePropertyChanged("Fruit");
                    break;

                case "BlueBerry":
                    cobbler.Fruit = FruitFilling.Peach;
                    cobbler.InvokePropertyChanged("Fruit");
                    break;

                case "IceCream":
                    cobbler.WithIceCream = true;
                    cobbler.InvokePropertyChanged("WithIceCream");
                    break;
            }
            
        }
    }
}
