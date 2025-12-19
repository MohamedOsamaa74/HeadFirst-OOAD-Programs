using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_1
{
    public class Inventory
    {
        private List<Guitar> Guitars = [];

        #region Constructor
        public Inventory()
        {
            Guitars = [];
        }
        #endregion

        #region Methods
        public void AddGuitars(Guitar guitar)
        {
            Guitars.Add(guitar);
        }

        public Guitar GetGuitar(string SerialNumber)
        {
            foreach (var guitar in Guitars)
            {
                if (guitar.GetSerialNumber().Equals(SerialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar>? Search(GuitarSpec searchGuitar)
        {
            List<Guitar> MatchingGuitars = [];
            foreach (var guitar in Guitars)
            {
                //ignoring serial number and price (unique)
                if (guitar.GetSpec().Compare(searchGuitar))
                    MatchingGuitars.Add(guitar);
            }
            return MatchingGuitars;
        }
        #endregion

    }
}
