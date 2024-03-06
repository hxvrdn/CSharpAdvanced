namespace C_Advanced
{
    public class Rentalvehicle
    {
        public int RentalId { get; set; }
        public string Currentrenter { get; set; }
        public decimal priceperday { get; set; }
        public int numberofpassengers { get; set; }
        public CarType Style { get; set; }

        public void StratEngine()
        {
            Console.WriteLine(  "Turn key to ingnition setting");
            Console.WriteLine(  "Turn key to on");
        }

        public void StopEngine()
        {
            Console.WriteLine( "Turn Key to off");
        }
    }
}
