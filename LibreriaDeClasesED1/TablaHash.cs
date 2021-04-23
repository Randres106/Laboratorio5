using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaDeClasesED1
{
    public class TablaHash
    {
        public ListaEnlazada[] ArrayHash;
        public int lenght { get; set; }

        public NodoHash Encontrar;

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
        public void AgregarPersona(int posicion, NodoHash valor)
        {
            ArrayHash[posicion].InsertarNodo(valor);
        }
        public int FuncionHash(string TituloTarea)
        {
            int indice = (TituloTarea.Length * 10) % 50;
            return indice;
        }
        public NodoHash Buscar(string Titulo)
        {
            int posicion = FuncionHash(Titulo);
            return null;
        }
    }
}
