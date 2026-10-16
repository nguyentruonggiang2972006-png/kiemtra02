using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BaiTapNangCao
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; } // Chỉ lưu đường dẫn, không nạp cả ảnh vào Grid
    }

    public partial class frmInventoryManager : Form
    {
        private BindingList<Product> inventoryList;
        private BindingSource bindingSource;
        private string currentImagePath = "";

        public frmInventoryManager()
        {
            InitializeComponent();
            inventoryList = new BindingList<Product>();
            bindingSource = new BindingSource { DataSource = inventoryList };
            dgvInventory.DataSource = bindingSource;

            // Đăng ký sự kiện
            this.FormClosing += FrmInventoryManager_FormClosing;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            btnSelectImage.Click += BtnSelectImage_Click;
            tsbAdd.Click += TsbAdd_Click;
            tsbDelete.Click += TsbDelete_Click;
            mnuExportCSV.Click += MnuExportCSV_Click;
            mnuImportCSV.Click += MnuImportCSV_Click;
            mnuExit.Click += (s, e) => this.Close();

            inventoryList.ListChanged += (s, e) => UpdateStatusStrip();
        }

        // 1. Cập nhật StatusStrip & Timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void UpdateStatusStrip()
        {
            int totalItems = 0;
            decimal totalValue = 0;

            foreach (var item in inventoryList)
            {
                totalItems += item.Quantity;
                totalValue += (item.Price * item.Quantity);
            }

            lblTotalItems.Text = $"Tổng SP: {totalItems}";
            lblTotalValue.Text = $" | Tổng giá trị: {totalValue:N0} VNĐ | ";
        }

        // 2. Chọn Ảnh (OpenFileDialog)
        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn ảnh sản phẩm";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = ofd.FileName;
                    picProductImage.Image = Image.FromFile(currentImagePath);
                }
            }
        }

        // 3. Thêm / Xóa Sản phẩm
        private void TsbAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã và Tên SP!");
                return;
            }

            inventoryList.Add(new Product
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Category = cboCategory.Text,
                Price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0,
                Quantity = (int)numQuantity.Value,
                ImagePath = currentImagePath
            });

            // Reset input
            txtId.Clear(); txtName.Clear(); txtPrice.Clear(); numQuantity.Value = 0;
            picProductImage.Image = null; currentImagePath = "";
        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null)
            {
                bindingSource.RemoveCurrent();
            }
        }

        // 4. Ghi File (SaveFileDialog)
        private void MnuExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File|*.csv";
                sfd.Title = "Xuất báo cáo kho";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("Id,Name,Category,Price,Quantity,ImagePath");
                        foreach (var item in inventoryList)
                        {
                            sw.WriteLine($"{item.Id},{item.Name},{item.Category},{item.Price},{item.Quantity},{item.ImagePath}");
                        }
                    }
                    MessageBox.Show("Xuất file thành công!", "Thông báo");
                }
            }
        }

        // 5. Đọc File (OpenFileDialog)
        private void MnuImportCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV File|*.csv";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    inventoryList.Clear();
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    for (int i = 1; i < lines.Length; i++) // Bỏ qua dòng header (index 0)
                    {
                        string[] data = lines[i].Split(',');
                        if (data.Length >= 6)
                        {
                            inventoryList.Add(new Product
                            {
                                Id = data[0],
                                Name = data[1],
                                Category = data[2],
                                Price = decimal.Parse(data[3]),
                                Quantity = int.Parse(data[4]),
                                ImagePath = data[5]
                            });
                        }
                    }
                    MessageBox.Show("Nhập dữ liệu thành công!", "Thông báo");
                }
            }
        }

        // 6. Xác nhận Thoát
        private void FrmInventoryManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}