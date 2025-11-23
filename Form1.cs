using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using LabEntityFrameworkShop.Data;
using LabEntityFrameworkShop.Models;
using System.Xml.Linq;

namespace LabEntityFrameworkShop
{
    public partial class Form1 : Form
    {
        private int pageNumber = 1;
        private int pageSize = 10;

        public Form1()
        {
            InitializeComponent();

            // На випадок, якщо подію Load не привʼязано у дизайнері
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadData();
        }

        /// <summary>
        /// Завантаження категорій і постачальників у ComboBox
        /// </summary>
        private void LoadCombos()
        {
            using (var db = new AppDbContext())
            {
                var categories = db.Categories.ToList();
                var suppliers = db.Suppliers.ToList();

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "Id";

                cmbSupplier.DataSource = suppliers;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "Id";
            }
        }

        /// <summary>
        /// Завантаження сторінки даних у DataGridView
        /// </summary>
        private void LoadData()
        {
            using (var db = new AppDbContext())
            {
                var products = db.Products
                    .OrderBy(p => p.Id)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .ToList();

                dataGridView1.DataSource = products
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Price,
                        Category = p.Category.CategoryName,
                        Supplier = p.Supplier.SupplierName,
                        p.Supplier.Country
                    })
                    .ToList();
            }

            ClearInputs();
        }

        /// <summary>
        /// Очищення полів вводу
        /// </summary>
        private void ClearInputs()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        /// <summary>
        /// Заповнення полів при виборі рядка в таблиці
        /// </summary>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows.Count > e.RowIndex)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
            }
        }

        /// <summary>
        /// Кнопка "Оновити" – перезавантажити дані
        /// </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Кнопка "Додати"
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Введіть назву та ціну товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Невірний формат ціни.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var product = new Product
                {
                    Name = txtName.Text,
                    Price = price,
                    CategoryId = (int)cmbCategory.SelectedValue,
                    SupplierId = (int)cmbSupplier.SelectedValue
                };

                db.Products.Add(product);
                db.SaveChanges();
            }

            LoadData();
        }

        /// <summary>
        /// Кнопка "Змінити"
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Оберіть товар у таблиці.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Невірний формат ціни.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var product = db.Products.Find(id);
                if (product != null)
                {
                    product.Name = txtName.Text;
                    product.Price = price;
                    product.CategoryId = (int)cmbCategory.SelectedValue;
                    product.SupplierId = (int)cmbSupplier.SelectedValue;

                    db.SaveChanges();
                }
            }

            LoadData();
        }

        /// <summary>
        /// Кнопка "Видалити"
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Оберіть товар у таблиці.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var db = new AppDbContext())
            {
                var product = db.Products.Find(id);
                if (product != null)
                {
                    var result = MessageBox.Show(
                        "Видалити вибраний товар?",
                        "Підтвердження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        db.Products.Remove(product);
                        db.SaveChanges();
                    }
                }
            }

            LoadData();
        }

        /// <summary>
        /// Кнопка "Пошук"
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var query = txtSearch.Text ?? string.Empty;

                var result = db.Products
                    .Where(p => p.Name.Contains(query))
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .ToList();

                dataGridView1.DataSource = result
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Price,
                        Category = p.Category.CategoryName,
                        Supplier = p.Supplier.SupplierName,
                        p.Supplier.Country
                    })
                    .ToList();
            }
        }

        /// <summary>
        /// Кнопка "Фільтр" – ціна > 100 і постачальник з Німеччини
        /// </summary>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var filtered = db.Products
                    .Where(p => p.Price > 100 && p.Supplier.Country == "Germany")
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .ToList();

                dataGridView1.DataSource = filtered
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Price,
                        Category = p.Category.CategoryName,
                        Supplier = p.Supplier.SupplierName,
                        p.Supplier.Country
                    })
                    .ToList();
            }
        }

        /// <summary>
        /// Кнопка "Сортування"
        /// </summary>
        private void btnSort_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var sorted = db.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .AsEnumerable()           
            .OrderBy(p => p.Price)    
            .ToList();

                dataGridView1.DataSource = sorted;
            }
        }

        /// <summary>
        /// Кнопка "Наступна сторінка"
        /// </summary>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            pageNumber++;
            LoadData();
        }

        /// <summary>
        /// Кнопка "Попередня сторінка"
        /// </summary>
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                LoadData();
            }
        }

        
    }
}
