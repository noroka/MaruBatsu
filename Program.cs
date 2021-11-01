using System;

namespace MaruBatsu
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean cont = false;
            Boolean turn = true;
            Board board = new Board();
            board.squares = new int[]
            {
                0,0,0,0,0,0,0,0,0
            };
            Player cpu = new Player();
            cpu.name = "Random";
            cpu.strategy = new RandomStrategy();

            Console.WriteLine("〇×ゲーム開始");
            while (!cont)
            {
                if (turn)
                {
                    Console.WriteLine("あなたのターンです。1-9の数字を入力してください");
                    board.view();
                    var number = Console.ReadLine();
                    board.update(int.Parse(number), "o");
                    turn = false;
                }
                else
                {
                    Console.WriteLine("CPUのターンです。");
                    var number = cpu.nextHand(board.squares);
                    board.update(number, "x");
                    turn = true;
                }
                board.view();
                cont = board.judge();
            }
            Console.WriteLine("終了！続けますか？ 0: いいえ 1: はい");
            var a = Console.ReadLine();

        }
    }
}
