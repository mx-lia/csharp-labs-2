using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace LR_2
{
    [Serializable]
    [DataContract]
    public class Airplane
    {
        [DataMember, Required(ErrorMessage = "Требуется ID самолёта")]
        public string ID { get; set; }
        [DataMember, Required(ErrorMessage = "Требуется модель")]
        public string Model { get; set; }
        [DataMember]
        public int Seats { get; set; }
        [DataMember, Range(50000, 1000000, ErrorMessage = "Допустимое значение грузоподъёмности от 50000 до 1000000 кг")]
        public int Load { get; set; }
        [DataMember, Required(ErrorMessage = "Требуется тип самолёта")]
        public string Type { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        public List<Crewman> Crew { get; set; }
        [DataMember, Required(ErrorMessage = "Требуется экипаж")]
        public string CrewText { get; set; }

        public Airplane() { }

        public Airplane(string id, string model,int seats, int load, string type, int year, DateTime date, List<Crewman> cr)
        {
            ID = id;
            Model = model;
            Seats = seats;
            Load = load;
            Type = type;
            Year = year;
            Date = date;
            Crew = new List<Crewman>(cr);
            foreach(Crewman crewman in Crew)
            {
                CrewText += crewman.ToString() + "\n";
            }
        }
    }
}
