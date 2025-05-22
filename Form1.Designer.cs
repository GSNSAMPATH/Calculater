namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button[] buttons;
        private System.Windows.Forms.Panel panelButtonPad;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            this.components = new System.ComponentModel.Container();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttons = new System.Windows.Forms.Button[16];
            this.panelButtonPad = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // textBoxDisplay
            this.textBoxDisplay.Location = new System.Drawing.Point(10, 10);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(280, 50);
            this.textBoxDisplay.Font = new System.Drawing.Font("Arial", 14);
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Multiline = true; // Enable multi-line
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;


            // Create Buttons (0-9, +, -, *, /, =, C)
            string[] buttonLabels = { "7", "8", "9", "/",
                                      "4", "5", "6", "*",
                                      "1", "2", "3", "-",
                                      "C", "0", "=", "+" };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new System.Windows.Forms.Button();
                buttons[i].Text = buttonLabels[i];
                buttons[i].Size = new System.Drawing.Size(60, 60);
                buttons[i].Font = new System.Drawing.Font("Arial", 14);
                buttons[i].Location = new System.Drawing.Point(10 + (i % 4) * 70, 20 + (i / 4) * 70);
                buttons[i].Click += new System.EventHandler(this.Button_Click);
                this.panelButtonPad.Controls.Add(buttons[i]);
            }

            // panelButtonPad
            this.panelButtonPad.Location = new System.Drawing.Point(10, 60);
            this.panelButtonPad.Name = "panelButtonPad";
            this.panelButtonPad.Size = new System.Drawing.Size(280, 300);
            this.panelButtonPad.TabIndex = 0;
    


            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.panelButtonPad);
            this.Controls.Add(this.textBoxDisplay);
            this.Text = "Calculator";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

