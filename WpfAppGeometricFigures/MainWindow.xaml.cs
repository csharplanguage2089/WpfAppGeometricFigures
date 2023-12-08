using System.Windows;

namespace WpfAppGeometricFigures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Figures figures;

        public MainWindow()
        {
            InitializeComponent();
            figures = new Figures(this);
        }

        /// <summary>
        /// При нажатии на кнопку, окно Windows будет отображать случайно выбранную фигуру, такую как: Ellipse, Rectangle (1), Rectangle (2) или Polygon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomFigure_Click(object sender, RoutedEventArgs e)
        {
            figures.ShowFigure();
        }

        /// <summary>
        /// При нажатии на кнопку, окно Windows будет отображать Polygon со случайными координатами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomPolygon_Click(object sender, RoutedEventArgs e)
        {
            figures.ShowPolygon();
        }

        /// <summary>
        /// Очистить фигуры в окне Windows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearWindow_Click(object sender, RoutedEventArgs e)
        {
            figures.ClearFigures();
        }

        /// <summary>
        /// Закрыть окно Windows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
