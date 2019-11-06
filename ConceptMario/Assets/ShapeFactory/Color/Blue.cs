using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    class Blue : IColor
    {
        private SolidColorBrush blue = Brushes.Blue;
        public SolidColorBrush Get()
        {
            return blue ;
        }
    }
}
