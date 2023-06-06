using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class SellerProductAdd : Form
    {
        private int _ProductID;
        private int _SellerID;


        public SellerProductAdd(int productid, int sellerid)
        {
            InitializeComponent();
            _ProductID = productid;
            _SellerID = sellerid;
            this.Load += SellerProductAdd_Load;
        }

        private void SellerProductAdd_Load(object sender, EventArgs e)
        {
            //IQueryable<Product> query = new Model1().Products.AsNoTracking();

            //_ProductID = query.OrderByDescending(c => c.ProductID).Select(c => c.ProductID).FirstOrDefault();
            //_SellerID= (int)query.OrderByDescending(c => c.ProductID).Select(c => c.SellerID).FirstOrDefault();
            //txtProductId.Text = _ProductID.ToString();
            ////MessageBox.Show($"{_SellerID}");

            //var db = new AppDbContext();
            //var result = from p in db.Products//商品表
            //             join o in db.ProductInventories
            //             on p.ProductID equals o.ProductID  //進貨單表
            //             where p.ProductID == _ProductID
            //             group o by o.ProductID into g
            //             select new
            //             {
            //                 ProductID = g.Key,
            //                 TotalQuantity = g.Sum(x => x.Quantity)
            //             };

            //var item = result.FirstOrDefault();
            //if (item != null)
            //{
            //    txtTotal.Text = item.TotalQuantity.ToString();
            //}
            //else
            //{
            //    txtTotal.Text = "0";
            //}
            var db = new AppDbContext();
            var result2 = from p in db.Products
                          join q in db.ProductsStocks
                          on p.ProductID equals q.ProductID
                          select new
                          {
                              ProductID = p.ProductID,
                              StockQuantity = q.StockQuantity
                          };

            txtTotal.Text = result2.Where(x => x.ProductID == _ProductID).FirstOrDefault()?.StockQuantity.ToString();
        }


        public void ProductAddNew()
        {
            //IQueryable<Product> query = new AppDbContext().Products.AsNoTracking();
            //_ProductID = query.OrderByDescending(c => c.ProductID).Select(c => c.ProductID).FirstOrDefault();
            //_SellerID = (int)query.OrderByDescending(c => c.ProductID).Select(c => c.SellerID).FirstOrDefault();
            txtProductId.Text = _ProductID.ToString();
            btnEdit.Enabled = false;
        }

        public void ProductEdit(int x, int y)
        {
            IQueryable<Product> query = new AppDbContext().Products.AsNoTracking();
            _ProductID = x;
            _SellerID = y;

            txtProductId.Text = _ProductID.ToString();
            var product = new AppDbContext()
                            .Products
                            .AsNoTracking()
                            .Where(c => c.ProductID == _ProductID)
                            .SingleOrDefault();
            txtProductName.Text = product.ProductName;
            txtCategoryId.Text = product.CategoryID;
            txtProductPrice.Text = product.ProductPrice.ToString();
            txtProductDescription.Text = product.ProductDescription;
            btnProductAdd.Enabled = false;

        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == string.Empty ||
               txtCategoryId.Text == string.Empty ||
               txtProductPrice.Text == string.Empty ||
               txtProductDescription.Text == string.Empty)
            {
                MessageBox.Show("請完整輸入商品內容!");
                return;
            }

            var db = new AppDbContext();
            int ProductId = Convert.ToInt32(txtProductId.Text);
            string name = txtProductName.Text;
            string categoryId = txtCategoryId.Text;
            string description = txtProductDescription.Text;
            bool isInt = int.TryParse(txtProductPrice.Text, out int price);

            // 更新記錄
            var product = new Product()
            {
                ProductID = ProductId,
                SellerID = _SellerID,
                ProductName = name,
                CategoryID = categoryId,
                ProductDescription = description,
                ProductPrice = price,
            };
            db.Products.Add(product);
            db.SaveChanges();

            var stock = new ProductsStock();
            stock.ProductID = ProductId;
            stock.PurchaseQuantity = 0;
            stock.OrderQuantity = 0;
            stock.QuantitySold = 0;
            stock.StockQuantity = 0;
            db.ProductsStocks.Add(stock);
            db.SaveChanges();

            //新增進貨
            if (txtProductQuantity.Text != string.Empty)
            {
                bool Q = int.TryParse(txtProductQuantity.Text, out int quantity);
                var productinventory = new ProductInventory()
                {
                    ProductID = Convert.ToInt32(txtProductId.Text),
                    SellerID = _SellerID,
                    Quantity = quantity,
                };
                db.ProductInventories.Add(productinventory);
                db.SaveChanges();

                var productStock = db.ProductsStocks.FirstOrDefault(x => x.ProductID == ProductId);

                if (productStock != null)
                {
                    // 更新購買數量
                    productStock.PurchaseQuantity += quantity;
                    productStock.StockQuantity += quantity;

                    // 儲存更改到資料庫
                    db.SaveChanges();
                }

            }

            MessageBox.Show("已更新完成!");
            Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == string.Empty ||
              txtCategoryId.Text == string.Empty ||
              txtProductPrice.Text == string.Empty ||
              txtProductDescription.Text == string.Empty)
            {
                MessageBox.Show("請完整輸入商品內容!");
                return;
            }

            var db = new AppDbContext();
            var product = db.Products.Find(_ProductID);
            product.ProductName = txtProductName.Text;
            product.CategoryID = txtCategoryId.Text;
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductDescription = txtProductDescription.Text;
            db.SaveChanges();

            //新增進貨
            if (txtProductQuantity.Text != string.Empty)
            {
                bool Q = int.TryParse(txtProductQuantity.Text, out int quantity);
                var productinventory = new ProductInventory()
                {
                    ProductID = Convert.ToInt32(txtProductId.Text),
                    SellerID = _SellerID,
                    Quantity = quantity,
                };
                db.ProductInventories.Add(productinventory);
                db.SaveChanges();

                var productStock = db.ProductsStocks.FirstOrDefault(x => x.ProductID == _ProductID);

                if (productStock != null)
                {
                    // 更新購買數量
                    productStock.PurchaseQuantity += quantity;
                    productStock.StockQuantity += quantity;

                    // 儲存更改到資料庫
                    db.SaveChanges();
                }

            }
            MessageBox.Show("已更新完成!");
            Close();
        }


        private void btnQuantity_Click_1(object sender, EventArgs e)
        {
            label7.Visible = !label7.Visible;
            txtProductQuantity.Visible = !txtProductQuantity.Visible;
            txtProductName.Enabled = !txtProductName.Enabled;
            txtCategoryId.Enabled = !txtCategoryId.Enabled;
            txtProductPrice.Enabled = !txtProductPrice.Enabled;
            txtProductDescription.Enabled = !txtProductDescription.Enabled;

            if (label7.Visible)
            {
                txtProductQuantity.Focus();
            }
            else
            {
                txtProductName.Focus();
            }
        }
    }
}
