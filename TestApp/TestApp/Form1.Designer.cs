namespace TestApp {
    partial class mainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.firstBox = new System.Windows.Forms.TextBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstBox
            // 
            this.firstBox.AcceptsTab = true;
            this.firstBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstBox.Location = new System.Drawing.Point(12, 54);
            this.firstBox.MaxLength = 5;
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(600, 20);
            this.firstBox.TabIndex = 0;
            this.firstBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstBox.TextChanged += new System.EventHandler(this.firstBox_TextChanged);
            // 
            // progBar
            // 
            this.progBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progBar.Location = new System.Drawing.Point(12, 406);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(600, 23);
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "First numer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // secondBox
            // 
            this.secondBox.AcceptsTab = true;
            this.secondBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondBox.Location = new System.Drawing.Point(12, 132);
            this.secondBox.MaxLength = 5;
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(600, 20);
            this.secondBox.TabIndex = 0;
            this.secondBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second numer";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.result.Cursor = System.Windows.Forms.Cursors.No;
            this.result.Location = new System.Drawing.Point(238, 380);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(148, 20);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "RESULT";
            // 
            // labelPlus
            // 
            this.labelPlus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPlus.AutoSize = true;
            this.labelPlus.BackColor = System.Drawing.Color.Transparent;
            this.labelPlus.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlus.Location = new System.Drawing.Point(5, 85);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(40, 42);
            this.labelPlus.TabIndex = 5;
            this.labelPlus.Text = "+";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 143);
            this.button1.TabIndex = 6;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.firstBox);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "mainWindow";
            this.Text = "Zdr denis :)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Button button1;
    }
}

