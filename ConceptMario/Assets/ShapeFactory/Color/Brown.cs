using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    public class Brown : IColor
    {
        private SolidColorBrush brown = Brushes.Brown;
        public SolidColorBrush Get()
        {
            return brown;
        }
    }
}
