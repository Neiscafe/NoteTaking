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

namespace NoteTaking.Views
{
    /// <summary>
    /// Interação lógica para BoardUserControl.xam
    /// </summary>
    public partial class BoardUserControl : UserControl
    {
        public BoardUserControl()
        {
            InitializeComponent();
            Rectangle rect = new()
            {
                Fill = Brushes.Coral,
                Width = 140,
                Height = 60,
                RadiusX = 10,
                RadiusY = 10
            };
            Canvas.SetTop(rect, 20);
            Canvas.SetLeft(rect, 20);
            rect.PreviewMouseDown += Rect_PreviewMouseDown;
            CanvasMain.Children.Add(rect);
        }

        UIElement dragObject = null;
        Point offset;

        private void Rect_PreviewMouseDown(object sender, MouseEventArgs e)
        {
            this.dragObject = sender as UIElement;
            this.offset = e.GetPosition(this.CanvasMain);
            this.offset.Y -= Canvas.GetTop(this.dragObject);
            this.offset.X -= Canvas.GetLeft(this.dragObject);
            this.CanvasMain.CaptureMouse();
        }

        private void CanvasMain_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if(this.dragObject == null)
            {
                return;
            }
            var position = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(this.dragObject, position.Y - this.offset.Y);
            Canvas.SetLeft(this.dragObject, position.X - this.offset.X);
        }

        private void CanvasMain_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            this.dragObject = null;
            this.CanvasMain.ReleaseMouseCapture();
        }
    }
}
