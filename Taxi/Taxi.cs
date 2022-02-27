using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Aplikacja
    {
        public int DistrictId { get; set; }
        public int Distance { get; set; }
        public List<Districts> AllDistrict { get; set; } = new List<Districts>();
        public List<TaxiDef> AllTaxi { get; set; } = new List<TaxiDef>();
        
        public Aplikacja()
        {
            StworzListeTaxi();
            StworzListeDzielnic();
        }

        public void StworzListeTaxi()
        {
            AllTaxi.Add(new TaxiDef() { CarId = 1, CarName = "Ford Mondeo", Status = "Wolny", DistrictName = "Retkinia" });
            AllTaxi.Add(new TaxiDef() { CarId = 1, CarName = "Dacia Logan", Status = "Wolny", DistrictName = "Łódź Kaliska" });
        }

        public void StworzListeDzielnic()
        {

        }
        public void WyswietlListeTaxi()
        { 
            foreach (TaxiDef aTaxi in AllTaxi)
            {
                Console.Write(aTaxi.CarId + " " + aTaxi.CarName + " " + aTaxi.Status + " " + aTaxi.DistrictName);
            }
        }
    }
}