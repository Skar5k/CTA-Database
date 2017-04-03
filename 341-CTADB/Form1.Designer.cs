namespace _341_CTADB
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
            this.Load_button = new System.Windows.Forms.Button();
            this.Top10_button = new System.Windows.Forms.Button();
            this.Station_list = new System.Windows.Forms.ListBox();
            this.Total_ridership = new System.Windows.Forms.Label();
            this.Average_ridership = new System.Windows.Forms.Label();
            this.Percent_ridership = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_ridership_box = new System.Windows.Forms.TextBox();
            this.Average_ridership_box = new System.Windows.Forms.TextBox();
            this.Percent_ridership_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Weekday_box = new System.Windows.Forms.TextBox();
            this.Saturday_box = new System.Windows.Forms.TextBox();
            this.sunday_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stops_at_station = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Handicap = new System.Windows.Forms.TextBox();
            this.Direction_travel = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.TextBox();
            this.Lines = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(13, 13);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(75, 23);
            this.Load_button.TabIndex = 0;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Top10_button
            // 
            this.Top10_button.Location = new System.Drawing.Point(94, 12);
            this.Top10_button.Name = "Top10_button";
            this.Top10_button.Size = new System.Drawing.Size(75, 23);
            this.Top10_button.TabIndex = 1;
            this.Top10_button.Text = "Top 10";
            this.Top10_button.UseVisualStyleBackColor = true;
            this.Top10_button.Click += new System.EventHandler(this.Top10_button_Click);
            // 
            // Station_list
            // 
            this.Station_list.FormattingEnabled = true;
            this.Station_list.Location = new System.Drawing.Point(13, 42);
            this.Station_list.Name = "Station_list";
            this.Station_list.Size = new System.Drawing.Size(215, 394);
            this.Station_list.TabIndex = 2;
            this.Station_list.SelectedIndexChanged += new System.EventHandler(this.Station_list_SelectedIndexChanged);
            // 
            // Total_ridership
            // 
            this.Total_ridership.AutoSize = true;
            this.Total_ridership.Location = new System.Drawing.Point(234, 42);
            this.Total_ridership.Name = "Total_ridership";
            this.Total_ridership.Size = new System.Drawing.Size(81, 13);
            this.Total_ridership.TabIndex = 3;
            this.Total_ridership.Text = "Total Ridership:";
            // 
            // Average_ridership
            // 
            this.Average_ridership.AutoSize = true;
            this.Average_ridership.Location = new System.Drawing.Point(234, 76);
            this.Average_ridership.Name = "Average_ridership";
            this.Average_ridership.Size = new System.Drawing.Size(97, 13);
            this.Average_ridership.TabIndex = 4;
            this.Average_ridership.Text = "Average Ridership:";
            // 
            // Percent_ridership
            // 
            this.Percent_ridership.AutoSize = true;
            this.Percent_ridership.Location = new System.Drawing.Point(234, 108);
            this.Percent_ridership.Name = "Percent_ridership";
            this.Percent_ridership.Size = new System.Drawing.Size(65, 13);
            this.Percent_ridership.TabIndex = 5;
            this.Percent_ridership.Text = "% Ridership:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weekday:";
            // 
            // Total_ridership_box
            // 
            this.Total_ridership_box.Location = new System.Drawing.Point(352, 39);
            this.Total_ridership_box.Name = "Total_ridership_box";
            this.Total_ridership_box.ReadOnly = true;
            this.Total_ridership_box.Size = new System.Drawing.Size(100, 20);
            this.Total_ridership_box.TabIndex = 7;
            // 
            // Average_ridership_box
            // 
            this.Average_ridership_box.Location = new System.Drawing.Point(352, 76);
            this.Average_ridership_box.Name = "Average_ridership_box";
            this.Average_ridership_box.ReadOnly = true;
            this.Average_ridership_box.Size = new System.Drawing.Size(100, 20);
            this.Average_ridership_box.TabIndex = 8;
            // 
            // Percent_ridership_box
            // 
            this.Percent_ridership_box.Location = new System.Drawing.Point(352, 109);
            this.Percent_ridership_box.Name = "Percent_ridership_box";
            this.Percent_ridership_box.ReadOnly = true;
            this.Percent_ridership_box.Size = new System.Drawing.Size(100, 20);
            this.Percent_ridership_box.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saturday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sun/Holiday:";
            // 
            // Weekday_box
            // 
            this.Weekday_box.Location = new System.Drawing.Point(575, 39);
            this.Weekday_box.Name = "Weekday_box";
            this.Weekday_box.ReadOnly = true;
            this.Weekday_box.Size = new System.Drawing.Size(100, 20);
            this.Weekday_box.TabIndex = 12;
            // 
            // Saturday_box
            // 
            this.Saturday_box.Location = new System.Drawing.Point(575, 76);
            this.Saturday_box.Name = "Saturday_box";
            this.Saturday_box.ReadOnly = true;
            this.Saturday_box.Size = new System.Drawing.Size(100, 20);
            this.Saturday_box.TabIndex = 13;
            // 
            // sunday_box
            // 
            this.sunday_box.Location = new System.Drawing.Point(575, 108);
            this.sunday_box.Name = "sunday_box";
            this.sunday_box.ReadOnly = true;
            this.sunday_box.Size = new System.Drawing.Size(100, 20);
            this.sunday_box.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stops at this station:";
            // 
            // Stops_at_station
            // 
            this.Stops_at_station.FormattingEnabled = true;
            this.Stops_at_station.Location = new System.Drawing.Point(234, 224);
            this.Stops_at_station.Name = "Stops_at_station";
            this.Stops_at_station.Size = new System.Drawing.Size(183, 212);
            this.Stops_at_station.TabIndex = 16;
            this.Stops_at_station.SelectedIndexChanged += new System.EventHandler(this.Stops_at_station_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Handicap Accessible?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Direction of Travel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Lines:";
            // 
            // Handicap
            // 
            this.Handicap.Location = new System.Drawing.Point(593, 224);
            this.Handicap.Name = "Handicap";
            this.Handicap.ReadOnly = true;
            this.Handicap.Size = new System.Drawing.Size(100, 20);
            this.Handicap.TabIndex = 21;
            // 
            // Direction_travel
            // 
            this.Direction_travel.Location = new System.Drawing.Point(593, 256);
            this.Direction_travel.Name = "Direction_travel";
            this.Direction_travel.ReadOnly = true;
            this.Direction_travel.Size = new System.Drawing.Size(100, 20);
            this.Direction_travel.TabIndex = 22;
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(476, 298);
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Size = new System.Drawing.Size(217, 20);
            this.Location.TabIndex = 23;
            // 
            // Lines
            // 
            this.Lines.FormattingEnabled = true;
            this.Lines.Location = new System.Drawing.Point(476, 337);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(217, 95);
            this.Lines.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Direction_travel);
            this.Controls.Add(this.Handicap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stops_at_station);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sunday_box);
            this.Controls.Add(this.Saturday_box);
            this.Controls.Add(this.Weekday_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Percent_ridership_box);
            this.Controls.Add(this.Average_ridership_box);
            this.Controls.Add(this.Total_ridership_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Percent_ridership);
            this.Controls.Add(this.Average_ridership);
            this.Controls.Add(this.Total_ridership);
            this.Controls.Add(this.Station_list);
            this.Controls.Add(this.Top10_button);
            this.Controls.Add(this.Load_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Top10_button;
        private System.Windows.Forms.ListBox Station_list;
        private System.Windows.Forms.Label Total_ridership;
        private System.Windows.Forms.Label Average_ridership;
        private System.Windows.Forms.Label Percent_ridership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Total_ridership_box;
        private System.Windows.Forms.TextBox Average_ridership_box;
        private System.Windows.Forms.TextBox Percent_ridership_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Weekday_box;
        private System.Windows.Forms.TextBox Saturday_box;
        private System.Windows.Forms.TextBox sunday_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Stops_at_station;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Handicap;
        private System.Windows.Forms.TextBox Direction_travel;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.ListBox Lines;
    }
}

