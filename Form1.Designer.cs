namespace PrjArraySimples1
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
            txtBox = new TextBox();
            btn = new Button();
            lbl = new Label();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Location = new Point(23, 91);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(125, 27);
            txtBox.TabIndex = 0;
            // 
            // btn
            // 
            btn.Location = new Point(23, 146);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 1;
            btn.Text = "Rodar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(16, 48);
            lbl.Name = "lbl";
            lbl.Size = new Size(231, 20);
            lbl.TabIndex = 2;
            lbl.Text = "Números cadastrados: 99, 73 e 27";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 472);
            Controls.Add(lbl);
            Controls.Add(btn);
            Controls.Add(txtBox);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btn;
        private Label lbl;
    }
}
