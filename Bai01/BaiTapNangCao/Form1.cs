using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BaiTapNangCao
{
    // 1. Khai báo Class Đối tượng
    public class Device
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public partial class frmDeviceManager : Form
    {
        // 2. Khai báo BindingList và BindingSource
        private BindingList<Device> deviceList;
        private BindingSource bindingSource;
        private int deviceCounter = 1;

        public frmDeviceManager()
        {
            InitializeComponent();
            SetupDataGridView();

            // Khởi tạo danh sách và BindingSource
            deviceList = new BindingList<Device>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = deviceList;

            // Gán Data Binding cho DataGridView
            dgvDevices.DataSource = bindingSource;

            // Kết nối các sự kiện
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
            dgvDevices.SelectionChanged += DgvDevices_SelectionChanged;

            // Tạo mã TB đầu tiên
            GenerateNewDeviceId();
        }

        // 3. Cấu hình Cột thủ công (AutoGenerateColumns = false)
        private void SetupDataGridView()
        {
            dgvDevices.AutoGenerateColumns = false;

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeviceId", HeaderText = "Mã TB", Width = 100 });
            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeviceName", HeaderText = "Tên Thiết Bị", Width = 200 });
            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Loại", Width = 120 });

            // Định dạng tiền tệ cho cột Đơn giá
            var priceCol = new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Đơn Giá (VNĐ)", Width = 150 };
            priceCol.DefaultCellStyle.Format = "N0";
            dgvDevices.Columns.Add(priceCol);

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số Lượng Tồn", Width = 100 });
        }

        private void GenerateNewDeviceId()
        {
            txtDeviceId.Text = "TB" + deviceCounter.ToString("D3");
        }

        // 4. Kỹ thuật Validation dùng ErrorProvider
        private bool ValidateInput()
        {
            bool isValid = true;
            errProvider.Clear(); // Xóa lỗi cũ

            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                errProvider.SetError(txtDeviceName, "Tên thiết bị không được để trống!");
                isValid = false;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                errProvider.SetError(cboCategory, "Vui lòng chọn loại thiết bị!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                errProvider.SetError(txtPrice, "Đơn giá phải là số hợp lệ và >= 0!");
                isValid = false;
            }

            return isValid;
        }

        // 5. Xử lý Thêm mới (Thêm vào List -> Grid tự cập nhật)
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Device newDevice = new Device
                {
                    DeviceId = txtDeviceId.Text,
                    DeviceName = txtDeviceName.Text,
                    Category = cboCategory.SelectedItem.ToString(),
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Quantity = (int)numQuantity.Value
                };

                deviceList.Add(newDevice); // Thêm vào BindingList

                deviceCounter++;
                BtnClear_Click(null, null); // Làm mới ô nhập
                MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 6. Xử lý Cập nhật
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            if (ValidateInput())
            {
                // Lấy đối tượng đang được chọn
                Device currentDevice = (Device)bindingSource.Current;

                // Cập nhật giá trị
                currentDevice.DeviceName = txtDeviceName.Text;
                currentDevice.Category = cboCategory.SelectedItem.ToString();
                currentDevice.Price = Convert.ToDecimal(txtPrice.Text);
                currentDevice.Quantity = (int)numQuantity.Value;

                // Reset lưới để hiển thị dữ liệu mới
                bindingSource.ResetBindings(false);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 7. Xử lý Xóa
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    bindingSource.RemoveCurrent(); // Xóa khỏi BindingSource
                }
            }
        }

        // 8. Làm mới ô nhập
        private void BtnClear_Click(object sender, EventArgs e)
        {
            GenerateNewDeviceId();
            txtDeviceName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            numQuantity.Value = 0;
            errProvider.Clear();
            txtDeviceName.Focus();
        }

        // 9. Đồng bộ ngược từ Grid lên Form nhập liệu khi click chọn dòng
        private void DgvDevices_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current != null && dgvDevices.SelectedRows.Count > 0)
            {
                Device currentDevice = (Device)bindingSource.Current;

                txtDeviceId.Text = currentDevice.DeviceId;
                txtDeviceName.Text = currentDevice.DeviceName;
                cboCategory.SelectedItem = currentDevice.Category;
                txtPrice.Text = currentDevice.Price.ToString("G0"); // Bỏ định dạng để dễ sửa
                numQuantity.Value = currentDevice.Quantity;

                errProvider.Clear(); // Xóa cờ báo lỗi nếu có
            }
        }
    }
}