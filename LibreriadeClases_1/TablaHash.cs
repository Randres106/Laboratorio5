using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriadeClases_1
{
    class TablaHash
    {
        public ListaEnlazada[] ArrayHash;
        public int lenght { get; set; }
        public NodoHaash Encontrar;

        public TablaHash(int z)
        {
            ArrayHash = new ListaEnlazada[z];
            int cont = 0;
            while (cont < z)
            {
                ArrayHash[cont] = new ListaEnlazada();
                cont++;
            }
            lenght = z;
        }
        public void AgregarPersona(int posicion, NodoHaash valor)
        {
            ArrayHash[posicion].InsertarNodo(valor);
        }

        public int FuncionHash(string nombre)
        {
            int indice = (nombre.Length* funcionTitulo(nombre))%20;
            return indice;
        }
        public int funcionTitulo(string nombre)
        {
            /////////////////////////////////////
            return 0;
        }
        public NodoHaash Buscar(string nombre, int valor)
        {
            int posicion = FuncionHash(nombre);
            return ArrayHash[posicion].RecorrerLista(valor);
        }
    }
}
