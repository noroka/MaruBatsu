using System;
using System.Collections.Generic;

namespace MaruBatsu
{
        class RandomStrategy : IStrategy
    {
        private Random _randv = new System.Random();
        private List<int> _randl = new List<int>();

        public int nextHand(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    _randl.Add(i);
                }
            }
            return _randv.Next(0,_randl.Count);
        }
    } 

}