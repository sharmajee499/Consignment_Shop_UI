using Consognment_shop_library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consignment_Shop_UI
{
    public partial class Consignment_Shop : Form
    {
        private store store1 = new store();
        BindingSource itemsBinding = new BindingSource();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource cartBinding = new BindingSource();

        public Consignment_Shop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store1.Items;
            lstbox_items.DataSource = itemsBinding;
            lstbox_items.DisplayMember = "Display";
            lstbox_items.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            lstbox_shopping_cart.DataSource = cartBinding;

            lstbox_shopping_cart.DisplayMember = "Display";
            lstbox_shopping_cart.ValueMember = "Display";
        }

        private void SetupData()
        {

            store1.Vendor.Add(new VendorClass { FirstName = "Bill", LastName = "Smith" });
            store1.Vendor.Add(new VendorClass { FirstName = "Sue", LastName = "Jones" });

            store1.Items.Add(new Item
            {
                Title = "Mobi Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owener = store1.Vendor[0]
            });

            store1.Items.Add(new Item
            {
                Title = "A Tale of two cities",
                Description = "A book about a Revolution",
                Price = 3.80M,
                Owener = store1.Vendor[1]
            });

            store1.Items.Add(new Item
            {
                Title = "Harry Potter 1",
                Description = "A book about a Magic",
                Price = 5.20M,
                Owener = store1.Vendor[1]
            });

            store1.Items.Add(new Item
            {
                Title = "HP 2",
                Description = "A book about a magic",
                Price = 6.80M,
                Owener = store1.Vendor[0]
            });

            store1.Name = "Second are Better";

        }

        private void Btn_add_to_cart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)lstbox_items.SelectedItem;
            shoppingCartData.Add(selectedItem);

        }
    }
}
