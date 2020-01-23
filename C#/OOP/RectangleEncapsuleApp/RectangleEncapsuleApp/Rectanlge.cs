using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsuleApp
{
    class Rectanlge
    {
        private int _width;
        private int _height;
        public int CalculteArea()
        {
            return _width * _height;
        }
        public void SetWidth(int pwidth)
        {
        
            _width = Validate(pwidth);
        }
        public void SetHeight(int pheight)
        {
    
            _height = Validate(pheight);
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }

        public int Validate(int valGiven)                          
        {
            // if (valGiven <= -1)
            // {
            //     return 1;
            //  }
            //  else if (valGiven > 100)
            //   {
            //      return 100;
            //  }
            //   else
            //   {
            //       return valGiven;
            //   }

            return  (valGiven<=-1) ? 1 : (valGiven >100) ? 100: valGiven;

        }

    }

}
