using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = GameManager.getInstance();
            gm.NewGame();
            
            Console.ReadLine();
        }
    }

    class GameManager
    {
        private static GameManager instance;

        private GameManager()
        { }

        public static GameManager getInstance()
        {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }


        //public GameManager Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new GameManager();
        //        return instance;
        //    }
        //}

        public void NewGame()
        {
            Console.WriteLine("Новая игра");
        }

    }

}
