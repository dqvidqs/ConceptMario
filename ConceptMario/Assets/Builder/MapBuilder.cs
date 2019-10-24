using System.Collections.Generic;
using ConceptMario.Assets.MapBuilder.Objects;

namespace ConceptMario.Assets.MapBuilder
{
    //Builder
    public class MapBuilder : IMapBuilder
    {
        private ShapeFactory.ShapeFactory ShapeFactory = new ShapeFactory.ShapeFactory();
        private MapObjects obj;
        private string Grid;
        private int Step;
        private int Width = MetaData.Width;
        private int Size = MetaData.Size;
        public MapBuilder(string Grid)
        {
            obj = new MapObjects();
            this.Grid = Grid;
        }
        public void BuildWalls()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '1')
                {
                    obj.AddBock(new Wall(i % Width * Size, Step * Size, ShapeFactory.GetShape("wall").Get()));
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
                    obj.AddBock(new Diamond(i % Width * Size, Step * Size, ShapeFactory.GetShape("diamond").Get()));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public void BuilDoors()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '3')
                {
                    obj.AddBock(new Door(i % Width * Size, Step * Size, ShapeFactory.GetShape("door").Get()));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public List<Block> GetBlocks()
        {
            return obj.GetBlocks();
        }
    }
}