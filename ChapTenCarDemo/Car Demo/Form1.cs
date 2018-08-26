using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Demo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();

            GetCarData(myCar);

            lblMake.Text = myCar.Make;
            lblModel.Text = myCar.Model;
            lblMileage.Text = myCar.Mileage.ToString();
            lblPrice.Text = myCar.Price.ToString("c");
            lblDoors.Text = myCar.Doors.ToString();
        }

        private void GetCarData(Car car)
        {
            int mileage;
            decimal price;
            int doors;

            car.Make = txtMake.Text;

            car.Model = txtModel.Text;

            if (int.TryParse(txtMileage.Text, out mileage))
            {
                car.Mileage = mileage;

                if (decimal.TryParse(txtPrice.Text, out price))
                {
                    car.Price = price;

                    if (int.TryParse(txtDoors.Text, out doors))
                    {
                        car.Doors = doors;
                    }
                    else
                    {
                        MessageBox.Show("Invalid number of doors.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid price.");
                }

            }
            else
            {
                MessageBox.Show("Invalid mileage.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
