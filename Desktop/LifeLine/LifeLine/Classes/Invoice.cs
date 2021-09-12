using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine.Classes
{
    public static class Invoice
    {
        public static string generate(string letter,string rollId)
        {
            if (rollId == null)
                rollId = letter + "0001";
            else
            {
                try
                {
                    int change = int.Parse(rollId.Substring(1, 4));
                    rollId = string.Format(letter+"000{0}", ++change);
                }
                catch (Exception) { rollId = letter + "0001"; }
            }

            return rollId;
        }
    }
}
