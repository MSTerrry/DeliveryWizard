using System;
using DeliveryWizard;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW.UI
{
    public partial class WayPointF : Form
    {
        public decimal bottomLine;
        public bool checkActive = true;        
        public WayPoint wp { get; set; }
        public WayPointF(WayPoint wp)
        {
            this.wp = wp;
            InitializeComponent();            
        }
                
        private void Save_Click(object sender, EventArgs e)
        {
            wp.Address = AdressBox.Text;
            if (DroppedBox1.SelectedIndex != -1) wp.ShopType = DroppedBox1.SelectedItem.ToString();
            else wp.ShopType = "Другое";            
            wp.PlaceTitle = TitleBox.Text;
            wp.ProductsList = ProductList.Items.OfType<Product>().ToList();
            wp.TotalCost = CostUD.Value;
        }

        private void WayPointF_Load(object sender, EventArgs e)
        {
            AdressBox.Text = wp.Address;
            DroppedBox1.SelectedItem = wp.ShopType;
            TitleBox.Text = wp.PlaceTitle;
            CostUD.Value = wp.TotalCost;
            if (wp.ProductsList != null)
            {
                foreach (var r in wp.ProductsList)
                {
                    ProductList.Items.Add(r);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var product = new ProductForm(new Product());            
            var res = product.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                ProductList.Items.Add(product.Prod);
            }
            CostUD.Value += (decimal)product.Prod.Amount* (decimal)product.Prod.Cost;
            bottomLine = CostUD.Value;
            if(ProductList.Items.Count > 0) Save.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var prod = (Product)ProductList.SelectedItem;
            checkActive = false;
            CostUD.Value -= (decimal)prod.Cost;
            bottomLine = CostUD.Value;
            ProductList.Items.Remove(ProductList.SelectedItem);
            if (ProductList.Items.Count == 0) Save.Enabled = false;
        }

        private void ProductList_DoubleClick(object sender, EventArgs e)
        {
            var prod = ProductList.SelectedItem as Product;
            if (prod == null)
                return;                          
            checkActive = false;
            CostUD.Value -= (decimal)prod.Amount* (decimal)prod.Cost;
            var form = new ProductForm(prod.Clone());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                var si = ProductList.SelectedIndex;
                ProductList.Items.Remove(ProductList.SelectedItem);
                ProductList.Items.Insert(si,form.Prod);
            }            
            CostUD.Value += (decimal)form.Prod.Amount* (decimal)form.Prod.Cost;
            bottomLine = CostUD.Value;
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedIndex != -1)
                Delete.Enabled = true;
            else
                Delete.Enabled = false;
        }

        private float Summarise ()
        {
            float sum = 0;            
            foreach(var e in ProductList.Items)
            {
                var p = (Product)e;
                sum += p.Cost * p.Amount;
            }
            return sum;
        }

        private void CostUD_ValueChanged(object sender, EventArgs e)
        {
            if (checkActive)
            {
                bottomLine = (decimal)Summarise();
                if (CostUD.Value < bottomLine)
                    CostUD.Value = bottomLine;
                else Save.Enabled = true;
            }            
        }
    }
}
