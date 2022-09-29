using Algorithms.Helpers;
using Algorithms.Models;
using Algorithms.Sort;
using System;

var seqToSort = new int[]
{
    1, 3, 7, 0, -3, -2, 8
};

SortBase sortAlgo = new Insertion();
sortAlgo.Sort(seqToSort);
seqToSort.Print();
