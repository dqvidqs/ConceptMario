using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    public class Brown : IColor
    {
        public SolidColorBrush Get()
        {
            return Brushes.Brown;
        }
    }
}
