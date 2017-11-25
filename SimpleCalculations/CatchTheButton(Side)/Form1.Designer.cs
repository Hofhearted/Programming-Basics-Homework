namespace CatchTheButton_Side_
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
            this.catchmebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catchmebutton
            // 
            this.catchmebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchmebutton.Location = new System.Drawing.Point(224, 91);
            this.catchmebutton.Name = "catchmebutton";
            this.catchmebutton.Size = new System.Drawing.Size(120, 70);
            this.catchmebutton.TabIndex = 0;
            this.catchmebutton.Text = "Catch Me!";
            this.catchmebutton.UseVisualStyleBackColor = true;
            this.catchmebutton.Click += new System.EventHandler(this.catchmebutton_Click);
            this.catchmebutton.MouseHover += new System.EventHandler(this.catchmebutton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.catchmebutton);
            this.Name = "Form1";
            this.Text = "Catch the Button!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catchmebutton;
    }
}

