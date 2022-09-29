using AlgorithmsLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Sort
{
    internal class Insertion : SortBase
    {
        public override void Sort(int[] seq)
        {
            for (int i = 1; i < seq.Length; i++)
            {
                int key = seq[i];
                int sortedIndex = i - 1;
                while (sortedIndex >= 0 && seq[sortedIndex] > key)
                {
                    seq[i] = seq[sortedIndex];
                    sortedIndex--;
                }
                seq[sortedIndex + 1] = key;
            }
        }
    }
}
