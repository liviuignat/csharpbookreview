using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Packt.LearningCS
{
    public partial class Person
    {
        public string FavouriteIceCream { get; set; }

        private string favouritePrimaryColour;
        public string FavouritePrimaryColour
        {
            get
            {
                return favouritePrimaryColour;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColour = value;
                        break;
                    default:
                        throw new ArgumentException($"{value} is not a primary colour. Choose from: red, green, blue.");
                }
            }
        }

        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

    }
}