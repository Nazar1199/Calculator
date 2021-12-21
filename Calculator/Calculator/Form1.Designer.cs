namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.plusBt = new System.Windows.Forms.Button();
            this.minusBt = new System.Windows.Forms.Button();
            this.myltipleBt = new System.Windows.Forms.Button();
            this.divideBt = new System.Windows.Forms.Button();
            this.oneBt = new System.Windows.Forms.Button();
            this.fourBt = new System.Windows.Forms.Button();
            this.twoBt = new System.Windows.Forms.Button();
            this.threeBt = new System.Windows.Forms.Button();
            this.removeBackBt = new System.Windows.Forms.Button();
            this.zeroBt = new System.Windows.Forms.Button();
            this.clearBt = new System.Windows.Forms.Button();
            this.calculateBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.ForeColor = System.Drawing.SystemColors.Window;
            this.inputBox.Location = new System.Drawing.Point(96, 77);
            this.inputBox.MaxLength = 10;
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inputBox.Size = new System.Drawing.Size(166, 31);
            this.inputBox.TabIndex = 0;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Input number";
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputBox.WordWrap = false;
            // 
            // plusBt
            // 
            this.plusBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plusBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBt.ForeColor = System.Drawing.SystemColors.Control;
            this.plusBt.Location = new System.Drawing.Point(222, 153);
            this.plusBt.Name = "plusBt";
            this.plusBt.Size = new System.Drawing.Size(40, 40);
            this.plusBt.TabIndex = 1;
            this.plusBt.Text = "+";
            this.plusBt.UseVisualStyleBackColor = false;
            this.plusBt.Click += new System.EventHandler(this.plusBt_Click);
            // 
            // minusBt
            // 
            this.minusBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minusBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBt.ForeColor = System.Drawing.SystemColors.Control;
            this.minusBt.Location = new System.Drawing.Point(222, 114);
            this.minusBt.Name = "minusBt";
            this.minusBt.Size = new System.Drawing.Size(40, 40);
            this.minusBt.TabIndex = 1;
            this.minusBt.Text = "-";
            this.minusBt.UseVisualStyleBackColor = false;
            this.minusBt.Click += new System.EventHandler(this.minusBt_Click);
            // 
            // myltipleBt
            // 
            this.myltipleBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myltipleBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myltipleBt.ForeColor = System.Drawing.SystemColors.Control;
            this.myltipleBt.Location = new System.Drawing.Point(180, 114);
            this.myltipleBt.Name = "myltipleBt";
            this.myltipleBt.Size = new System.Drawing.Size(40, 40);
            this.myltipleBt.TabIndex = 1;
            this.myltipleBt.Text = "*";
            this.myltipleBt.UseVisualStyleBackColor = false;
            this.myltipleBt.Click += new System.EventHandler(this.myltipleBt_Click);
            // 
            // divideBt
            // 
            this.divideBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.divideBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideBt.ForeColor = System.Drawing.SystemColors.Control;
            this.divideBt.Location = new System.Drawing.Point(138, 114);
            this.divideBt.Name = "divideBt";
            this.divideBt.Size = new System.Drawing.Size(40, 40);
            this.divideBt.TabIndex = 1;
            this.divideBt.Text = "/";
            this.divideBt.UseVisualStyleBackColor = false;
            this.divideBt.Click += new System.EventHandler(this.divideBt_Click);
            // 
            // oneBt
            // 
            this.oneBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oneBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneBt.ForeColor = System.Drawing.SystemColors.Control;
            this.oneBt.Location = new System.Drawing.Point(138, 153);
            this.oneBt.Name = "oneBt";
            this.oneBt.Size = new System.Drawing.Size(40, 40);
            this.oneBt.TabIndex = 1;
            this.oneBt.Text = "1";
            this.oneBt.UseVisualStyleBackColor = false;
            this.oneBt.Click += new System.EventHandler(this.oneBt_Click);
            // 
            // fourBt
            // 
            this.fourBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fourBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourBt.ForeColor = System.Drawing.SystemColors.Control;
            this.fourBt.Location = new System.Drawing.Point(138, 192);
            this.fourBt.Name = "fourBt";
            this.fourBt.Size = new System.Drawing.Size(40, 40);
            this.fourBt.TabIndex = 1;
            this.fourBt.Text = "4";
            this.fourBt.UseVisualStyleBackColor = false;
            this.fourBt.Click += new System.EventHandler(this.fourBt_Click);
            // 
            // twoBt
            // 
            this.twoBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.twoBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoBt.ForeColor = System.Drawing.SystemColors.Control;
            this.twoBt.Location = new System.Drawing.Point(179, 153);
            this.twoBt.Name = "twoBt";
            this.twoBt.Size = new System.Drawing.Size(40, 40);
            this.twoBt.TabIndex = 1;
            this.twoBt.Text = "2";
            this.twoBt.UseVisualStyleBackColor = false;
            this.twoBt.Click += new System.EventHandler(this.twoBt_Click);
            // 
            // threeBt
            // 
            this.threeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.threeBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeBt.ForeColor = System.Drawing.SystemColors.Control;
            this.threeBt.Location = new System.Drawing.Point(96, 192);
            this.threeBt.Name = "threeBt";
            this.threeBt.Size = new System.Drawing.Size(40, 40);
            this.threeBt.TabIndex = 1;
            this.threeBt.Text = "3";
            this.threeBt.UseVisualStyleBackColor = false;
            this.threeBt.Click += new System.EventHandler(this.threeBt_Click);
            // 
            // removeBackBt
            // 
            this.removeBackBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeBackBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeBackBt.ForeColor = System.Drawing.SystemColors.Control;
            this.removeBackBt.Location = new System.Drawing.Point(278, 73);
            this.removeBackBt.Name = "removeBackBt";
            this.removeBackBt.Size = new System.Drawing.Size(40, 40);
            this.removeBackBt.TabIndex = 1;
            this.removeBackBt.Text = "←";
            this.removeBackBt.UseVisualStyleBackColor = false;
            this.removeBackBt.Click += new System.EventHandler(this.removeBackBt_Click);
            // 
            // zeroBt
            // 
            this.zeroBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zeroBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroBt.ForeColor = System.Drawing.SystemColors.Control;
            this.zeroBt.Location = new System.Drawing.Point(96, 153);
            this.zeroBt.Name = "zeroBt";
            this.zeroBt.Size = new System.Drawing.Size(40, 40);
            this.zeroBt.TabIndex = 1;
            this.zeroBt.Text = "0";
            this.zeroBt.UseVisualStyleBackColor = false;
            this.zeroBt.Click += new System.EventHandler(this.zeroBt_Click);
            // 
            // clearBt
            // 
            this.clearBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBt.ForeColor = System.Drawing.SystemColors.Control;
            this.clearBt.Location = new System.Drawing.Point(96, 114);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(40, 40);
            this.clearBt.TabIndex = 1;
            this.clearBt.Text = "C";
            this.clearBt.UseVisualStyleBackColor = false;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // calculateBt
            // 
            this.calculateBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(130)))));
            this.calculateBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateBt.ForeColor = System.Drawing.SystemColors.Control;
            this.calculateBt.Location = new System.Drawing.Point(179, 192);
            this.calculateBt.Name = "calculateBt";
            this.calculateBt.Size = new System.Drawing.Size(83, 40);
            this.calculateBt.TabIndex = 2;
            this.calculateBt.Text = "=";
            this.calculateBt.UseVisualStyleBackColor = false;
            this.calculateBt.Click += new System.EventHandler(this.calculateBt_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Калькулятор 5-ричной системы счисления\r\nИгнатенко Н.А. ИСТ-Tb31";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(397, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateBt);
            this.Controls.Add(this.zeroBt);
            this.Controls.Add(this.fourBt);
            this.Controls.Add(this.removeBackBt);
            this.Controls.Add(this.divideBt);
            this.Controls.Add(this.threeBt);
            this.Controls.Add(this.myltipleBt);
            this.Controls.Add(this.twoBt);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.oneBt);
            this.Controls.Add(this.minusBt);
            this.Controls.Add(this.plusBt);
            this.Controls.Add(this.inputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button plusBt;
        private System.Windows.Forms.Button minusBt;
        private System.Windows.Forms.Button myltipleBt;
        private System.Windows.Forms.Button divideBt;
        private System.Windows.Forms.Button oneBt;
        private System.Windows.Forms.Button fourBt;
        private System.Windows.Forms.Button twoBt;
        private System.Windows.Forms.Button threeBt;
        private System.Windows.Forms.Button removeBackBt;
        private System.Windows.Forms.Button zeroBt;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Button calculateBt;
        private System.Windows.Forms.Label label1;
    }
}

