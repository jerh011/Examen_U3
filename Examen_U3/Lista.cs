using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    public class Lista
    {
        private Nodos _Primero;
        private Nodos _Ultima;
        private Persona _Datos;
        public Lista()
        {
            _Primero = null;
            _Ultima = null;
        }
        public bool vacia()
        {
            return _Primero == null ? true : false;
        }

        public void insertar(Persona valor)
        {
            if (vacia())
            {
                _Ultima = _Primero = new Nodos(valor, _Primero);
            }
            else
            {
                Nodos nuevo = new Nodos(valor);
                _Ultima.Siguiente = nuevo;
                nuevo.Siguiente = _Primero;
                _Ultima = nuevo.Siguiente;
                _Primero = nuevo;
            }
        }
        public int longitud()
        {

            int cont = 0;
            if (vacia())
                return cont;
            else
            {
                Nodos actual = _Primero;
                do
                {
                    cont++;
                    actual = actual.Siguiente;
                } while (_Ultima == null);
                return cont;
            }

        }
        public void DesplegarLista()
        {
            Nodos actual = new Nodos();
            actual =_Primero;

            if (actual !=null )
            {

                do
                {
                    
                    Console.WriteLine($"Persona {actual.Dato.Nombre} Edad:{actual.Dato.Edad} ");
                    actual = actual.Siguiente;
                   

                } while (actual != _Primero);

            }
            else 
            {
                Console.WriteLine("No se encontraron valores");
            }

        }


    }
}

