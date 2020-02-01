using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArraysApp
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private int _area;

        public Rectangle(int width,int height)
        {
            _width = Validate(width);
            _height = Validate(height);
            Console.WriteLine("Rectangle Created");
        }

        public int Width
        {
            get
            {
                return _width;
            }
          
        }

        public int Height 
        {
            get
            {
                return _height;
            }
          
        }

        public int Area 
        {
            get
            {
                return _area= _width  * _height ;
            }
          
        }

       public int Validate(int valGet)
        {
            if(valGet < 0)
            {
                return 0;
            }
            return valGet;
        }


    }
}
