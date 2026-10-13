namespace VERIFICA_DI_RIPASSO_C_
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
            listBoxfrasi = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxfrasi
            // 
            listBoxfrasi.FormattingEnabled = true;
            listBoxfrasi.ItemHeight = 15;
            listBoxfrasi.Location = new Point(495, 59);
            listBoxfrasi.Name = "listBoxfrasi";
            listBoxfrasi.Size = new Size(198, 199);
            listBoxfrasi.TabIndex = 0;
            listBoxfrasi.SelectedIndexChanged += listBoxfrasi_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(308, 131);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 1;
            button1.Text = "decifra la frase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBoxfrasi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxfrasi;
        private Button button1;
    }
}
