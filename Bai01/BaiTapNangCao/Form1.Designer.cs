using System.Drawing;
using System.Windows.Forms;

namespace BaiTapNangCao
{
    partial class frmDeviceManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();

            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();

            // === GROUP NHẬP LIỆU ===
            this.grpInput.Controls.Add(this.lblId);
            this.grpInput.Controls.Add(this.txtDeviceId);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.txtDeviceName);
            this.grpInput.Controls.Add(this.lblCategory);
            this.grpInput.Controls.Add(this.cboCategory);
            this.grpInput.Controls.Add(this.lblPrice);
            this.grpInput.Controls.Add(this.txtPrice);
            this.grpInput.Controls.Add(this.lblQuantity);
            this.grpInput.Controls.Add(this.numQuantity);
            this.grpInput.Location = new System.Drawing.Point(20, 20);
            this.grpInput.Size = new System.Drawing.Size(740, 160);
            this.grpInput.Text = "Thông tin Thiết bị";

            this.lblId.Location = new System.Drawing.Point(30, 40);
            this.lblId.Text = "Mã TB (Tự động):";
            this.txtDeviceId.Location = new System.Drawing.Point(140, 37);
            this.txtDeviceId.Size = new System.Drawing.Size(200, 26);
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.BackColor = System.Drawing.Color.LightGray;

            this.lblName.Location = new System.Drawing.Point(30, 80);
            this.lblName.Text = "Tên thiết bị:";
            this.txtDeviceName.Location = new System.Drawing.Point(140, 77);
            this.txtDeviceName.Size = new System.Drawing.Size(200, 26);

            this.lblCategory.Location = new System.Drawing.Point(30, 120);
            this.lblCategory.Text = "Loại thiết bị:";
            this.cboCategory.Location = new System.Drawing.Point(140, 117);
            this.cboCategory.Size = new System.Drawing.Size(200, 28);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Items.AddRange(new string[] { "Điện thoại", "Laptop", "Máy tính bảng", "Phụ kiện" });

            this.lblPrice.Location = new System.Drawing.Point(400, 40);
            this.lblPrice.Text = "Đơn giá (VNĐ):";
            this.txtPrice.Location = new System.Drawing.Point(510, 37);
            this.txtPrice.Size = new System.Drawing.Size(200, 26);

            this.lblQuantity.Location = new System.Drawing.Point(400, 80);
            this.lblQuantity.Text = "Số lượng tồn:";
            this.numQuantity.Location = new System.Drawing.Point(510, 77);
            this.numQuantity.Size = new System.Drawing.Size(200, 26);
            this.numQuantity.Maximum = 10000;

            // === GROUP NÚT CHỨC NĂNG ===
            this.grpButtons.Controls.Add(this.btnAdd);
            this.grpButtons.Controls.Add(this.btnUpdate);
            this.grpButtons.Controls.Add(this.btnDelete);
            this.grpButtons.Controls.Add(this.btnClear);
            this.grpButtons.Location = new System.Drawing.Point(20, 190);
            this.grpButtons.Size = new System.Drawing.Size(740, 80);
            this.grpButtons.Text = "Chức năng";

            this.btnAdd.Location = new System.Drawing.Point(140, 30);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Text = "Thêm mới";

            this.btnUpdate.Location = new System.Drawing.Point(260, 30);
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.Text = "Cập nhật";

            this.btnDelete.Location = new System.Drawing.Point(380, 30);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "Xóa";

            this.btnClear.Location = new System.Drawing.Point(500, 30);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "Làm mới";

            // === DATAGRIDVIEW ===
            this.dgvDevices.Location = new System.Drawing.Point(20, 290);
            this.dgvDevices.Size = new System.Drawing.Size(740, 250);
            this.dgvDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevices.ReadOnly = true;
            this.dgvDevices.AllowUserToAddRows = false;
            this.dgvDevices.BackgroundColor = System.Drawing.Color.White;

            // === FORM ===
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.dgvDevices);
            this.Name = "frmDeviceManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1: Quản lý Danh mục Thiết bị Điện tử (Data Binding)";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;

        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}