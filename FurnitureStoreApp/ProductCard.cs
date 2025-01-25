using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Geolocation;

namespace FurnitureStoreApp
{
    public partial class ProductCard : UserControl
    {
        public event EventHandler<int> AddToCartClicked;
        private int productId;

        public ProductCard(int id)
        {
            productId = id;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
        public void SetProductDetails(string name, decimal price, string imagePath)
        {

            Name_lbl.Text = name;
            Price_lbl.Text = $"EGP {price}";

            // Load the image from the file path

            // PImage.Image = Image.FromFile("C:\\Users\\shahd\\source\\repos\\FurnitureStoreApp\\Images\\Chair.jpg");
            PImage.Image = Image.FromFile(imagePath);

        }

        private void PImage_Click(object sender, EventArgs e)
        {

        }

        private void addCart_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, productId);
        }
       
    }
}
