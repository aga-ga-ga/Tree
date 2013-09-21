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
        public Tree() { }
        public int Grow()
        {
            Random rand = new Random();
            int kolvoOfApple = rand.Next(1, 30);
            if (allApples.Count + kolvoOfApple > 200)
            {
                MessageBox.Show("Tree broken. You plane a new tree", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                allApples.Clear();
            }
            else
            {
                for (int i = 0; i < kolvoOfApple; i++)
                {
                    allApples.Add(new Apple(rand.Next(1, 7)));
                }
            }
            
            return allApples.Count;
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
