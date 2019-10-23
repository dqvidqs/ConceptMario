using ConceptMario.Assets.ShapeFactory.Shapes;

namespace ConceptMario.Assets.ShapeFactory
{
    class ShapeFactory
    {
        public ShapeFactory() { }
        public IShapeObjects GetShape(string Object)
        {
            switch (Object.ToLower())
            {
                case "wall":
                    return new WallShape();
                case "diamond":
                    return new DiamondShape();
                case "door":
                    return new DoorShape();
                case "player":
                    return new PlayerShape();
                default:
                    return null;
            }
        }
    }
}
