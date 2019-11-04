using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    class Red : IColor
    {
        public SolidColorBrush Get()
        {
            return Brushes.Red;
        }
    }
}
