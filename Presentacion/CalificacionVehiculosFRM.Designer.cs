
namespace Presentacion
{
    partial class CalificacionVehiculosFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalificacionVehiculosFRM));
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection1 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton1 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.observacionInp = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recomiendaInp2 = new System.Windows.Forms.RadioButton();
            this.recomiendaInp = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.calificacionInput = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 81);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(105, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calificación de vehiculos";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // observacionInp
            // 
            this.observacionInp.Location = new System.Drawing.Point(74, 218);
            this.observacionInp.Name = "observacionInp";
            this.observacionInp.Size = new System.Drawing.Size(227, 82);
            this.observacionInp.TabIndex = 5;
            this.observacionInp.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "observaciones del vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "recomienda el vehiculo?";
            // 
            // recomiendaInp2
            // 
            this.recomiendaInp2.AutoSize = true;
            this.recomiendaInp2.Location = new System.Drawing.Point(232, 340);
            this.recomiendaInp2.Name = "recomiendaInp2";
            this.recomiendaInp2.Size = new System.Drawing.Size(39, 17);
            this.recomiendaInp2.TabIndex = 8;
            this.recomiendaInp2.TabStop = true;
            this.recomiendaInp2.Text = "No";
            this.recomiendaInp2.UseVisualStyleBackColor = true;
            // 
            // recomiendaInp
            // 
            this.recomiendaInp.AutoSize = true;
            this.recomiendaInp.Location = new System.Drawing.Point(232, 317);
            this.recomiendaInp.Name = "recomiendaInp";
            this.recomiendaInp.Size = new System.Drawing.Size(34, 17);
            this.recomiendaInp.TabIndex = 9;
            this.recomiendaInp.TabStop = true;
            this.recomiendaInp.Text = "Si";
            this.recomiendaInp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calificacionInput
            // 
            this.calificacionInput.Images = customImageCollection1;
            this.calificacionInput.Location = new System.Drawing.Point(153, 153);
            this.calificacionInput.Name = "calificacionInput";
            this.calificacionInput.ResetButton = resetButton1;
            this.calificacionInput.Size = new System.Drawing.Size(148, 27);
            this.calificacionInput.TabIndex = 11;
            this.calificacionInput.Text = "ratingControl1";
            this.calificacionInput.Click += new System.EventHandler(this.calificacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Calificación";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CalificacionVehiculosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(393, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calificacionInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recomiendaInp);
            this.Controls.Add(this.recomiendaInp2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.observacionInp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CalificacionVehiculosFRM";
            this.Text = "CARSHOWROOM";
            this.Load += new System.EventHandler(this.CalificacionVehiculosFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox observacionInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton recomiendaInp2;
        private System.Windows.Forms.RadioButton recomiendaInp;
        private System.Windows.Forms.Button button1;
        private Syncfusion.Windows.Forms.Tools.RatingControl calificacionInput;
        private System.Windows.Forms.Label label4;
    }
}