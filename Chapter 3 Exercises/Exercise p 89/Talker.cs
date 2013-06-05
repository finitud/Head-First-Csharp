using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_p_89
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString += thingToSay + "\n";
            }
            System.Windows.Forms.MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
