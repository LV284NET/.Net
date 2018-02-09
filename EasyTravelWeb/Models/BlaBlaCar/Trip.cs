using System;

namespace EasyTravelWeb.Models.BlaBlaCar
{
    public class Trip: IComparable
    {
        public Price price { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            if (obj is Trip otherTrip)
            {
                return this.price.CompareTo(otherTrip.price);
            }

            throw new ArgumentException("Object is not a Trip");
        }
    }
}