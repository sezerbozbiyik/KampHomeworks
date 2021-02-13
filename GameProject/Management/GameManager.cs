using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi.");
        }

        public void Insert(Game game)
        {
            Console.WriteLine("Oyun Eklendi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi.");
        }
    }
}
