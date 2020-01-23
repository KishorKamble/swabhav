using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private int _area;
        private BorderOptions _border;


        public int Width 
        {

            get
            {
                return _width;
            }
            set
            {
                _width = value;
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
                _height = value;
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

        public BorderOptions Border
        {
            get 
            {
                return _border;
            }
            set 
            {
                _border = value;
            }
        }
    }
}
