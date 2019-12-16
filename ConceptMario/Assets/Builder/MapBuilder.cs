using System.Collections.Generic;
using ConceptMario.Assets.Builder.Objects;
using ConceptMario.Assets.ShapeFactory;
using ConceptMario.Assets.TemplateMethod;
using ConceptMario.Assets.FlyWeight;

namespace ConceptMario.Assets.Builder
{
    //Builder
    public class MapBuilder : IMapBuilder
    {
        private MapObjects Objects;
        private string Grid;
        private int Step;
        private int Width = MetaData.Width;
        private int Size = MetaData.Size;
        public MapBuilder(string Grid)
        {
            this.Grid = Grid;
            Objects = new MapObjects();
        }
        public void BuildWalls()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '1')
                {
                    Objects.AddBlock(new Wall(i % Width * Size, Step * Size, Factory.GetShape("wall").Get()));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }

        public void BuildDiamonds()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '2')
                {
                    Objects.AddBlock(new Diamond(i % Width * Size, Step * Size, Factory.GetShape("diamond").Get()));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public void BuildDoors()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '3')
                {
                    Objects.AddBlock(new Door(i % Width * Size, Step * Size, Factory.GetShape("door").Get()));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public void BuildBoxes()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '4')
                {
                    Objects.AddBlock(new Box(i % Width * Size, Step * Size, Factory.GetShape("box").Get()));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public void BuildEnemies()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '5')
                {
                    Enemy e = EnemyFlyWeight.GetEnemy("yellow");
                    e.SetCoordantes(i % Width * Size, Step * Size);
                    Objects.AddBlock(e);
                }
                if (Grid[i] == '6')
                {
                    Enemy e = EnemyFlyWeight.GetEnemy("red");
                    e.SetCoordantes(i % Width * Size, Step * Size);
                    Objects.AddBlock(e);
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public MapObjects GetResult()
        {
            return Objects;
        }
    }
}