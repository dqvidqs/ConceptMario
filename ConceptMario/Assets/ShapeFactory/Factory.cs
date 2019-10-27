using ConceptMario.Assets.ShapeFactory.Shapes;

namespace ConceptMario.Assets.ShapeFactory
{
    class Factory
    {
        public Factory() { }
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
                case "bullet":
                    return new BulletShape();
                case "box":
                    return new BoxShape();
                default:
                    return null;
            }
        }
    }
}
