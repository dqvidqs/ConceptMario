using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    public class Black : IColor
    {
        private SolidColorBrush black = Brushes.Black;
        public SolidColorBrush Get()
        {
            return black;
        }
    }
}
