using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_de_Eratostenes
{
    class Eratostenes
    {
        public static string obtenerPrimo(int tamaño)
        {
            bool [] _v = new bool [tamaño];
            string primo = "";
            //Se llena el vector con verdadero
            for (int i = 0; i < tamaño; i++)
                _v[i] = true;
            //Tachar los multiplos
            for (int i = 2; i < tamaño; i++)
            {
                //Solo si esta verdadero 
                if (_v[i])
                {
                    for (int j = 2; i * j < tamaño; j++)
                        _v[i * j] = false;
                }
            }
            for(int i=2; i<tamaño; i++)
            {
                if (_v[i])
                    primo += i.ToString() + Environment.NewLine;
            }
            return primo;
        }
    }
}
