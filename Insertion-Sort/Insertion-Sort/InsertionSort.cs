using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class InsertionSort<T>
    {
        /// <summary>
        /// Define la manera de ordenar el
        /// arreglo.
        /// </summary>
        private IComparer<T> _comparator;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="comparator">Define la manera de ordenar el arreglo</param>
        public InsertionSort(IComparer<T> comparator)
        {
            this._comparator = comparator;
        }

        /// <summary>
        /// Ordena un arreglo ingresado
        /// </summary>
        /// <param name="originalArray">Arreglo a ordenar</param>
        /// <returns>Arreglo ordenado</returns>
        public T[] Sort(T[] originalArray)
        {
            //Crea una copia del arreglo original para no
            //alterarlo.
            T[] sortedArray = (T[]) originalArray.Clone();

            //Recorre desde el segundo hasta el último elemento del arreglo
            for (int i = 1; i < sortedArray.Length; i++)
            {
                //Elemento actual del arreglo
                T key = sortedArray[i];
                int j = i - 1;

                //Mientras que los elementos anteriores al elemento actual esten
                //desordenados...
                while (j >= 0 && this._comparator.Compare(key, sortedArray[j]) < 0)
                {
                    sortedArray[j + 1] = sortedArray[j];
                    j = j - 1;
                }
                //Acomoda el elemento actual en el lugar que le corresponde.
                sortedArray[j + 1] = key;
            }
            return sortedArray;
        }
    }
}
