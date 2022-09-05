using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassRoomNet60.ModelKlasse
{
    public class KlasseRum
    {

        // Instansfelter 
        private string _klasseNavn;
        DateTime _semesterStart;
        private List<Studerende> _studerendeList;



        // Konstruktører 
        public KlasseRum()
        {
            _studerendeList = new List<Studerende>();
        }

        // Konstruktører 

        public KlasseRum(string klasseNavn, DateTime semesterStart)
        {
            _klasseNavn = klasseNavn;
            _semesterStart = _semesterStart;
          
        }

        // Properties

        public string KlasseNavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }
        }
        public DateTime Datoer 
        {  
            get { return _semesterStart; } 
           set { _semesterStart = value; } 
        }


        public override string ToString()
        {
            return $"{nameof(_klasseNavn)}: {_klasseNavn}, {nameof(_semesterStart)}: {_semesterStart}";
        }



    }
}
