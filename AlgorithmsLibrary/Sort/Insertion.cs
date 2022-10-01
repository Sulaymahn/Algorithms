using AlgorithmsLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Sort
{
    public class Insertion : SortBase
    {
        public override void Sort(int[] seq)
        {
            for (int i = 1; i < seq.Length; i++)
            {
                int currentValue = seq[i];
                int sortedIndex = i - 1;
                while (sortedIndex >= 0 && seq[sortedIndex] > currentValue)
                {
                    seq[sortedIndex + 1] = seq[sortedIndex];
                    sortedIndex--;
                }
                seq[sortedIndex + 1] = currentValue;
            }
        }
    }
}
