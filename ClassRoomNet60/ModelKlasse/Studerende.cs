using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.ModelKlasse
{
    public class Studerende
    {

        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            _navn = navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned = value; }
        }

        public int fødselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag = value; }
        }


        public override string ToString()
        {
            return $"{nameof(_navn)}: {_navn}, {nameof(_fødselsmåned)}: {_fødselsmåned}, {nameof(_fødselsdag)}: {_fødselsdag}";
        }


    }
