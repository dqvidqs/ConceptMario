using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    public class Blue : IColor
    {
        public SolidColorBrush Get()
        {
            return Brushes.Blue ;
        }
    }
}
