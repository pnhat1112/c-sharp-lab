using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibary.BussinessObject;
using AutomobileLibary.Repository;

namespace UI
{
    public partial class CarManagement : Form
    {
        public CarManagement()
        {
            InitializeComponent();
        }
        ICarRepository carRepository = new CarRepository();
        BindingSource source;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void CarManagement_Load(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            dtGVListCar.CellDoubleClick += dtGVListCar_CellDoubleClick;
        }

        private void dtGVListCar_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void ClearText()
        {
            txtCarID.Text = String.Empty;
            txtCarName.Text = String.Empty;
            txtManufacturer.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtReleasedYear.Text = String.Empty;
        }
        private Car GetCarObject()
        {
            Car car = null;
            try {
                car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = txtManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleasedYear = int.Parse(txtReleasedYear.Text)
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Car");
            }
            return car;
        }
        public void LoadCarList()
        {
            var cars =  carRepository.GetCars();
            try
            {
                source = new BindingSource();
                source.DataSource = cars;

                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtManufacturer.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleasedYear.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text", source, "CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtManufacturer.DataBindings.Add("Text", source, "Manufacturer");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleasedYear.DataBindings.Add("Text", source, "ReleasedYear");

                dtGVListCar.DataSource = null;
                dtGVListCar.DataSource = source;
                if(cars.Count() == 0)
                {
                    ClearText();
                    btnDel.Enabled = false;
                } else
                {
                    btnDel.Enabled = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Car List");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CarDeltails carDeltails = new CarDeltails
            {
                Text = "Add Car",
                InsertOrUpdate = false,
                CarRepository = carRepository
            };
            if(carDeltails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Car");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtGVListCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarDeltails carDeltails = new CarDeltails
            {
                Text = "Update Car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                CarRepository = carRepository
            };
            if (carDeltails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }
        }
    }
}
