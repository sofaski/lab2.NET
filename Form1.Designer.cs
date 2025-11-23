namespace LabEntityFrameworkShop
{
    partial class Form1
    {
        /// <summary>
        /// Обов’язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистити всі використовувані ресурси.
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси потрібно видалити; інакше false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматично створений конструктором форм Windows

        /// <summary>
        /// Метод, потрібний для підтримки конструктора — не змінюйте
        /// його вміст у редакторі коду.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            btnSearch = new Button();
            btnFilter = new Button();
            btnSort = new Button();
            btnPrevPage = new Button();
            btnNextPage = new Button();
            labelId = new Label();
            labelName = new Label();
            labelPrice = new Label();
            labelCategory = new Label();
            labelSupplier = new Label();
            labelSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(90, 15);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(80, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 75);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(440, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(382, 44);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 23);
            cmbCategory.TabIndex = 4;
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(382, 73);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(150, 23);
            cmbSupplier.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 115);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Змінити";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(290, 115);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(80, 30);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Оновити";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(650, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 27);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(650, 45);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 27);
            btnFilter.TabIndex = 13;
            btnFilter.Text = "Фільтр";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(650, 78);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(110, 27);
            btnSort.TabIndex = 14;
            btnSort.Text = "Сортування";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(20, 150);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(140, 25);
            btnPrevPage.TabIndex = 15;
            btnPrevPage.Text = "Попередня сторінка";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(180, 150);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(140, 25);
            btnNextPage.TabIndex = 16;
            btnNextPage.Text = "Наступна сторінка";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(20, 18);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 17;
            labelId.Text = "ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(20, 48);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 18;
            labelName.Text = "Назва:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(20, 78);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(35, 15);
            labelPrice.TabIndex = 19;
            labelPrice.Text = "Ціна:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(308, 47);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(62, 15);
            labelCategory.TabIndex = 20;
            labelCategory.Text = "Категорія:";
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new Point(281, 78);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(89, 15);
            labelSupplier.TabIndex = 21;
            labelSupplier.Text = "Постачальник:";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(320, 18);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(107, 15);
            labelSearch.TabIndex = 22;
            labelSearch.Text = "Пошук за назвою:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSearch);
            Controls.Add(labelSupplier);
            Controls.Add(labelCategory);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Controls.Add(labelId);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrevPage);
            Controls.Add(btnSort);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(txtSearch);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Магазин товарів (EF Core)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelSearch;
    }
}
