namespace BridgeLibrary
{
    public class Car
    {
        /// <summary>
        /// Licensplate på køretøjet 
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Dato for hvonar man kører over broen 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Metode til prisen for at kører over broen 
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Metode til at Bestemme hvilket køretøj man kører i.
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
