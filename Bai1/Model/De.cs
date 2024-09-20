using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6.Models
{
    internal class De : Giasuc
    {
        public override void Tieng()
        {
            sound = "burhhhh burhhh";
            Console.WriteLine(sound);
        }
    }
}
