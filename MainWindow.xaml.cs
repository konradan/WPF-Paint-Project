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

namespace Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void InkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
            MessageBox.Show("Wyczyszczono projekt");
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Do zobaczenia :)");
            this.Close();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            SaveJPG jpg = new SaveJPG();
            jpg.ExportToJpeg("F://ProjektwpfV2//Zdjęcia//plik.jpg", inkCanvas1);
            MessageBox.Show("Obrazek został zapisany pomyślnie.");
        }
    }
}