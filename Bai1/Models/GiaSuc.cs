using System;

namespace Bai1.Models
{
    public abstract class GiaSuc
    {
        protected int MaxSua;
        protected string Sound;
        public int Sua;
        public int SoCon;
        private static readonly Random Random = new Random();
        protected GiaSuc(int n)
        {
            SoCon = n;
        }

        public string Tieng()
        {
            return Sound;
        }

        public void SanSinh()
        {
            var random = new Random();
            var con = random.Next(1, SoCon);
            SoCon += con;
        }

        public void ProduceSua()
        {
            var qty = SoCon;
            for (int i = 0; i < SoCon; i++)
            {
                {
                    var random = new Random();
                    Sua += random.Next(0, MaxSua);
                }
            }
        }
    }
}