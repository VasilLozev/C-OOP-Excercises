using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Random_List
{
    public class RandomList : List<string>
    {
        public string RandomString() 
        {
            RandomList list = new RandomList();
            Random random = new Random();
            string random1 = random.Next(int.Parse(list[0]), int.Parse(list[list.Count - 1])).ToString();
            list.Remove(random1);
            return random1;
        }
    }
}
