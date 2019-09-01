namespace Consignment_Shop_UI
{
    partial class Consignment_Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_header_text = new System.Windows.Forms.Label();
            this.lstbox_items = new System.Windows.Forms.ListBox();
            this.lbl_lstbox_items = new System.Windows.Forms.Label();
            this.btn_add_to_cart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbox_shopping_cart = new System.Windows.Forms.ListBox();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_header_text
            // 
            this.lbl_header_text.AutoSize = true;
            this.lbl_header_text.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header_text.Location = new System.Drawing.Point(79, 35);
            this.lbl_header_text.Name = "lbl_header_text";
            this.lbl_header_text.Size = new System.Drawing.Size(647, 64);
            this.lbl_header_text.TabIndex = 0;
            this.lbl_header_text.Text = "Consignment Shop Demo";
            // 
            // lstbox_items
            // 
            this.lstbox_items.FormattingEnabled = true;
            this.lstbox_items.ItemHeight = 31;
            this.lstbox_items.Location = new System.Drawing.Point(21, 161);
            this.lstbox_items.Name = "lstbox_items";
            this.lstbox_items.Size = new System.Drawing.Size(277, 345);
            this.lstbox_items.TabIndex = 1;
            // 
            // lbl_lstbox_items
            // 
            this.lbl_lstbox_items.AutoSize = true;
            this.lbl_lstbox_items.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstbox_items.Location = new System.Drawing.Point(24, 127);
            this.lbl_lstbox_items.Name = "lbl_lstbox_items";
            this.lbl_lstbox_items.Size = new System.Drawing.Size(153, 31);
            this.lbl_lstbox_items.TabIndex = 2;
            this.lbl_lstbox_items.Text = "Store Itmes";
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.Location = new System.Drawing.Point(315, 242);
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.Size = new System.Drawing.Size(199, 62);
            this.btn_add_to_cart.TabIndex = 3;
            this.btn_add_to_cart.Text = "Add to Cart";
            this.btn_add_to_cart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shopping Cart";
            // 
            // lstbox_shopping_cart
            // 
            this.lstbox_shopping_cart.FormattingEnabled = true;
            this.lstbox_shopping_cart.ItemHeight = 31;
            this.lstbox_shopping_cart.Location = new System.Drawing.Point(535, 161);
            this.lstbox_shopping_cart.Name = "lstbox_shopping_cart";
            this.lstbox_shopping_cart.Size = new System.Drawing.Size(301, 345);
            this.lstbox_shopping_cart.TabIndex = 4;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(637, 517);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(199, 62);
            this.btn_purchase.TabIndex = 6;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            // 
            // Consignment_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 591);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbox_shopping_cart);
            this.Controls.Add(this.btn_add_to_cart);
            this.Controls.Add(this.lbl_lstbox_items);
            this.Controls.Add(this.lstbox_items);
            this.Controls.Add(this.lbl_header_text);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Consignment_Shop";
            this.Text = "Consignment_Shop_demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header_text;
        private System.Windows.Forms.ListBox lstbox_items;
        private System.Windows.Forms.Label lbl_lstbox_items;
        private System.Windows.Forms.Button btn_add_to_cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbox_shopping_cart;
        private System.Windows.Forms.Button btn_purchase;
    }
}

