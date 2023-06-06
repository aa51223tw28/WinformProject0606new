using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class Buyerpurchasehistory : Form
    {
        public int _userIdBuyerpurchasehistory;
        public int _cartIdBuyerpurchasehistory;

        List<ListAllDto> data;




        public Buyerpurchasehistory()
        {
            InitializeComponent();
            this.Load += Buyerpurchasehistory_Load;
        }

        private void Buyerpurchasehistory_Load(object sender, EventArgs e)
        {
            var db=new AppDbContext();
            var acc=db.Users.Where(x=>x.UserID==_userIdBuyerpurchasehistory)
                                .Select(x=>x.UserAccount).FirstOrDefault();

            textBoxaccount.Text = acc;

            //datagridview
            var query =db.Orders.Where(x=>x.UserID== _userIdBuyerpurchasehistory)                                
                                .ToList();

            data=query.Select(x=>new ListAllDto()
            {
                OrderID=x.OrderID,
                ShipmentDate= (DateTime)x.OrderDate

            }).ToList();

            dataGridView1.DataSource= data;
           
        }

        private void buttonbackmain_Click(object sender, EventArgs e)
        {
            var frm = new BuyerMain();
            frm.MdiParent = Login.ActiveForm;
            frm._userIdMain = _userIdBuyerpurchasehistory;
            frm._cartIdBuyerMain = _cartIdBuyerpurchasehistory;
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0) return;

            int _orderid = this.data[e.RowIndex].OrderID;

            var frm = new BuyerListEnd(_orderid);
            frm.MdiParent = Login.ActiveForm;
            //frm._orderID= _orderid;
            frm._userIdBuyerListEnd= _userIdBuyerpurchasehistory;
            frm._cartIdBuyerListEnd = _cartIdBuyerpurchasehistory;
            frm.Show();
        }
    }
}
