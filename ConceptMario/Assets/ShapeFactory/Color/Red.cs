using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    class Red : IColor
    {
        private SolidColorBrush red = Brushes.Red;
        public SolidColorBrush Get()
        {
            return red;
        }
    }
}
