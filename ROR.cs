using System;

namespace ROR
{
    class ROR
    {
        static active_wars aw = new active_wars(0);
        static void Main(string[] args)
        {
            roll_three_dice();
            state_money();
        }


        static void roll_three_dice()
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int dice3 = rnd.Next(1, 7);
            int dice = dice1+dice2+dice3;
            Console.WriteLine(dice);
        }

        static int state_money()
        {
            int paw = aw.pay_active_wars();
            int base_state_money = 100;
            int final_money = base_state_money+paw;
            Console.WriteLine("state money is: "+final_money);
            return final_money;


        }
    }
}
