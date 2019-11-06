using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    class Yellow : IColor
    {
        private SolidColorBrush yellow = Brushes.Yellow;
        public SolidColorBrush Get()
        {
            return yellow;
        }
    }
}
