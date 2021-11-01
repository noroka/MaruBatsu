using System;

namespace MaruBatsu
{
    interface IStrategy
    {
        int nextHand(int[] arr);
    }
}