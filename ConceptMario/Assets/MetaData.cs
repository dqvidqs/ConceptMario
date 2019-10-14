using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    static class MetaData
    {
        //GLOBAL VALUES
        private static int _widthpx = 900;//pixel
        private static int _heightpx = 600;//pixel
        private static int _size = 25;//pixel
        private static double _fps = 0.0166;//60Hz
        //take GLOBAL values
        public static int Width { get { return _widthpx / _size; } }//plotis langeliu skaičius
        public static int Height { get { return _heightpx / _size; } }//aukštis langelių skaičius
        public static int WidthPx { get { return _widthpx; } }
        public static int HeightPx { get { return _heightpx; } }
        public static int Size { get { return _size; } }
        public static double FPS { get { return _fps; } }
		
	}
}
