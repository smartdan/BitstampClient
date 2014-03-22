namespace Client
{
    partial class BuySellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuySellForm));
            this.labelOpenBuy = new System.Windows.Forms.Label();
            this.labelOpenSell = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.listViewOpenSell = new System.Windows.Forms.ListView();
            this.listViewOpenBuy = new System.Windows.Forms.ListView();
            this.labelValueBalance = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.labelTransactions = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOpenBuy
            // 
            this.labelOpenBuy.AutoSize = true;
            this.labelOpenBuy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenBuy.Location = new System.Drawing.Point(12, 205);
            this.labelOpenBuy.Name = "labelOpenBuy";
            this.labelOpenBuy.Size = new System.Drawing.Size(107, 13);
            this.labelOpenBuy.TabIndex = 12;
            this.labelOpenBuy.Text = "Open in buy orders";
            // 
            // labelOpenSell
            // 
            this.labelOpenSell.AutoSize = true;
            this.labelOpenSell.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenSell.Location = new System.Drawing.Point(12, 74);
            this.labelOpenSell.Name = "labelOpenSell";
            this.labelOpenSell.Size = new System.Drawing.Size(105, 13);
            this.labelOpenSell.TabIndex = 11;
            this.labelOpenSell.Text = "Open in sell orders";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(12, 20);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(47, 13);
            this.labelBalance.TabIndex = 10;
            this.labelBalance.Text = "Balance";
            // 
            // listViewOpenSell
            // 
            this.listViewOpenSell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOpenSell.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOpenSell.Location = new System.Drawing.Point(15, 91);
            this.listViewOpenSell.Name = "listViewOpenSell";
            this.listViewOpenSell.Size = new System.Drawing.Size(741, 102);
            this.listViewOpenSell.TabIndex = 13;
            this.listViewOpenSell.UseCompatibleStateImageBehavior = false;
            this.listViewOpenSell.View = System.Windows.Forms.View.List;
            // 
            // listViewOpenBuy
            // 
            this.listViewOpenBuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOpenBuy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOpenBuy.Location = new System.Drawing.Point(15, 221);
            this.listViewOpenBuy.Name = "listViewOpenBuy";
            this.listViewOpenBuy.Size = new System.Drawing.Size(741, 102);
            this.listViewOpenBuy.TabIndex = 14;
            this.listViewOpenBuy.UseCompatibleStateImageBehavior = false;
            this.listViewOpenBuy.View = System.Windows.Forms.View.List;
            // 
            // labelValueBalance
            // 
            this.labelValueBalance.AutoSize = true;
            this.labelValueBalance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueBalance.Location = new System.Drawing.Point(15, 37);
            this.labelValueBalance.Name = "labelValueBalance";
            this.labelValueBalance.Size = new System.Drawing.Size(11, 13);
            this.labelValueBalance.TabIndex = 15;
            this.labelValueBalance.Text = "-";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(64, 497);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(128, 22);
            this.textPrice.TabIndex = 16;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(64, 540);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(128, 22);
            this.textAmount.TabIndex = 17;
            // 
            // textId
            // 
            this.textId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textId.Location = new System.Drawing.Point(625, 497);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(128, 22);
            this.textId.TabIndex = 18;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(625, 537);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel order";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(209, 494);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(103, 23);
            this.buttonBuy.TabIndex = 20;
            this.buttonBuy.Text = "Buy limit";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(209, 537);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(103, 23);
            this.buttonSell.TabIndex = 21;
            this.buttonSell.Text = "Sell limit";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(12, 504);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 22;
            this.labelPrice.Text = "Price";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(12, 547);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 13);
            this.labelAmount.TabIndex = 23;
            this.labelAmount.Text = "Amount";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(12, 595);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 13);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "Status";
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTransactions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTransactions.Location = new System.Drawing.Point(15, 373);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(741, 102);
            this.listViewTransactions.TabIndex = 25;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.View = System.Windows.Forms.View.List;
            // 
            // labelTransactions
            // 
            this.labelTransactions.AutoSize = true;
            this.labelTransactions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransactions.Location = new System.Drawing.Point(15, 354);
            this.labelTransactions.Name = "labelTransactions";
            this.labelTransactions.Size = new System.Drawing.Size(71, 13);
            this.labelTransactions.TabIndex = 26;
            this.labelTransactions.Text = "Transactions";
            // 
            // buttonGet
            // 
            this.buttonGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGet.Location = new System.Drawing.Point(678, 344);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 27;
            this.buttonGet.Text = "Get ";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrders.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.Location = new System.Drawing.Point(678, 62);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(75, 23);
            this.buttonOrders.TabIndex = 28;
            this.buttonOrders.Text = "Get ";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // labelOrderId
            // 
            this.labelOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderId.Location = new System.Drawing.Point(571, 500);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(53, 13);
            this.labelOrderId.TabIndex = 29;
            this.labelOrderId.Text = "Order Id ";
            // 
            // BuySellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(768, 626);
            this.Controls.Add(this.labelOrderId);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.labelTransactions);
            this.Controls.Add(this.listViewTransactions);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelValueBalance);
            this.Controls.Add(this.listViewOpenBuy);
            this.Controls.Add(this.listViewOpenSell);
            this.Controls.Add(this.labelOpenBuy);
            this.Controls.Add(this.labelOpenSell);
            this.Controls.Add(this.labelBalance);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuySellForm";
            this.Text = "BuySellForm";
            this.Load += new System.EventHandler(this.BuySellForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpenBuy;
        private System.Windows.Forms.Label labelOpenSell;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.ListView listViewOpenSell;
        private System.Windows.Forms.ListView listViewOpenBuy;
        private System.Windows.Forms.Label labelValueBalance;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.Label labelTransactions;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Label labelOrderId;
    }
}