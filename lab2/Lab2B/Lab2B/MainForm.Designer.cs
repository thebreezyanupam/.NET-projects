using System;

namespace Lab2B
{
    partial class MainForm
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
            this.hairDresser = new System.Windows.Forms.GroupBox();
            this.radioLaura = new System.Windows.Forms.RadioButton();
            this.radioSue = new System.Windows.Forms.RadioButton();
            this.radioRon = new System.Windows.Forms.RadioButton();
            this.radioPat = new System.Windows.Forms.RadioButton();
            this.radioJane = new System.Windows.Forms.RadioButton();
            this.services = new System.Windows.Forms.GroupBox();
            this.checkExtensions = new System.Windows.Forms.CheckBox();
            this.checkHighlights = new System.Windows.Forms.CheckBox();
            this.checkColor = new System.Windows.Forms.CheckBox();
            this.checkCut = new System.Windows.Forms.CheckBox();
            this.clientType = new System.Windows.Forms.GroupBox();
            this.radioSenior = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioChild = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.clientVisits = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textClientVisits = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.hairDresser.SuspendLayout();
            this.services.SuspendLayout();
            this.clientType.SuspendLayout();
            this.clientVisits.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairDresser
            // 
            this.hairDresser.Controls.Add(this.radioLaura);
            this.hairDresser.Controls.Add(this.radioSue);
            this.hairDresser.Controls.Add(this.radioRon);
            this.hairDresser.Controls.Add(this.radioPat);
            this.hairDresser.Controls.Add(this.radioJane);
            this.hairDresser.Location = new System.Drawing.Point(12, 12);
            this.hairDresser.Name = "hairDresser";
            this.hairDresser.Size = new System.Drawing.Size(239, 279);
            this.hairDresser.TabIndex = 0;
            this.hairDresser.TabStop = false;
            this.hairDresser.Text = "HairDresser";
            this.hairDresser.Enter += new System.EventHandler(this.hairDresser_Enter);
            // 
            // radioLaura
            // 
            this.radioLaura.AutoSize = true;
            this.radioLaura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioLaura.Location = new System.Drawing.Point(7, 173);
            this.radioLaura.Name = "radioLaura";
            this.radioLaura.Size = new System.Drawing.Size(94, 17);
            this.radioLaura.TabIndex = 4;
            this.radioLaura.TabStop = true;
            this.radioLaura.Text = "Laura Renkins";
            this.radioLaura.UseVisualStyleBackColor = true;
            // 
            // radioSue
            // 
            this.radioSue.AutoSize = true;
            this.radioSue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSue.Location = new System.Drawing.Point(7, 140);
            this.radioSue.Name = "radioSue";
            this.radioSue.Size = new System.Drawing.Size(76, 17);
            this.radioSue.TabIndex = 3;
            this.radioSue.TabStop = true;
            this.radioSue.Text = "Sue Pallon";
            this.radioSue.UseVisualStyleBackColor = true;
            this.radioSue.CheckedChanged += new System.EventHandler(this.radioSue_CheckedChanged);
            // 
            // radioRon
            // 
            this.radioRon.AutoSize = true;
            this.radioRon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRon.Location = new System.Drawing.Point(7, 105);
            this.radioRon.Name = "radioRon";
            this.radioRon.Size = new System.Drawing.Size(95, 17);
            this.radioRon.TabIndex = 2;
            this.radioRon.TabStop = true;
            this.radioRon.Text = "Ron Chambers";
            this.radioRon.UseVisualStyleBackColor = true;
            // 
            // radioPat
            // 
            this.radioPat.AutoSize = true;
            this.radioPat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPat.Location = new System.Drawing.Point(7, 72);
            this.radioPat.Name = "radioPat";
            this.radioPat.Size = new System.Drawing.Size(84, 17);
            this.radioPat.TabIndex = 1;
            this.radioPat.TabStop = true;
            this.radioPat.Text = "Pat Johnson";
            this.radioPat.UseVisualStyleBackColor = true;
            // 
            // radioJane
            // 
            this.radioJane.AutoSize = true;
            this.radioJane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioJane.Location = new System.Drawing.Point(7, 37);
            this.radioJane.Name = "radioJane";
            this.radioJane.Size = new System.Drawing.Size(85, 17);
            this.radioJane.TabIndex = 0;
            this.radioJane.TabStop = true;
            this.radioJane.Text = "Jane Samley";
            this.radioJane.UseVisualStyleBackColor = true;
            // 
            // services
            // 
            this.services.Controls.Add(this.checkExtensions);
            this.services.Controls.Add(this.checkHighlights);
            this.services.Controls.Add(this.checkColor);
            this.services.Controls.Add(this.checkCut);
            this.services.Location = new System.Drawing.Point(274, 12);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(234, 212);
            this.services.TabIndex = 1;
            this.services.TabStop = false;
            this.services.Text = "Services";
            // 
            // checkExtensions
            // 
            this.checkExtensions.AutoSize = true;
            this.checkExtensions.Location = new System.Drawing.Point(7, 92);
            this.checkExtensions.Name = "checkExtensions";
            this.checkExtensions.Size = new System.Drawing.Size(77, 17);
            this.checkExtensions.TabIndex = 3;
            this.checkExtensions.Text = "Extensions";
            this.checkExtensions.UseVisualStyleBackColor = true;
            // 
            // checkHighlights
            // 
            this.checkHighlights.AutoSize = true;
            this.checkHighlights.Location = new System.Drawing.Point(7, 68);
            this.checkHighlights.Name = "checkHighlights";
            this.checkHighlights.Size = new System.Drawing.Size(72, 17);
            this.checkHighlights.TabIndex = 2;
            this.checkHighlights.Text = "Highlights";
            this.checkHighlights.UseVisualStyleBackColor = true;
            // 
            // checkColor
            // 
            this.checkColor.AutoSize = true;
            this.checkColor.Location = new System.Drawing.Point(7, 44);
            this.checkColor.Name = "checkColor";
            this.checkColor.Size = new System.Drawing.Size(50, 17);
            this.checkColor.TabIndex = 1;
            this.checkColor.Text = "Color";
            this.checkColor.UseVisualStyleBackColor = true;
            // 
            // checkCut
            // 
            this.checkCut.AutoSize = true;
            this.checkCut.Location = new System.Drawing.Point(7, 20);
            this.checkCut.Name = "checkCut";
            this.checkCut.Size = new System.Drawing.Size(42, 17);
            this.checkCut.TabIndex = 0;
            this.checkCut.Text = "Cut";
            this.checkCut.UseVisualStyleBackColor = true;
            // 
            // clientType
            // 
            this.clientType.Controls.Add(this.radioSenior);
            this.clientType.Controls.Add(this.radioStudent);
            this.clientType.Controls.Add(this.radioChild);
            this.clientType.Controls.Add(this.radioStandard);
            this.clientType.Location = new System.Drawing.Point(19, 313);
            this.clientType.Name = "clientType";
            this.clientType.Size = new System.Drawing.Size(232, 170);
            this.clientType.TabIndex = 2;
            this.clientType.TabStop = false;
            this.clientType.Text = "Client Type";
            // 
            // radioSenior
            // 
            this.radioSenior.AutoSize = true;
            this.radioSenior.Location = new System.Drawing.Point(7, 102);
            this.radioSenior.Name = "radioSenior";
            this.radioSenior.Size = new System.Drawing.Size(100, 17);
            this.radioSenior.TabIndex = 3;
            this.radioSenior.TabStop = true;
            this.radioSenior.Text = "Senior (over 65)";
            this.radioSenior.UseVisualStyleBackColor = true;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(7, 78);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(62, 17);
            this.radioStudent.TabIndex = 2;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioChild
            // 
            this.radioChild.AutoSize = true;
            this.radioChild.Location = new System.Drawing.Point(7, 54);
            this.radioChild.Name = "radioChild";
            this.radioChild.Size = new System.Drawing.Size(120, 17);
            this.radioChild.TabIndex = 1;
            this.radioChild.TabStop = true;
            this.radioChild.Text = "Child (12 and under)";
            this.radioChild.UseVisualStyleBackColor = true;
            this.radioChild.CheckedChanged += new System.EventHandler(this.radioChild_CheckedChanged);
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(7, 30);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(95, 17);
            this.radioStandard.TabIndex = 0;
            this.radioStandard.TabStop = true;
            this.radioStandard.Checked = true;
            this.radioStandard.Text = "Standard Adult";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // clientVisits
            // 
            this.clientVisits.Controls.Add(this.label1);
            this.clientVisits.Controls.Add(this.textClientVisits);
            this.clientVisits.Location = new System.Drawing.Point(274, 313);
            this.clientVisits.Name = "clientVisits";
            this.clientVisits.Size = new System.Drawing.Size(234, 120);
            this.clientVisits.TabIndex = 3;
            this.clientVisits.TabStop = false;
            this.clientVisits.Text = "Client Visits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Client Visit: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textClientVisits
            // 
            this.textClientVisits.Location = new System.Drawing.Point(23, 54);
            this.textClientVisits.Name = "textClientVisits";
            this.textClientVisits.Size = new System.Drawing.Size(176, 20);
            this.textClientVisits.TabIndex = 0;
            this.textClientVisits.TextChanged += new System.EventHandler(this.textClientVisits_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 536);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(143, 536);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(248, 536);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Price:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(98, 505);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPrice.TabIndex = 8;
            this.labelTotalPrice.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 571);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.clientVisits);
            this.Controls.Add(this.clientType);
            this.Controls.Add(this.services);
            this.Controls.Add(this.hairDresser);
            this.Name = "MainForm";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.hairDresser.ResumeLayout(false);
            this.hairDresser.PerformLayout();
            this.services.ResumeLayout(false);
            this.services.PerformLayout();
            this.clientType.ResumeLayout(false);
            this.clientType.PerformLayout();
            this.clientVisits.ResumeLayout(false);
            this.clientVisits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.GroupBox hairDresser;
        private System.Windows.Forms.GroupBox services;
        private System.Windows.Forms.GroupBox clientType;
        private System.Windows.Forms.GroupBox clientVisits;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radioLaura;
        private System.Windows.Forms.RadioButton radioSue;
        private System.Windows.Forms.RadioButton radioRon;
        private System.Windows.Forms.RadioButton radioPat;
        private System.Windows.Forms.RadioButton radioJane;
        private System.Windows.Forms.CheckBox checkExtensions;
        private System.Windows.Forms.CheckBox checkHighlights;
        private System.Windows.Forms.CheckBox checkColor;
        private System.Windows.Forms.CheckBox checkCut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioSenior;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioChild;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textClientVisits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}

