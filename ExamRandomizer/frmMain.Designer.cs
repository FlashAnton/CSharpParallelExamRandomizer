namespace ExamRandomizer
{
    partial class frmMain
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
            this.lblTicketStatic = new System.Windows.Forms.Label();
            this.lblDynamic = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.lblNumTickets = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketStatic
            // 
            this.lblTicketStatic.AutoSize = true;
            this.lblTicketStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTicketStatic.Location = new System.Drawing.Point(12, 9);
            this.lblTicketStatic.Name = "lblTicketStatic";
            this.lblTicketStatic.Size = new System.Drawing.Size(130, 31);
            this.lblTicketStatic.TabIndex = 0;
            this.lblTicketStatic.Text = "Билет №";
            // 
            // lblDynamic
            // 
            this.lblDynamic.AutoSize = true;
            this.lblDynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDynamic.Location = new System.Drawing.Point(148, 9);
            this.lblDynamic.Name = "lblDynamic";
            this.lblDynamic.Size = new System.Drawing.Size(62, 31);
            this.lblDynamic.TabIndex = 1;
            this.lblDynamic.Text = "___";
            // 
            // numTickets
            // 
            this.numTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTickets.Location = new System.Drawing.Point(305, 52);
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(120, 38);
            this.numTickets.TabIndex = 2;
            // 
            // lblNumTickets
            // 
            this.lblNumTickets.AutoSize = true;
            this.lblNumTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumTickets.Location = new System.Drawing.Point(12, 54);
            this.lblNumTickets.Name = "lblNumTickets";
            this.lblNumTickets.Size = new System.Drawing.Size(287, 31);
            this.lblNumTickets.TabIndex = 3;
            this.lblNumTickets.Text = "Количество билетов";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartStop.Location = new System.Drawing.Point(12, 96);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(413, 50);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Запустить";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 158);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblNumTickets);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.lblDynamic);
            this.Controls.Add(this.lblTicketStatic);
            this.Name = "frmMain";
            this.Text = "Экзаменационный рандомайзер";
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketStatic;
        private System.Windows.Forms.Label lblDynamic;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Label lblNumTickets;
        private System.Windows.Forms.Button btnStartStop;
    }
}

