using System.Windows.Forms;
using System.Xml.Linq;

namespace ObjectOrientedPractice.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            listBoxCartItems = new ListBox();
            panel2 = new Panel();
            buttonAddToCart = new Button();
            panel1 = new Panel();
            label1 = new Label();
            textBoxAmount = new TextBox();
            listBoxCartOrder = new ListBox();
            buttonClearCart = new Button();
            buttonCreateOrder = new Button();
            buttonRemoveItem = new Button();
            label4 = new Label();
            label3 = new Label();
            comboBoxCustomerInCart = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxAmount);
            splitContainer1.Panel2.Controls.Add(listBoxCartOrder);
            splitContainer1.Panel2.Controls.Add(buttonClearCart);
            splitContainer1.Panel2.Controls.Add(buttonCreateOrder);
            splitContainer1.Panel2.Controls.Add(buttonRemoveItem);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(comboBoxCustomerInCart);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(966, 512);
            splitContainer1.SplitterDistance = 428;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBoxCartItems);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 32);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 422);
            panel3.TabIndex = 4;
            // 
            // listBoxCartItems
            // 
            listBoxCartItems.Dock = DockStyle.Fill;
            listBoxCartItems.FormattingEnabled = true;
            listBoxCartItems.ItemHeight = 15;
            listBoxCartItems.Location = new Point(0, 0);
            listBoxCartItems.Margin = new Padding(3, 2, 3, 2);
            listBoxCartItems.Name = "listBoxCartItems";
            listBoxCartItems.Size = new Size(428, 422);
            listBoxCartItems.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAddToCart);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 454);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 58);
            panel2.TabIndex = 3;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(12, 4);
            buttonAddToCart.Margin = new Padding(3, 2, 3, 2);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(117, 43);
            buttonAddToCart.TabIndex = 0;
            buttonAddToCart.Text = "Add To Cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCartClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 32);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxAmount.Location = new Point(393, 297);
            textBoxAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.ReadOnly = true;
            textBoxAmount.Size = new Size(110, 26);
            textBoxAmount.TabIndex = 11;
            textBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // listBoxCartOrder
            // 
            listBoxCartOrder.FormattingEnabled = true;
            listBoxCartOrder.ItemHeight = 15;
            listBoxCartOrder.Location = new Point(12, 105);
            listBoxCartOrder.Margin = new Padding(3, 2, 3, 2);
            listBoxCartOrder.Name = "listBoxCartOrder";
            listBoxCartOrder.Size = new Size(490, 169);
            listBoxCartOrder.TabIndex = 10;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Location = new Point(389, 334);
            buttonClearCart.Margin = new Padding(3, 2, 3, 2);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(113, 41);
            buttonClearCart.TabIndex = 9;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            buttonClearCart.MouseClick += buttonClearCartMouseClick;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(12, 334);
            buttonCreateOrder.Margin = new Padding(3, 2, 3, 2);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(113, 41);
            buttonCreateOrder.TabIndex = 8;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrderClick;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Location = new Point(255, 334);
            buttonRemoveItem.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(113, 41);
            buttonRemoveItem.TabIndex = 7;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItemClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(437, 278);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 4;
            label4.Text = "Amount:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
            // 
            // comboBoxCustomerInCart
            // 
            comboBoxCustomerInCart.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerInCart.FormattingEnabled = true;
            comboBoxCustomerInCart.Location = new Point(96, 32);
            comboBoxCustomerInCart.Margin = new Padding(3, 2, 3, 2);
            comboBoxCustomerInCart.Name = "comboBoxCustomerInCart";
            comboBoxCustomerInCart.Size = new Size(406, 23);
            comboBoxCustomerInCart.TabIndex = 1;
            comboBoxCustomerInCart.SelectedIndexChanged += comboBoxCustomerInCartSelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 0;
            label2.Text = "Customer:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CartsTab";
            Size = new Size(966, 512);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private ListBox listBoxCartItems;
        private Panel panel2;
        private Button buttonAddToCart;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxCustomerInCart;
        private Button buttonCreateOrder;
        private Button buttonRemoveItem;
        private Button buttonClearCart;
        private ListBox listBoxCartOrder;
        private TextBox textBoxAmount;
    }
}

