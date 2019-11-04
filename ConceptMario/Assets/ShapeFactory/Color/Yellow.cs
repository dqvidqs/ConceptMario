using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    class Yellow : IColor
    {
        public SolidColorBrush Get()
        {
            return Brushes.Red;
        }
    }
}
