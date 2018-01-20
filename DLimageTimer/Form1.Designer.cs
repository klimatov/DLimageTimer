namespace DLimageTimer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FnameLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.IntervalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 600000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(13, 9);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(128, 13);
            this.TimeLbl.TabIndex = 1;
            this.TimeLbl.Text = "Последнее сохранение:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FnameLbl
            // 
            this.FnameLbl.AutoSize = true;
            this.FnameLbl.Location = new System.Drawing.Point(13, 22);
            this.FnameLbl.Name = "FnameLbl";
            this.FnameLbl.Size = new System.Drawing.Size(129, 13);
            this.FnameLbl.TabIndex = 3;
            this.FnameLbl.Text = "Имя последнего файла:";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLbl.Location = new System.Drawing.Point(249, 68);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(122, 26);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "ПИШЕМ!!!";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Image Downloader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // IntervalLbl
            // 
            this.IntervalLbl.AutoSize = true;
            this.IntervalLbl.Location = new System.Drawing.Point(13, 35);
            this.IntervalLbl.Name = "IntervalLbl";
            this.IntervalLbl.Size = new System.Drawing.Size(98, 13);
            this.IntervalLbl.TabIndex = 5;
            this.IntervalLbl.Text = "Интервал (минут):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 112);
            this.Controls.Add(this.IntervalLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.FnameLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Downloader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label FnameLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label IntervalLbl;
    }
}

