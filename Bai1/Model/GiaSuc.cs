using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6.Models
{
    internal class Giasuc
    {
        protected int sua;
        protected string sound;
        protected int socon;

        public virtual void Tieng() { }

        public int Decon()
        {
            Random rand = new Random();
            socon = rand.Next(1, 2); // Generates a random number between 1 and 1 (inclusive)
            return socon;
        }
    }
}
