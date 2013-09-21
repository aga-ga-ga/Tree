using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab1_TP_
{
    class Tree
    {
        ArrayList allApples = new ArrayList();
        public int alldropedApples = 0;
        public int allStoneInAllDropedApples = 0;
        public int allFloversInTheTree = 0;
        Random rand = new Random();

        public Tree() { }
        public int Grow()
        {
            if (allFloversInTheTree > 200)
            {
                for (int i = 0; i < 201; i++)
                {
                    allApples.Add(new Apple(rand.Next(1, 7)));
                }
                MessageBox.Show("Tree broken. You plane a new tree", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Apple a in allApples)
                {
                    allStoneInAllDropedApples += a.GetStone();
                    alldropedApples++;
                }
                allApples.Clear();
            }
            else
            {
                for (int i = 0; i < allFloversInTheTree; i++)
                {
                    allApples.Add(new Apple(rand.Next(1, 7)));
                }
            }
            allFloversInTheTree = 0;
            return allApples.Count;
        }
        public int Shake()
        {
            Random rand = new Random();
            int dropApple = 0;
            int kolvoOfApple = rand.Next(0, allApples.Count+1);
            for (int i = 0; i < kolvoOfApple; i++)
            {
                alldropedApples++;
                foreach (Apple a in allApples)
                {
                    allStoneInAllDropedApples += a.GetStone();
                    break;
                }
                allApples.RemoveAt(dropApple);
            }
            return allApples.Count;
        }
        public int Flover()
        {
            allFloversInTheTree += rand.Next(1, 30);
            return allFloversInTheTree;
        }
    }

    class Apple
    {
        public Apple(int Stone) 
        {
            stone = Stone; 
        }
        private int stone; // количество косточек
        public int GetStone()
        {
            return stone;
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
