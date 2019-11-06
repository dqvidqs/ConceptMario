using System.Windows.Media;

namespace ConceptMario.Assets.ShapeFactory.Color
{
    class Gray : IColor
    {
        private SolidColorBrush gray = Brushes.Gray;
        public SolidColorBrush Get()
        {
            return gray;
        }
    }
}
