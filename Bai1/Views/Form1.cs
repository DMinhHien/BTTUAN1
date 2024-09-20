using System;
using System.Data;
using System.Windows.Forms;
using Bai1.Models;
using Bai1.Presentations;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            var GIASUCData = SQL.LoadGIASUCData();

            foreach (DataRow row in GIASUCData.Rows)
            {
                var Loai = row["loai"].ToString();
                var SoCon = Convert.ToInt32(row["socon"]);
                var Sua = Convert.ToInt32(row["sua"]);

                switch (Loai)
                {
                    case "Bo":
                        soBo.Text = SoCon.ToString();
                        suaBo.Text = Sua.ToString();
                        break;
                    case "Cuu":
                        soCuu.Text = SoCon.ToString();
                        suaCuu.Text = Sua.ToString();
                        break;
                    case "De":
                        soDe.Text = SoCon.ToString();
                        suaDe.Text = Sua.ToString();
                        break;
                }
            }
        }



        private void btn_sound_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BoInput.Text) || string.IsNullOrEmpty(CuuInput.Text) ||
                string.IsNullOrEmpty(DeInput.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ số liệu");
            }
            else
            {
                var bo = new Bo(int.Parse(BoInput.Text));
                var cuu = new Cuu(int.Parse(CuuInput.Text));
                var goat = new De(int.Parse(DeInput.Text));
                bo.SanSinh();
                cuu.SanSinh();
                goat.SanSinh();
                bo.ProduceSua();
                cuu.ProduceSua();
                goat.ProduceSua();
                SQL.InsertGIASUCData("Bo", bo.SoCon, bo.Sua);
                SQL.InsertGIASUCData("Cuu", cuu.SoCon, cuu.Sua);
                SQL.InsertGIASUCData("De", goat.SoCon, goat.Sua);
                var sounds = "";
                var soBo = bo.SoCon;
                for (int i = 0; i < soBo; i++)
                {
                    sounds += $"{bo.Tieng()}\n";
                }

                var cuuQty = cuu.SoCon;
                for (int i = 0; i < cuuQty; i++)
                {
                    sounds += $"{cuu.Tieng()}\n";
                }

                var goatQty = goat.SoCon;
                for (int i = 0; i < goatQty; i++)
                {
                    sounds += $"{goat.Tieng()}\n";
                }
                Tieng.Text = sounds;
            }
        }
    }
}