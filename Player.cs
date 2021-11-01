using System;

namespace MaruBatsu{
    class Player
    {
        public string name { get; set; }
        public IStrategy strategy { get; set; }
        public int nextHand(int[] arr)
        {
            return strategy.nextHand(arr);
        }
    }
}