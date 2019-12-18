﻿using ConceptMario.Assets.ShapeFactory.Shapes;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory
{
    static class Factory
    {
        //public Factory() { }
        static public ObjectShape GetShape(string Object)
        {
            switch (Object.ToLower())
            {
                case "wall":
                    return new BlockShape(new Red());
                case "diamond":
                    return new DiamondShape(new Blue());
                case "door":
                    return new DoorShape(new Gray());
                case "player":
                    return new PlayerShape(new Green());
                case "bullet":
                    return new BulletShape(new Black());
                case "box":
                    return new BlockShape(new Brown());
                case "enemy-yellow":
                    return new EnemyShape(new Yellow());
                case "enemy-red":
                    return new EnemyShape(new Red());
                case "player-dead":
                    return new PlayerShape(new Gray());
                default:
                    return null;
            }
        }
    }
}
