using Chapter_1.Enums;

namespace Chapter_1
{
    public class Guitar(string SerialNumber, double Price, GuitarSpec Spec)
    {
        #region Properties
        private string? SerialNumber { get; set; } = SerialNumber;
        private double Price { get; set; } = Price;
        private GuitarSpec Spec { get; set; } = Spec;
        #endregion

        #region Methods
        public string GetSerialNumber()
        {
            return SerialNumber;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price) => this.Price = price;

        public GuitarSpec GetSpec()
        {
            return Spec;
        }
        #endregion
    }
}
