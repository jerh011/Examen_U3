using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    public class Nodos
    {
        private Persona _Dato;
        private Nodos _Siguiente;
    
        public Nodos(Persona Valor) {
            _Dato = Valor;
            _Siguiente = null;
        }
        public Nodos()
        { 
        }
            public Nodos(Persona valor,Nodos siguiente) {
                _Dato=valor;
            _Siguiente = siguiente;
        }

        public Persona Dato  {
        get { return _Dato; }
            set { _Dato = value; }
        }

        public Nodos Siguiente { 
            get {  return _Siguiente; }
            set { _Siguiente = value; }
        }
    
    }
}
