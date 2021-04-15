using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriadeClases_1
{
    class ListaEnlazada
    {
        public NodoHaash[] Lista { get; set; }
        public ListaEnlazada()
        {
            Lista = null;
        }
        public void InsertarNodo(NodoHaash valor) 
        {
            if (Lista == null)
            {
                Lista = new NodoHaash[1];
                Lista[0] = new NodoHaash();
                Lista[0] = valor;
            }
            else
            {
                NodoHaash[] temporal = Lista;
                Lista = new NodoHaash[temporal.Length + 1];
                int cont = 0;
                while (cont < temporal.Length)
                {
                    Lista[cont] = temporal[cont];
                    cont++;
                }
                Lista[cont] = valor;
            }
        }
        public NodoHaash RecorrerLista(int val)
        {
            int cont = 0;
            //while ((cont <= Lista.Length) && (Lista[cont].valor != val))
            //{
            //    cont++;
            //}
            if (cont == Lista.Length)
            {
                return null;
            }
            else
            {
                return Lista[cont];
            }
        }
    }
}
