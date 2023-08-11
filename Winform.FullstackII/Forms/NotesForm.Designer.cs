namespace Winform.FullstackII
{
    partial class NotesForm
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
            listNote = new ListBox();
            txtNote = new RichTextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblUser = new Label();
            label2 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 22;
            listNote.Location = new Point(12, 12);
            listNote.Name = "listNote";
            listNote.Size = new Size(371, 532);
            listNote.TabIndex = 0;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged_1;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(413, 12);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(343, 151);
            txtNote.TabIndex = 1;
            txtNote.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(411, 216);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(343, 64);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(411, 286);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(343, 64);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(411, 356);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(343, 64);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(649, 522);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 22);
            lblUser.TabIndex = 3;
            lblUser.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 522);
            label2.Name = "label2";
            label2.Size = new Size(230, 22);
            label2.TabIndex = 3;
            label2.Text = "Giriş Yapan Kullanıcı:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(413, 440);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(343, 60);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 566);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(lblUser);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtNote);
            Controls.Add(listNote);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "NotesForm";
            Text = "Form1";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listNote;
        private RichTextBox txtNote;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblUser;
        private Label label2;
        private Button btnClear;
    }
}