namespace Winform.FullstackII.Forms
{
    partial class NavigationForm
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
            btnProduct = new Button();
            btnNote = new Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(12, 12);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(489, 88);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Ürün Listesi";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnNote
            // 
            btnNote.Location = new Point(12, 106);
            btnNote.Name = "btnNote";
            btnNote.Size = new Size(489, 93);
            btnNote.TabIndex = 1;
            btnNote.Text = "Özlü Sözler";
            btnNote.UseVisualStyleBackColor = true;
            btnNote.Click += btnNote_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 220);
            Controls.Add(btnNote);
            Controls.Add(btnProduct);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "NavigationForm";
            Text = "NavigationForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduct;
        private Button btnNote;
    }
}