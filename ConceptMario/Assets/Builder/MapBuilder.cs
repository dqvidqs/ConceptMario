using System.Collections.Generic;
using ConceptMario.Assets.MapBuilder.Objects;
using ConceptMario.Assets.ShapeFactory;

namespace ConceptMario.Assets.MapBuilder
{
    //Builder
    public class MapBuilder : IMapBuilder
    {
        //private Factory ShapeFactory = new Factory();
        private List<Block> obj = new List<Block>();
        private string Grid;
        private int Step;
        private int Width = MetaData.Width;
        private int Size = MetaData.Size;
        public MapBuilder(string Grid)
        {
            this.Grid = Grid;
        }
        public void BuildWalls()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '1')
                {
                    obj.Add(new Wall(i % Width * Size, Step * Size, Factory.GetShape("wall").Get()));
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
                    obj.Add(new Diamond(i % Width * Size, Step * Size, Factory.GetShape("diamond").Get()));
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
                    obj.Add(new Door(i % Width * Size, Step * Size, Factory.GetShape("door").Get()));
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
                    obj.Add(new Box(i % Width * Size, Step * Size, Factory.GetShape("box").Get()));
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
                    obj.Add(new Enemy(i % Width * Size, Step * Size, Factory.GetShape("enemy").Get()));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public List<Block> GetBlocks()
        {
            return obj;
        }
    }
}