using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Circle_App
{
 
    class Circle
    {
        private float _radius;
        private string _color;
        public float CalculateArea()
        {
            
            return (float)Math.Round(3.14f * _radius * _radius, 2, MidpointRounding.AwayFromZero);
            
        }

        public float Perimeter()            
        {
           
           return (float)Math.Round(2 * 3.14f * _radius, 2,
               MidpointRounding.AwayFromZero);
        }


        public void SetRadius(float rad)
        {
            _radius = rad;
        }

        public void SetColor(string color)
        {
            if ((color.ToUpper() == "RED") || (color.ToUpper() == "GREEN") 
                || (color.ToUpper() == "BLUE"))
            {
                _color = color.ToUpper();
                return;
            }
            _color = color.ToUpper();
        }

     

        public float GetRadius()
        {
            return _radius;
        }
        public String  GetColor()
        {
            return _color;
        }

    }
}
