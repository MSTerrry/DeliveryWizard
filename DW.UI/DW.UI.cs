using DeliveryWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TimeToDeliverPicker.Value = TimeToDeliverPicker.Value.AddHours(1);
        }

        DeliveryRquestDto GetModelFromUI()
        {
            return new DeliveryRquestDto()
            {
                Filled = dateTimePicker1.Value,
                FullName = FullNameBox.Text,
                WayPoints = listBox1.Items.OfType<WayPoint>().ToList(),
                TimeDeliver = TimeToDeliverPicker.Value,
                ClientAddress = AddressBox.Text,
                TotalCost = CostUD.Value
            };
        }
        private void SetModelToUI(DeliveryRquestDto dto)
        {
            dateTimePicker1.Value = dto.Filled;
            FullNameBox.Text = dto.FullName;
            TimeToDeliverPicker.Value = dto.TimeDeliver;
            AddressBox.Text = dto.ClientAddress;
            listBox1.Items.Clear();
            CostUD.Value = dto.TotalCost;
            foreach (var e in dto.WayPoints)
            {
                listBox1.Items.Add(e);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Файлы заказов|*.dw" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
                DeliverySerializer.WriteToFile(sfd.FileName, dto);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл заказа|*.dw" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = DeliverySerializer.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new WayPointF(new WayPoint());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                listBox1.Items.Add(form.wp);                
            }
            CostUD.Value += form.wp.TotalCost;            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var wp = (WayPoint)listBox1.SelectedItem;
            CostUD.Value -= wp.TotalCost;
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var wp = listBox1.SelectedItem as WayPoint;
            if (wp == null)
                return;
            CostUD.Value -= wp.TotalCost;
            var form = new WayPointF(wp.Clone());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                var si = listBox1.SelectedIndex;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.Insert(si, form.wp);
            }
            CostUD.Value += form.wp.TotalCost;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                Delete.Enabled = true;
            else
                Delete.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckLicense();
        }

        private void CheckLicense()
        {
            var lv = new LicenceValidator(Directory.GetCurrentDirectory());
            if (!lv.HasLicense)
            {
                MessageBox.Show("Лицензия не найдена. Укажите путь к папке с лицензией.");
                FolderBrowserDialog dr = new FolderBrowserDialog();
                var result = dr.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CheckLicense(dr.SelectedPath);
                }
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            else if (!lv.IsValid)
            {
                MessageBox.Show("Лицензия просрочена.Укажите путь к папке с лицензией.");
                FolderBrowserDialog dr = new FolderBrowserDialog();
                var result = dr.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CheckLicense(dr.SelectedPath);
                }
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }
        private void CheckLicense(string newPath)
        {
            var lv = new LicenceValidator(newPath);
            if (!lv.HasLicense)
            {
                MessageBox.Show("Лицензия не найдена. Укажите путь к папке с лицензией.");
                FolderBrowserDialog dr = new FolderBrowserDialog();                                
                var result = dr.ShowDialog();
                if(result == DialogResult.OK)
                {
                    CheckLicense(dr.SelectedPath);
                }
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }                
            }
            if (!lv.IsValid)
            {
                MessageBox.Show("Лицензия просрочена.Укажите путь к папке с лицензией.");
                FolderBrowserDialog dr = new FolderBrowserDialog();
                var result = dr.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CheckLicense(dr.SelectedPath);
                }
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }
    }
}
