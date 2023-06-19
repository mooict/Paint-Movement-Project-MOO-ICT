namespace Paint_Movement_Project_MOO_ICT
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
            this.components = new System.ComponentModel.Container();
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MovementTimer
            // 
            this.MovementTimer.Enabled = true;
            this.MovementTimer.Interval = 20;
            this.MovementTimer.Tick += new System.EventHandler(this.MovementTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paint_Movement_Project_MOO_ICT.Properties.Resources.mechanical_keyboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Paint Movement Project MOO ICT";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MovementTimer;
    }
}