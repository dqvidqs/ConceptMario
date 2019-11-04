using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    class Gray : IColor
    {
        public SolidColorBrush Get()
        {
            return Brushes.Gray;
        }
    }
}
