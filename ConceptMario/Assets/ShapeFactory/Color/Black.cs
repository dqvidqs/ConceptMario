using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    public class Black : IColor
    {
        public SolidColorBrush Get()
        {
            return Brushes.Black;
        }
    }
}
