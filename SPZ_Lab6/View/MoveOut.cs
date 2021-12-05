using System;
using System.Windows.Forms;
using SPZ_Lab6.Model;

namespace SPZ_Lab6.View
{
    public partial class MoveOut : Form
    {
        public MoveOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDown1.Value;
            if (Hotel.HotelDictionary[number] != null)
            {
                Hotel.HotelRooms[number - 1].Eviction();
                Hotel.HotelDictionary[number] = null;
                Form1.Occupied--;
                this.Close();
            }
            else MessageBox.Show($"Номер {number} не занят.");
        }
    }
}
