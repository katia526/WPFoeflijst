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

namespace WPFoeflijst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<persoon> MyList { get; set; } = new List<persoon>();
        public MainWindow()
        {
            InitializeComponent();
            MyList.Add(new persoon() { ImagePath = @"\image\mickey_mouse.png" });
            MyList.Add(new persoon() { ImagePath = @"\image\peter_pan.png" });
            MyList.Add(new persoon() { ImagePath = @"\image\pirate.png" });
            MyList.Add(new persoon() { ImagePath = @"\image\pluto.png" });
            MyList.Add(new persoon() { ImagePath = @"\image\mowgli.png" });

            LstBox.ItemsSource = MyList;
            LstBox.SelectedIndex = 0;
        }
        private void LstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            persoon selectedItem = (LstBox.SelectedItem as persoon);
            var test = selectedItem.ImagePath;
            Image img = new Image();
          // foto.Source = new BitmapImage(new Uri(selectedItem.ImagePath, UriKind.Relative));

        }
        public class persoon
        {
           
            public string ImagePath { get; set; }
        }

    }

}

