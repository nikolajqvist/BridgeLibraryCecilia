using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Licenseplate { get; set; }

        /// <summary>
        /// Dato for hvonar man kører over broen 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Metode til prisen for det køretøj som kører over broen - metoden er virtuel, hvis subklassen ikke overrider denne metode, vil prisen være 230 
        /// </summary>
        /// <returns></returns>
        public virtual double Price()
        {
            return 230;
        }

        /// <summary>
        /// Metode til at Bestemme hvilket køretøj man kører i. - metoden er abstact hvilket vil sige alle subklasser skal implementere denne metode
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
        
    }
}
