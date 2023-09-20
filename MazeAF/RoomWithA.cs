using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class RoomWithA : Room
    {
        static Random rnd = new Random();

        internal readonly bool IsHungry;

        public RoomWithA(int roomNumber) : base(roomNumber)
        {
            IsHungry = rnd.Next(2) == 0 ? true : false;
        }

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("В комнате тигр");
            if (IsHungry)
            {
                Console.WriteLine("Он голоден и пытается вас съест");
            }
            else
            {
                Console.WriteLine("Он оказался сытым, вы в безопасности");
            }
        }
    }
}