namespace Winform.FullstackII.Forms
{
    partial class ProductsForm
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
            txtStock = new TextBox();
            label2 = new Label();
            lblUser = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtProductName = new RichTextBox();
            listNote = new ListBox();
            lblTest = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(529, 211);
            txtStock.Margin = new Padding(4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(437, 26);
            txtStock.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 659);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(207, 19);
            label2.TabIndex = 10;
            label2.Text = "Giriş Yapan Kullanıcı:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(832, 659);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(63, 19);
            lblUser.TabIndex = 11;
            lblUser.Text = "label1";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(525, 449);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(441, 60);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(526, 360);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(441, 60);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(526, 271);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(441, 60);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(529, 13);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(440, 190);
            txtProductName.TabIndex = 6;
            txtProductName.Text = "";
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 19;
            listNote.Location = new Point(13, 13);
            listNote.Margin = new Padding(4);
            listNote.Name = "listNote";
            listNote.Size = new Size(476, 669);
            listNote.TabIndex = 5;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(529, 620);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(63, 19);
            lblTest.TabIndex = 13;
            lblTest.Text = "label1";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(525, 535);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(441, 60);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 706);
            Controls.Add(lblTest);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(lblUser);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(listNote);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProductsForm";
            Text = "ProductsForm";
            FormClosed += ProductsForm_FormClosed_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private Label label2;
        private Label lblUser;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private RichTextBox txtProductName;
        private ListBox listNote;
        private Label lblTest;
        private Button btnClear;
    }
}