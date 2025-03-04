using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BridgeLibrary
{
    /// <summary>
    /// Vi laver denne superklasse abstract så den ikke kan instansieres. - det vil sige det kun er subklasserne som kan instalisieres 
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Licensplate på køretøjet 
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// Dato for hvonar man kører over broen 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Om køretøjet har brobizz eller ikke    
        /// </summary>
        public bool Brobizz { get; set; }


        /// <summary>
        /// Lisense plate kan ikke være længere end 7 tegn.
        /// </summary>
        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Licenseplate må ikke være længere en 7");
                }
                _licenseplate = value;
            }
               
        }

        /// <summary>
        /// BasePrise er prisen for en billet for det bestemte køretøj uden nogle rabatter.
        /// </summary>
        /// <returns></returns>
        public abstract double BasePrice();
        
            
        /// <summary>
        /// Metode til prisen for det køretøj som kører over broen - metoden er virtuel, hvis et køretøj har brobizz vil 10% blive trukket af prisen
        /// </summary>
        /// <returns>Returnere priste uden eller med rabatten for brobizz</returns>
        public virtual double Price()
        {

            double price = BasePrice();
            if (Brobizz)
            {
                price *= 0.9; // hvis køretøjet har brobizz får de 10% rabat
            }
            return price;
        }

        /// <summary>
        /// Metode til at Bestemme hvilket køretøj man kører i. - metoden er abstact hvilket vil sige alle subklasser skal implementere denne metode
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
        
    }
}
