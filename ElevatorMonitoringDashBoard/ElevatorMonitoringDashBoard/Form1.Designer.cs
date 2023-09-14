namespace ElevatorMonitoringDashBoard
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
            this.data_tb = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.port_name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.value_tb = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verticalProgressbar_sound = new ElevatorMonitoringDashBoard.VerticalProgressbar();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_sound = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(505, 46);
            this.data_tb.Multiline = true;
            this.data_tb.Name = "data_tb";
            this.data_tb.Size = new System.Drawing.Size(327, 334);
            this.data_tb.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(21, 126);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(185, 71);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(21, 203);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(185, 71);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(21, 280);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(185, 71);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save Data";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // port_name_tb
            // 
            this.port_name_tb.Location = new System.Drawing.Point(76, 49);
            this.port_name_tb.Name = "port_name_tb";
            this.port_name_tb.Size = new System.Drawing.Size(95, 20);
            this.port_name_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port Name :";
            // 
            // value_tb
            // 
            this.value_tb.Location = new System.Drawing.Point(505, 397);
            this.value_tb.Name = "value_tb";
            this.value_tb.Size = new System.Drawing.Size(327, 21);
            this.value_tb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IR Sensor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "1023";
            // 
            // verticalProgressbar_sound
            // 
            this.verticalProgressbar_sound.Location = new System.Drawing.Point(419, 49);
            this.verticalProgressbar_sound.Name = "verticalProgressbar_sound";
            this.verticalProgressbar_sound.Size = new System.Drawing.Size(35, 331);
            this.verticalProgressbar_sound.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sound Sensor :";
            // 
            // textBox_sound
            // 
            this.textBox_sound.Location = new System.Drawing.Point(419, 397);
            this.textBox_sound.Name = "textBox_sound";
            this.textBox_sound.Size = new System.Drawing.Size(35, 20);
            this.textBox_sound.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 617);
            this.Controls.Add(this.textBox_sound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.verticalProgressbar_sound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_name_tb);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.data_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_tb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox port_name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar value_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private VerticalProgressbar verticalProgressbar_sound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_sound;
    }
}

