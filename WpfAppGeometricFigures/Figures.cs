using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfAppGeometricFigures
{
    internal class Figures
    {
        Random random = new Random();
        Polygon myPolygon = new Polygon();

        // Random number for figures
        public int choiceXNameNumber;

        // Random coordinates for polygon
        public int firstCoordinate;
        public int secondCoordinate;

        private MainWindow mainWindow;

        public Figures(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void ShowFigure()
        {
            mainWindow._1.Visibility = Visibility.Hidden;
            mainWindow._2.Visibility = Visibility.Hidden;
            mainWindow._3.Visibility = Visibility.Hidden;
            mainWindow._4.Visibility = Visibility.Hidden;

            choiceXNameNumber = random.Next(1, 5);

            if (choiceXNameNumber == 1)
                mainWindow._1.Visibility = Visibility.Visible;
            else if (choiceXNameNumber == 2)
                mainWindow._2.Visibility = Visibility.Visible;
            else if (choiceXNameNumber == 3)
                mainWindow._3.Visibility = Visibility.Visible;
            else if (choiceXNameNumber == 4)
                mainWindow._4.Visibility = Visibility.Visible;
        }

        public void ShowPolygon()
        {
            mainWindow._5.Visibility = Visibility.Visible;

            // Когда создается экземпляр newPoints объекта PointCollection, Polygon в XAML сбрасывается до исходных значений
            PointCollection newPoints = new PointCollection();

            myPolygon = mainWindow._5;

            firstCoordinate = random.Next(20, 300);
            secondCoordinate = random.Next(20, 300);
            newPoints.Add(new Point(firstCoordinate, secondCoordinate));

            firstCoordinate = random.Next(20, 300);
            secondCoordinate = random.Next(20, 300);
            newPoints.Add(new Point(firstCoordinate, secondCoordinate));

            firstCoordinate = random.Next(20, 300);
            secondCoordinate = random.Next(20, 300);
            newPoints.Add(new Point(firstCoordinate, secondCoordinate));

            firstCoordinate = random.Next(20, 300);
            secondCoordinate = random.Next(20, 300);
            newPoints.Add(new Point(firstCoordinate, secondCoordinate));

            myPolygon.Points = newPoints;
        }

        public void ClearFigures()
        {
            mainWindow._1.Visibility = Visibility.Hidden;
            mainWindow._2.Visibility = Visibility.Hidden;
            mainWindow._3.Visibility = Visibility.Hidden;
            mainWindow._4.Visibility = Visibility.Hidden;
            mainWindow._5.Visibility = Visibility.Hidden;
        }
    }
}
