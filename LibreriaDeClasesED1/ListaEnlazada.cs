using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaDeClasesED1
{
    public class ListaEnlazada
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

        public NodoHash RecorrerLista(string val)
        {
            int cont = 0;
            if (Lista[0].Titulo==val)
            {
                return Lista[0];
            }
            else
            {
                return null;
            }
           
        }
    }
}
