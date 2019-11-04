using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    public class Green : IColor
    {
        public SolidColorBrush Get()
        {
            return Brushes.Green;
        }
    }
}
