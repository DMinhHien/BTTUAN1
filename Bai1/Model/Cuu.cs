using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6.Models
{
    internal class Cuu : Giasuc
    {
        public override void Tieng()
        {
            sound = "beee beee";
            Console.WriteLine(sound);
        }
    }
}
