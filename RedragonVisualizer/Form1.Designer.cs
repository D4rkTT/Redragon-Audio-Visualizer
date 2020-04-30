namespace RedragonVisualizer
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
            this.Start_VisualizerBTN = new System.Windows.Forms.Button();
            this.VisualizerSync = new System.ComponentModel.BackgroundWorker();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.APPcontrolbar = new System.Windows.Forms.Panel();
            this.APPnamelbl = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.MousePic = new System.Windows.Forms.PictureBox();
            this.APPcontrolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MousePic)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_VisualizerBTN
            // 
            this.Start_VisualizerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.Start_VisualizerBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_VisualizerBTN.FlatAppearance.BorderSize = 0;
            this.Start_VisualizerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_VisualizerBTN.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_VisualizerBTN.ForeColor = System.Drawing.Color.White;
            this.Start_VisualizerBTN.Location = new System.Drawing.Point(29, 374);
            this.Start_VisualizerBTN.Name = "Start_VisualizerBTN";
            this.Start_VisualizerBTN.Size = new System.Drawing.Size(267, 47);
            this.Start_VisualizerBTN.TabIndex = 0;
            this.Start_VisualizerBTN.Text = "Start";
            this.Start_VisualizerBTN.UseVisualStyleBackColor = false;
            this.Start_VisualizerBTN.Click += new System.EventHandler(this.Start_VisualizerBTN_Click);
            // 
            // VisualizerSync
            // 
            this.VisualizerSync.WorkerReportsProgress = true;
            this.VisualizerSync.WorkerSupportsCancellation = true;
            this.VisualizerSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.VisualizerSync_DoWork);
            // 
            // APPcontrolbar
            // 
            this.APPcontrolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.APPcontrolbar.Controls.Add(this.APPnamelbl);
            this.APPcontrolbar.Controls.Add(this.btnMinimize);
            this.APPcontrolbar.Controls.Add(this.btnExit);
            this.APPcontrolbar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.APPcontrolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.APPcontrolbar.Location = new System.Drawing.Point(0, 0);
            this.APPcontrolbar.Name = "APPcontrolbar";
            this.APPcontrolbar.Size = new System.Drawing.Size(621, 28);
            this.APPcontrolbar.TabIndex = 10;
            this.APPcontrolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseDown);
            this.APPcontrolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseMove);
            this.APPcontrolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseUp);
            // 
            // APPnamelbl
            // 
            this.APPnamelbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.APPnamelbl.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPnamelbl.ForeColor = System.Drawing.Color.White;
            this.APPnamelbl.Location = new System.Drawing.Point(0, 0);
            this.APPnamelbl.Name = "APPnamelbl";
            this.APPnamelbl.Size = new System.Drawing.Size(379, 28);
            this.APPnamelbl.TabIndex = 2;
            this.APPnamelbl.Text = "  Redragon M711 Cobra Music Visualizer";
            this.APPnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.APPnamelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseDown);
            this.APPnamelbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseMove);
            this.APPnamelbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(553, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 28);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(587, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Effect Color: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Redragon M711 Cobra Music Visualizer";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Developed By: DarkT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Use it at you own risk";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Version: 1.0.0.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(201, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(Github)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.Color.Red;
            this.ColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorBox.Location = new System.Drawing.Point(129, 318);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(167, 26);
            this.ColorBox.TabIndex = 2;
            this.ColorBox.TabStop = false;
            this.ColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            // 
            // MousePic
            // 
            this.MousePic.BackColor = System.Drawing.Color.Black;
            this.MousePic.Image = global::RedragonVisualizer.Properties.Resources.Cobra2;
            this.MousePic.Location = new System.Drawing.Point(302, 0);
            this.MousePic.Name = "MousePic";
            this.MousePic.Size = new System.Drawing.Size(323, 465);
            this.MousePic.TabIndex = 1;
            this.MousePic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(621, 451);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APPcontrolbar);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.MousePic);
            this.Controls.Add(this.Start_VisualizerBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "  Redragon M711 Cobra Music Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.APPcontrolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MousePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_VisualizerBTN;
        private System.ComponentModel.BackgroundWorker VisualizerSync;
        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.PictureBox MousePic;
        internal System.Windows.Forms.Panel APPcontrolbar;
        internal System.Windows.Forms.Label APPnamelbl;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

