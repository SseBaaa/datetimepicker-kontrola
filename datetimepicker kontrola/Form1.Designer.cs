
namespace datetimepicker_kontrola
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
            this.dateTimePickerdatum = new System.Windows.Forms.DateTimePicker();
            this.textispis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickervrijeme = new System.Windows.Forms.DateTimePicker();
            this.buttonrezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerdatum
            // 
            this.dateTimePickerdatum.Location = new System.Drawing.Point(382, 93);
            this.dateTimePickerdatum.Name = "dateTimePickerdatum";
            this.dateTimePickerdatum.Size = new System.Drawing.Size(255, 22);
            this.dateTimePickerdatum.TabIndex = 0;
            this.dateTimePickerdatum.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textispis
            // 
            this.textispis.Location = new System.Drawing.Point(238, 189);
            this.textispis.Multiline = true;
            this.textispis.Name = "textispis";
            this.textispis.Size = new System.Drawing.Size(399, 161);
            this.textispis.TabIndex = 1;
            this.textispis.TextChanged += new System.EventHandler(this.textispis_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "datum polaska";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "vrijeme polaska";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickervrijeme
            // 
            this.dateTimePickervrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickervrijeme.Location = new System.Drawing.Point(382, 136);
            this.dateTimePickervrijeme.Name = "dateTimePickervrijeme";
            this.dateTimePickervrijeme.ShowUpDown = true;
            this.dateTimePickervrijeme.Size = new System.Drawing.Size(255, 22);
            this.dateTimePickervrijeme.TabIndex = 4;
            this.dateTimePickervrijeme.Value = new System.DateTime(2022, 1, 18, 11, 57, 0, 0);
            // 
            // buttonrezervacija
            // 
            this.buttonrezervacija.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrezervacija.Location = new System.Drawing.Point(344, 367);
            this.buttonrezervacija.Name = "buttonrezervacija";
            this.buttonrezervacija.Size = new System.Drawing.Size(153, 45);
            this.buttonrezervacija.TabIndex = 5;
            this.buttonrezervacija.Text = "Rezervacija";
            this.buttonrezervacija.UseVisualStyleBackColor = true;
            this.buttonrezervacija.Click += new System.EventHandler(this.buttonrezervacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonrezervacija);
            this.Controls.Add(this.dateTimePickervrijeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textispis);
            this.Controls.Add(this.dateTimePickerdatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerdatum;
        private System.Windows.Forms.TextBox textispis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickervrijeme;
        private System.Windows.Forms.Button buttonrezervacija;
    }
}

