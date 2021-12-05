using System;
using System.Threading;
using System.Windows.Forms;
using SPZ_Lab6.Model;
using SPZ_Lab6.View;

namespace SPZ_Lab6
{
    public partial class Form1 : Form
    {
        static int occupied = 0;
        public static int Occupied
        {
            get => occupied;
            set
            { 
                occupied = value;
                if (occupied > Hotel.CountRooms - Hotel.CountRooms * 0.1)
                    checkIn = false;
                else
                { checkIn = true; Hundred = false; }
                if (occupied == Hotel.CountRooms)
                    Hundred = true;    
            }
        } 
        public static int free;
        public static bool Hundred = false;
        static bool checkIn = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            all_label.Text = Hotel.CountRooms.ToString();
            Hotel.Generate();
            Display();
        }

        public void Display()
        {
            new Thread(Serialization.Serialize).Start();
            occupied_label.Text = Hotel.OccupiedRooms().ToString();
            free = Hotel.CountRooms - occupied;
            free_label.Text = free.ToString();
        }
        private void moveIn_button_Click(object sender, EventArgs e)
        {
            if (Hundred && !checkIn)
            MessageBox.Show("Для заселения нужно освободить 10% номеров");
           
            else 
            {
                MoveIn moveIn = new MoveIn();
                moveIn.ShowDialog();

                Display();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if(radio.Checked)
            {
                if (!Hundred && checkIn)
                    StartThread();
            }
        }
        void StartThread()
        {
            Thread t = new Thread(Hotel.FillingWithTourists);
            t.Start();
            while (t.IsAlive)
            {
                    Thread.Sleep(10);
                    Display();
             }  
        }
        private void moveOut_button_Click_1(object sender, EventArgs e)
        {
            MoveOut moveOut = new MoveOut();
            moveOut.ShowDialog();
            Display();
        }
    }
}
