namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            btnGet = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(443, 388);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(28, 406);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(443, 23);
            btnGet.TabIndex = 1;
            btnGet.Text = "GetAll";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += button_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(28, 435);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(443, 23);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += button_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 464);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(443, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(28, 493);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(443, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 528);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(btnGet);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Click += button_Click;
            ResumeLayout(false);
        }

        #endregion
        private Button btnGet;
        private Button btnDel;
        private Button btnAdd;
        private Button btnUpdate;
        private ListView listView1;
    }
}