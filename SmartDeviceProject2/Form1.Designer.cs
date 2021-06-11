namespace SmartDeviceProject2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWhite = new System.Windows.Forms.LinkLabel();
            this.btnBlack = new System.Windows.Forms.LinkLabel();
            this.btnViolet = new System.Windows.Forms.LinkLabel();
            this.btnBlue = new System.Windows.Forms.LinkLabel();
            this.btnCyan = new System.Windows.Forms.LinkLabel();
            this.btnGreen = new System.Windows.Forms.LinkLabel();
            this.btnYellow = new System.Windows.Forms.LinkLabel();
            this.btnOrange = new System.Windows.Forms.LinkLabel();
            this.btnRed = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 420);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnWhite);
            this.panel2.Controls.Add(this.btnBlack);
            this.panel2.Controls.Add(this.btnViolet);
            this.panel2.Controls.Add(this.btnBlue);
            this.panel2.Controls.Add(this.btnCyan);
            this.panel2.Controls.Add(this.btnGreen);
            this.panel2.Controls.Add(this.btnYellow);
            this.panel2.Controls.Add(this.btnOrange);
            this.panel2.Controls.Add(this.btnRed);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 32);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnWhite.ForeColor = System.Drawing.Color.Black;
            this.btnWhite.Location = new System.Drawing.Point(211, 5);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(20, 20);
            this.btnWhite.TabIndex = 4;
            this.btnWhite.TabStop = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBlack.ForeColor = System.Drawing.Color.White;
            this.btnBlack.Location = new System.Drawing.Point(185, 5);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(20, 20);
            this.btnBlack.TabIndex = 4;
            this.btnBlack.Text = "√";
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnViolet
            // 
            this.btnViolet.BackColor = System.Drawing.Color.DarkViolet;
            this.btnViolet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnViolet.ForeColor = System.Drawing.Color.White;
            this.btnViolet.Location = new System.Drawing.Point(159, 5);
            this.btnViolet.Name = "btnViolet";
            this.btnViolet.Size = new System.Drawing.Size(20, 20);
            this.btnViolet.TabIndex = 4;
            this.btnViolet.TabStop = false;
            this.btnViolet.Click += new System.EventHandler(this.btnViolet_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBlue.ForeColor = System.Drawing.Color.White;
            this.btnBlue.Location = new System.Drawing.Point(133, 5);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(20, 20);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.TabStop = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = System.Drawing.Color.Cyan;
            this.btnCyan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCyan.ForeColor = System.Drawing.Color.Black;
            this.btnCyan.Location = new System.Drawing.Point(107, 5);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(20, 20);
            this.btnCyan.TabIndex = 4;
            this.btnCyan.TabStop = false;
            this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGreen.ForeColor = System.Drawing.Color.Black;
            this.btnGreen.Location = new System.Drawing.Point(81, 5);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(20, 20);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.TabStop = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnYellow.ForeColor = System.Drawing.Color.Black;
            this.btnYellow.Location = new System.Drawing.Point(55, 5);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(20, 20);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.TabStop = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrange.ForeColor = System.Drawing.Color.Black;
            this.btnOrange.Location = new System.Drawing.Point(29, 5);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(20, 20);
            this.btnOrange.TabIndex = 4;
            this.btnOrange.TabStop = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRed.ForeColor = System.Drawing.Color.Black;
            this.btnRed.Location = new System.Drawing.Point(3, 5);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(20, 20);
            this.btnRed.TabIndex = 4;
            this.btnRed.TabStop = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(237, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "一键清屏";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(574, 420);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "画板";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel btnOrange;
        private System.Windows.Forms.LinkLabel btnRed;
        private System.Windows.Forms.LinkLabel btnBlue;
        private System.Windows.Forms.LinkLabel btnGreen;
        private System.Windows.Forms.LinkLabel btnYellow;
        private System.Windows.Forms.LinkLabel btnWhite;
        private System.Windows.Forms.LinkLabel btnBlack;
        private System.Windows.Forms.LinkLabel btnViolet;
        private System.Windows.Forms.LinkLabel btnCyan;
    }
}

