using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProjectApp
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private int _area;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                
                _width = Validate(value);
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = Validate(value);
            }
        }

        public int Area
        {
            get
            {

                return _area = _width * _height;
            }
            set
            {
                _area = value;
            }
        }

        public int Validate(int valGet) 
        {
            if (valGet <= -1)
            {
                return 1;
            }
            if(valGet > 100)
            {
                return 100;
            }
            
                return valGet;
            
        }
    }
}
