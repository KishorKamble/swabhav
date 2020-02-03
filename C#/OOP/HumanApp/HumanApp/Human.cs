using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    class Human
    {
        private string _name;       
        private float _height;
        private float _weight;
        private float _age;
        private GenderType  _gender;
        public Human(string name, GenderType gender, float height, float weight, float age)
        {
            _name = name;
            _gender = gender;
            _height = height;
            _weight = weight;
            _age = age;
            Console.WriteLine("Object Created....//////////////////////////");
        }

        public Human(string name, GenderType gender) : this(name, gender, 5, 50, 18)
        {
           
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public GenderType Gender
        {
            get
            {
                return _gender;
            }
         
        }


        public float Height
        {
            get
            {
                return _height;
            }
        }

        public float Weight
        {
            get
            {
                return _weight;
            }
        }

        public float Age 
        { 
            get
            {
                return _age;
            }
        }


        public void Workout() 
        {
            _weight = _weight * 50 / 100;
        }

     
    }
}
