using System;

namespace MaruBatsu
{
    class Board
    {
        private string _str = "1|2|3\n4|5|6\n7|8|9";
        public int[] squares { get; set; }

        public void update(int number, string mark)
        {
            _str = _str.Replace(Convert.ToString(number), mark);
            if (mark == "o")
            {
                squares[number-1] = 1;
            }
            else
            {
                squares[number-1] = 2;
            }
        }
        public void view()
        {
            Console.WriteLine(_str);
        }
        public Boolean judge()
        {
            if (squares[0] == squares[1] && squares[1] == squares[2] && squares[0] != 0 )
            {
                return true;
            }
            else if (squares[3] == squares[4] && squares[4] == squares[5] && squares[3] != 0 )
            {
                return true;
            }
            else if (squares[6] == squares[7] && squares[7] == squares[8] && squares[6] != 0)
            {
                return true;
            }
            else if (squares[0] == squares[3] && squares[3] == squares[6] && squares[0] != 0)
            {
                return true;
            }
            else if (squares[1] == squares[4] && squares[4] == squares[7] && squares[1] != 0)
            {
                return true;
            }            
            else if (squares[2] == squares[5] && squares[5] == squares[8] && squares[2] != 0)
            {
                return true;
            }
            else if (squares[0] == squares[4] && squares[4] == squares[8] && squares[0] != 0)
            {
                return true;
            }
            else if (squares[2] == squares[4] && squares[4] == squares[6] && squares[2] != 0)
            {
                return true;
            }                                    
            else
            {
                return false;
            }
        }
    }
}