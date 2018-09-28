using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    abstract class DrawingShape
    {
        private readonly object shape;
        protected int size;
        protected int locX = 0, locY = 0;

        public virtual void Draw(Canvas canvas)

        {
            if (this.shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }

            this.shape.Height = this.size;
            this.shape.Width = this.size;
            Canvas.SetTop(this.shape, this.locY);
            Canvas.SetLeft(this.shape, this.locX);
            canvas.Children.Add(this.shape);


        }
    }
}
