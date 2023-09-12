namespace LightApp
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
            this.data_db = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.port_name_tb = new System.Windows.Forms.TextBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verticalProgressBar_sound = new LightApp.VerticalProgressBar();
            this.textBox_Sound = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // data_db
            // 
            this.data_db.Location = new System.Drawing.Point(454, 64);
            this.data_db.Multiline = true;
            this.data_db.Name = "data_db";
            this.data_db.Size = new System.Drawing.Size(308, 337);
            this.data_db.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(39, 119);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(184, 60);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // port_name_tb
            // 
            this.port_name_tb.Location = new System.Drawing.Point(123, 48);
            this.port_name_tb.Name = "port_name_tb";
            this.port_name_tb.Size = new System.Drawing.Size(100, 20);
            this.port_name_tb.TabIndex = 4;
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(39, 204);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(184, 60);
            this.stop_btn.TabIndex = 5;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(39, 292);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(184, 60);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save Data";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IR Sensor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // verticalProgressBar_sound
            // 
            this.verticalProgressBar_sound.Location = new System.Drawing.Point(374, 64);
            this.verticalProgressBar_sound.Maximum = 0;
            this.verticalProgressBar_sound.Name = "verticalProgressBar_sound";
            this.verticalProgressBar_sound.Size = new System.Drawing.Size(35, 221);
            this.verticalProgressBar_sound.TabIndex = 12;
            // 
            // textBox_Sound
            // 
            this.textBox_Sound.BackColor = System.Drawing.Color.White;
            this.textBox_Sound.Location = new System.Drawing.Point(366, 292);
            this.textBox_Sound.Name = "textBox_Sound";
            this.textBox_Sound.Size = new System.Drawing.Size(51, 20);
            this.textBox_Sound.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sound Sensor : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Sound);
            this.Controls.Add(this.verticalProgressBar_sound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.port_name_tb);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.data_db);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_db;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox port_name_tb;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private VerticalProgressBar verticalProgressBar_sound;
        private System.Windows.Forms.TextBox textBox_Sound;
        private System.Windows.Forms.Label label5;
    }
}

