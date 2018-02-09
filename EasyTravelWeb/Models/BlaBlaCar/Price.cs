using System;

namespace EasyTravelWeb.Models.BlaBlaCar
{
    public class Price: IComparable
    {
        public int value { get; set; }
        public string currency { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj is Price otherPrice)
            {    
                return this.value.CompareTo(otherPrice.value);
            }

            throw new ArgumentException("Object is not a Price");
        }
    }
}