namespace Client
{
    partial class SmallWindow2
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
            btnSave = new Button();
            label7 = new Label();
            txtColor = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtVin = new TextBox();
            txtYear = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(59, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(217, 23);
            btnSave.TabIndex = 27;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Yu Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(12, 232);
            label7.Name = "label7";
            label7.Size = new Size(63, 29);
            label7.TabIndex = 26;
            label7.Text = "Color :";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(98, 238);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(235, 23);
            txtColor.TabIndex = 25;
            // 
            // label6
            // 
            label6.Font = new Font("Yu Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(12, 143);
            label6.Name = "label6";
            label6.Size = new Size(63, 29);
            label6.TabIndex = 24;
            label6.Text = "Year :";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(63, 29);
            label5.TabIndex = 23;
            label5.Text = "VIN :";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(63, 29);
            label3.TabIndex = 22;
            label3.Text = "Make :";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(63, 29);
            label2.TabIndex = 21;
            label2.Text = "Model :";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(98, 61);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(235, 23);
            txtMake.TabIndex = 20;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(98, 105);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(235, 23);
            txtModel.TabIndex = 19;
            // 
            // txtVin
            // 
            txtVin.Location = new Point(98, 195);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(235, 23);
            txtVin.TabIndex = 18;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(98, 149);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(235, 23);
            txtYear.TabIndex = 17;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic", 16F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 29);
            label1.TabIndex = 16;
            label1.Text = "Update Car";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // SmallWindow2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 331);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(txtColor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMake);
            Controls.Add(txtModel);
            Controls.Add(txtVin);
            Controls.Add(txtYear);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SmallWindow2";
            Text = "UpdateWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label7;
        private TextBox txtColor;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtVin;
        private TextBox txtYear;
        private Label label1;
    }
}