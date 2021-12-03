using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_Lab6.Model;

namespace SPZ_Lab6.View
{
    public partial class MoveIn : Form
    {
        KeyValuePair<int, Occupant> firstFree;
        public MoveIn()
        {
            InitializeComponent();
            firstFree = Hotel.HotelDictionary.First(item => item.Value == null);
            places_numeric.Value = Hotel.HotelRooms[firstFree.Key - 1].NumberBerths;
            ChangeValue();
        }

        private void places_numeric_ValueChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }
        void ChangeValue()
        {
            int countPlaces = (int)places_numeric.Value;
            HotelRoom.Check(countPlaces, out int min, out int max);
            for (int i = min; i <= max; i++)
            {
                if (!Hotel.HotelRooms[i - 1].Status)
                {
                    number_label.Text = i.ToString();
                    price_label.Text = Hotel.HotelRooms[i - 1].Price.ToString();
                    Sum();
                    break;
                }
            }
        }
        void Sum()
        {
            sum_label.Text = (decimal.Parse(price_label.Text) * days_numeric.Value).ToString();
        }

        private void days_numeric_ValueChanged(object sender, EventArgs e)
        {
            Sum();
        }

        private void MoveIn_Load(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lastname_textBox.Text != "" && firstname_textBox.Text != "" && Form1.Occupied < Hotel.CountRooms)
            {
                int number = int.Parse(number_label.Text);
                Hotel.HotelDictionary[number] = new Occupant(lastname_textBox.Text, firstname_textBox.Text, (int)days_numeric.Value);
                Hotel.HotelRooms[number - 1].Settling();
                Hotel.Income += int.Parse(price_label.Text);
                Form1.Occupied++;
                this.Close();
            }
        }
    }
}
