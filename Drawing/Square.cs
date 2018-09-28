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
    class Square: DrawingShape, IDraw, IColor
    {
        public Square(int sideLength)
            : base(sideLength)
        {

        }
        private int sideLength;
        private int locX = 0, locY = 0;
        private Rectangle rect = null;
        private Rectangle shape;

        public Square(int sideLength) => this.sideLength = sideLength;

        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Rectangle();
            }
            base.Draw(canvas);

            this.rect.Height = this.sideLength;
            this.rect.Width = this.sideLength;
            Canvas.SetTop(this.rect, this.locY);
            Canvas.SetLeft(this.rect, this.locX);
            canvas.Children.Add(this.rect);

        }  

        

      
    }

   
}
