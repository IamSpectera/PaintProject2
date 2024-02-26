
namespace Paint
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
            rectButton = new RadioButton();
            circButton = new RadioButton();
            triButton = new RadioButton();
            btnColor = new RadioButton();
            clearbutton = new Button();
            freedraw = new RadioButton();
            SuspendLayout();
            // 
            // rectButton
            // 
            rectButton.AutoSize = true;
            rectButton.BackColor = SystemColors.MenuHighlight;
            rectButton.Location = new Point(12, 419);
            rectButton.Name = "rectButton";
            rectButton.Size = new Size(77, 19);
            rectButton.TabIndex = 0;
            rectButton.TabStop = true;
            rectButton.Text = "Rectangle";
            rectButton.UseVisualStyleBackColor = false;
            rectButton.CheckedChanged += rectButton_CheckedChanged;
            // 
            // circButton
            // 
            circButton.AutoSize = true;
            circButton.BackColor = SystemColors.MenuHighlight;
            circButton.Location = new Point(114, 419);
            circButton.Name = "circButton";
            circButton.Size = new Size(55, 19);
            circButton.TabIndex = 1;
            circButton.TabStop = true;
            circButton.Text = "Circle";
            circButton.UseVisualStyleBackColor = false;
            circButton.CheckedChanged += circButton_CheckedChanged;
            // 
            // triButton
            // 
            triButton.AutoSize = true;
            triButton.BackColor = SystemColors.MenuHighlight;
            triButton.Location = new Point(186, 419);
            triButton.Name = "triButton";
            triButton.Size = new Size(66, 19);
            triButton.TabIndex = 2;
            triButton.TabStop = true;
            triButton.Text = "Triangle";
            triButton.UseVisualStyleBackColor = false;
            triButton.CheckedChanged += triButton_CheckedChanged;
            // 
            // btnColor
            // 
            btnColor.AutoSize = true;
            btnColor.BackColor = SystemColors.MenuHighlight;
            btnColor.Location = new Point(272, 419);
            btnColor.Margin = new Padding(3, 2, 3, 2);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(54, 19);
            btnColor.TabIndex = 3;
            btnColor.TabStop = true;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = false;
            btnColor.CheckedChanged += btnColor_CheckedChanged_1;
            btnColor.Click += btnColor_Click;
            // 
            // clearbutton
            // 
            clearbutton.BackColor = Color.Red;
            clearbutton.Location = new Point(453, 419);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(127, 25);
            clearbutton.TabIndex = 5;
            clearbutton.Text = "Reset";
            clearbutton.UseVisualStyleBackColor = false;
            clearbutton.Click += clearbutton_Click;
            // 
            // freedraw
            // 
            freedraw.AutoSize = true;
            freedraw.BackColor = SystemColors.MenuHighlight;
            freedraw.Location = new Point(342, 419);
            freedraw.Name = "freedraw";
            freedraw.Size = new Size(77, 19);
            freedraw.TabIndex = 6;
            freedraw.TabStop = true;
            freedraw.Text = "Free Draw";
            freedraw.UseVisualStyleBackColor = false;
            freedraw.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(freedraw);
            Controls.Add(clearbutton);
            Controls.Add(btnColor);
            Controls.Add(triButton);
            Controls.Add(circButton);
            Controls.Add(rectButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        /*private void triButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void triButton_CheckedChanged(object sender, EventArgs e)
            {
               // Remove the NotImplementedException() call and leave the method empty
            }


        #endregion

        private RadioButton rectButton;
        private RadioButton circButton;
        private RadioButton triButton;
        private RadioButton btnColor;
        private Button clearbutton;
        private RadioButton freedraw;
    }
}
