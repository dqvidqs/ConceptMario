using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    public class Green : IColor
    {
        private SolidColorBrush green = Brushes.Green;
        public SolidColorBrush Get()
        {
            return green;
        }
    }
}
