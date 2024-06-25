using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using Microsoft.Win32;

namespace Практическая_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        


        public void ColorChange(Polyline letter, string color)
        {

            if (color == "Красный")
            {
                letter.Stroke = Brushes.Red;
            }
            else if(color == "Зеленый")
            {
                letter.Stroke = Brushes.Green;
            }
            else if (color == "Жёлтый")
            {
                letter.Stroke = Brushes.Yellow;
            }
            else if(color == "Синий")
            {
                letter.Stroke = Brushes.Blue;
            }
            else if(color == "Черный")
            {
                letter.Stroke= Brushes.Black;
            }


        }

        int click = 0;
        private void Button_Paint(object sender, RoutedEventArgs e)
        {
            string color = CBColor.Text;

            if (click == 0)
            {
                click = 1;
                PaintBtn.Content = "Очистить";

                Polyline F = new Polyline();
                Polyline o = new Polyline();
                Polyline n = new Polyline();

                F.StrokeThickness = 20;
                ColorChange(F, $"{color}");
                F.Points.Add(new Point(110, 15));
                F.Points.Add(new Point(20, 15));
                F.Points.Add(new Point(20, 130));
                F.Points.Add(new Point(20, 130));
                F.Points.Add(new Point(20, 65));
                F.Points.Add(new Point(110, 65));
                Canvas1.Children.Add(F);

                o.StrokeThickness = 20;
                ColorChange(o, $"{color}");
                o.Points.Add(new Point(140, 130));
                o.Points.Add(new Point(140, 15));
                o.Points.Add(new Point(230, 15));
                o.Points.Add(new Point(230, 120));
                o.Points.Add(new Point(130, 120));
                Canvas1.Children.Add(o);

                n.StrokeThickness = 20;
                ColorChange(n, $"{color}");
                n.Points.Add(new Point(270, 130));
                n.Points.Add(new Point(270, 10));
                n.Points.Add(new Point(270, 10));
                n.Points.Add(new Point(270, 65));
                n.Points.Add(new Point(360, 65));
                n.Points.Add(new Point(360, 130));
                n.Points.Add(new Point(360, 130));
                n.Points.Add(new Point(360, 10));
                n.Points.Add(new Point(360, 10));


                Canvas1.Children.Add(n);

            }
            else
            {
                click = 0;
                Canvas1.Children.Clear();
                PaintBtn.Content = "Рисовать";
            }
        }

        private void MenuItem_Obout(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант: 9\n\nЗадание:\nВывести на экран слово согласно заданию.\nСлово: ФОН",
                            "О программе",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void MenuItem_Devoloper(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Тогузов Максим\nГруппа: ИСП-22\nВариант: 9", 
                            "Разработчик",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }
    }
}