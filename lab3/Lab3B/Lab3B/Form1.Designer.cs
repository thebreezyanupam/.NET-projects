namespace Lab3B
{
    partial class Form1
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
            this.cb_hairdresser = new System.Windows.Forms.ComboBox();
            this.lb_service = new System.Windows.Forms.ListBox();
            this.lb_chargedItems = new System.Windows.Forms.ListBox();
            this.lb_Prices = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_AddServices = new System.Windows.Forms.Button();
            this.btn_CalculateTotalPrice = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_hairdresser
            // 
            this.cb_hairdresser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hairdresser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hairdresser.FormattingEnabled = true;
            this.cb_hairdresser.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laurie Renkins"});
            this.cb_hairdresser.Location = new System.Drawing.Point(7, 20);
            this.cb_hairdresser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_hairdresser.Name = "cb_hairdresser";
            this.cb_hairdresser.Size = new System.Drawing.Size(140, 25);
            this.cb_hairdresser.TabIndex = 0;
            // 
            // lb_service
            // 
            this.lb_service.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_service.FormattingEnabled = true;
            this.lb_service.ItemHeight = 21;
            this.lb_service.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.lb_service.Location = new System.Drawing.Point(7, 19);
            this.lb_service.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lb_service.Name = "lb_service";
            this.lb_service.Size = new System.Drawing.Size(258, 193);
            this.lb_service.TabIndex = 1;
            this.lb_service.SelectedIndexChanged += new System.EventHandler(this.lb_service_SelectedIndexChanged);
            // 
            // lb_chargedItems
            // 
            this.lb_chargedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chargedItems.FormattingEnabled = true;
            this.lb_chargedItems.ItemHeight = 20;
            this.lb_chargedItems.Location = new System.Drawing.Point(7, 19);
            this.lb_chargedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lb_chargedItems.Name = "lb_chargedItems";
            this.lb_chargedItems.Size = new System.Drawing.Size(245, 224);
            this.lb_chargedItems.TabIndex = 2;
            // 
            // lb_Prices
            // 
            this.lb_Prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Prices.FormattingEnabled = true;
            this.lb_Prices.ItemHeight = 20;
            this.lb_Prices.Location = new System.Drawing.Point(7, 19);
            this.lb_Prices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lb_Prices.Name = "lb_Prices";
            this.lb_Prices.Size = new System.Drawing.Size(180, 224);
            this.lb_Prices.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_hairdresser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(164, 266);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_service);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(186, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(273, 265);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_chargedItems);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(465, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(260, 265);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_Prices);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(733, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(202, 265);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // btn_AddServices
            // 
            this.btn_AddServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddServices.Location = new System.Drawing.Point(59, 388);
            this.btn_AddServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_AddServices.Name = "btn_AddServices";
            this.btn_AddServices.Size = new System.Drawing.Size(210, 34);
            this.btn_AddServices.TabIndex = 9;
            this.btn_AddServices.Text = "Add Service";
            this.btn_AddServices.UseVisualStyleBackColor = true;
            this.btn_AddServices.Click += new System.EventHandler(this.btn_ClickAddServices);
            // 
            // btn_CalculateTotalPrice
            // 
            this.btn_CalculateTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalculateTotalPrice.Location = new System.Drawing.Point(276, 388);
            this.btn_CalculateTotalPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CalculateTotalPrice.Name = "btn_CalculateTotalPrice";
            this.btn_CalculateTotalPrice.Size = new System.Drawing.Size(210, 34);
            this.btn_CalculateTotalPrice.TabIndex = 10;
            this.btn_CalculateTotalPrice.Text = "Calculate Total Price";
            this.btn_CalculateTotalPrice.UseVisualStyleBackColor = true;
            this.btn_CalculateTotalPrice.Click += new System.EventHandler(this.btn_ClickCalculateTotalPrice);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(493, 388);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_ClickReset);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(710, 388);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_ClickExit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total Price: ";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPrice.Location = new System.Drawing.Point(776, 315);
            this.label_TotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Padding = new System.Windows.Forms.Padding(2);
            this.label_TotalPrice.Size = new System.Drawing.Size(129, 34);
            this.label_TotalPrice.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_CalculateTotalPrice);
            this.Controls.Add(this.btn_AddServices);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.HairSalon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_hairdresser;
        private System.Windows.Forms.ListBox lb_service;
        private System.Windows.Forms.ListBox lb_chargedItems;
        private System.Windows.Forms.ListBox lb_Prices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_AddServices;
        private System.Windows.Forms.Button btn_CalculateTotalPrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TotalPrice;
    }
}

