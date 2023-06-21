using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibary.BussinessObject;
using AutomobileLibary.Repository;


namespace UI
{
    public partial class CarDeltails : Form
    {
        public CarDeltails()
        {
            InitializeComponent();
        }
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Car CarInfo { get; set; }

        private void CarDeltails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleasedYear.Text = CarInfo.ReleasedYear.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleasedYear = int.Parse(txtReleasedYear.Text)
                };
                if(InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);

                } else
                {
                    CarRepository.UpdateCar(car);   
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car?" : "Update a car?");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
