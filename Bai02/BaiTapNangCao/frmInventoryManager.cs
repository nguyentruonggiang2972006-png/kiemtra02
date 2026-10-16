namespace BaiTapNangCao
{
    partial class frmInventoryManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();

            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuSystem, this.mnuTools });
            this.mnuSystem.Text = "Hệ thống";
            this.mnuExit.Text = "Thoát";
            this.mnuSystem.DropDownItems.Add(this.mnuExit);
            this.mnuTools.Text = "Công cụ";
            this.mnuImportCSV.Text = "Nhập dữ liệu (Import CSV)";
            this.mnuExportCSV.Text = "Xuất báo cáo (Export CSV)";
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuImportCSV, this.mnuExportCSV });

            // ToolStrip
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tsbAdd, this.tsbDelete });
            this.tsbAdd.Text = "Thêm SP";
            this.tsbDelete.Text = "Xóa SP";

            // StatusStrip
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblTotalItems, this.lblTotalValue, this.lblTime });
            this.lblTotalItems.Text = "Tổng SP: 0";
            this.lblTotalValue.Text = " | Tổng giá trị: 0 VNĐ | ";
            this.lblTime.Text = "Thời gian: ";

            // GroupInput
            this.grpInput.Location = new System.Drawing.Point(12, 60);
            this.grpInput.Size = new System.Drawing.Size(760, 200);
            this.grpInput.Text = "Thông tin sản phẩm";

            this.txtId.Location = new System.Drawing.Point(20, 30); this.txtId.PlaceholderText = "Mã SP";
            this.txtName.Location = new System.Drawing.Point(20, 70); this.txtName.PlaceholderText = "Tên SP";
            this.cboCategory.Location = new System.Drawing.Point(20, 110);
            this.cboCategory.Items.AddRange(new string[] { "Điện tử", "Gia dụng", "Thực phẩm" });
            this.txtPrice.Location = new System.Drawing.Point(20, 150); this.txtPrice.PlaceholderText = "Đơn giá";
            this.numQuantity.Location = new System.Drawing.Point(150, 150);

            this.picProductImage.Location = new System.Drawing.Point(300, 30);
            this.picProductImage.Size = new System.Drawing.Size(150, 150);
            this.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnSelectImage.Location = new System.Drawing.Point(470, 30);
            this.btnSelectImage.Text = "Chọn ảnh...";

            this.grpInput.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtId, this.txtName, this.cboCategory, this.txtPrice, this.numQuantity, this.picProductImage, this.btnSelectImage });

            // DataGridView
            this.dgvInventory.Location = new System.Drawing.Point(12, 280);
            this.dgvInventory.Size = new System.Drawing.Size(760, 250);
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Form
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInventoryManager";
            this.Text = "Bài 2: Quản lý Kho & Báo Cáo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.menuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuImportCSV;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCSV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalItems;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalValue;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}