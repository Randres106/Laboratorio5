using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaDeClasesED1
{
    class ListaEnlazada
    {
        public NodoHash[] Lista { get; set; }
        public ListaEnlazada()
        {
            Lista = null;
        }
        public void InsertarNodo(NodoHash valor)
        {
            if (Lista == null)
            {
                Lista = new NodoHash[1];
                Lista[0] = new NodoHash();
                Lista[0] = valor;
            }
            else
            {
                NodoHash[] temporal = Lista;
                Lista = new NodoHash[temporal.Length + 1];
                int cont = 0;
                while (cont < temporal.Length)
                {
                    Lista[cont] = temporal[cont];
                    cont++;
                }
                Lista[cont] = valor;
            }
        }

        public NodoHash RecorrerLista(int val)
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
