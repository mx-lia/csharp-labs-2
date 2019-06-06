using LR_13.BuilderPattern;
using LR_13.Factory;
using LR_13.Figure;
using LR_13.Singleton;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LR_13
{
    public partial class MainWindow : Window
    {
        private IAbstractFactory factoryRed;
        private IAbstractFactory factoryGreen;
        private double y = 10;

        public MainWindow()
        {
            InitializeComponent();

            factoryRed = new FactoryRed();
            factoryGreen = new FactoryGreen();
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            switch(((ComboBoxItem)itemType.SelectedValue).Content)
            {
                case "Red": DrawFigure(factoryRed);
                    break;
                case "Green": DrawFigure(factoryGreen);
                    break;
            }
        }

        private void DrawFigure(IAbstractFactory factory)
        {
            Figure.ICircle circle = factory.CreateCircle();
            Figure.ISquare square = factory.CreateSquare();
            SolidColorBrush brush = new SolidColorBrush(square.GetSqureColor());
            Rectangle rect = new Rectangle() { Fill = brush, Height = square.GetSideSize(), Width = square.GetSideSize() };
            Ellipse el = new Ellipse() { Fill = brush, Height = circle.GetRadius() * 2, Width = circle.GetRadius() * 2 };
            Canvas.SetLeft(rect, 10);
            Canvas.SetTop(rect, y);
            canvas.Children.Add(rect);
            Canvas.SetLeft(el, 80);
            Canvas.SetTop(el, y);
            canvas.Children.Add(el);
            y += rect.Height + 5;
        }

        private void Singletone(object sender, RoutedEventArgs e)
        {
            try
            {
                GoldenObject obj = GoldenObject.GetInstance();
                SolidColorBrush brush = new SolidColorBrush(obj.GetColor());
                Polygon polygon = new Polygon() { Fill = brush, Points = obj.GetPoints() };
                Canvas.SetLeft(polygon, 10);
                Canvas.SetTop(polygon, y);
                canvas.Children.Add(polygon);
                y += 55;
            }
            catch
            {
                MessageBox.Show("Golden object is already exist.");
            }
        }

        private void Builder(object sender, RoutedEventArgs e)
        {
            Builder builder = new ComplexObjectBuilder();
            builder.CreateComplexObject();
            builder.SetCircle();
            builder.SetSquare();

            ICircle circle = builder.ComplexObject.Circle;
            ISquare square = builder.ComplexObject.Square;

            Rectangle rect = new Rectangle() { Fill = new SolidColorBrush(square.GetSqureColor()), Height = square.GetSideSize(), Width = square.GetSideSize() };
            Ellipse el = new Ellipse() { Fill = new SolidColorBrush(circle.GetCirleColor()), Height = circle.GetRadius() * 2, Width = circle.GetRadius() * 2 };

            Grid grid = new Grid();
            grid.Children.Add(rect);
            grid.Children.Add(el);

            Canvas.SetLeft(grid, 10);
            Canvas.SetTop(grid, y);
            canvas.Children.Add(grid);
            y += rect.Height + 5;
        }
    }
}
