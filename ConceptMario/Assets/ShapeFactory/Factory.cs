using ConceptMario.Assets.ShapeFactory.Shapes;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory
{
    static class Factory
    {
        //public Factory() { }
        static public IShapeObjects GetShape(string Object)
        {
            switch (Object.ToLower())
            {
                case "wall":
                    return new BlockShape(new Black(), new Red());
                case "diamond":
                    return new DiamondShape(new Black(), new Blue());
                case "door":
                    return new DoorShape(new Black(), new Gray());
                case "player":
                    return new PlayerShape(new Black(), new Green());
                case "bullet":
                    return new BulletShape(new Black(), new Black());
                case "box":
                    return new BlockShape(new Black(), new Brown());
                case "enemy":
                    return new EnemyShape(new Black(), new Yellow());
                default:
                    return null;
            }
        }
    }
}
