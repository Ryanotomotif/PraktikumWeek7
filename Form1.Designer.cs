
namespace PraktikumWeek7
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbox_kalimat = new System.Windows.Forms.TextBox();
			this.tbox_huruf = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbox_convert = new System.Windows.Forms.TextBox();
			this.btn_konversi = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_output = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masukkan Kalimat";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Masukkan Huruf";
			// 
			// tbox_kalimat
			// 
			this.tbox_kalimat.Location = new System.Drawing.Point(174, 37);
			this.tbox_kalimat.Name = "tbox_kalimat";
			this.tbox_kalimat.Size = new System.Drawing.Size(306, 22);
			this.tbox_kalimat.TabIndex = 2;
			// 
			// tbox_huruf
			// 
			this.tbox_huruf.Location = new System.Drawing.Point(174, 76);
			this.tbox_huruf.Name = "tbox_huruf";
			this.tbox_huruf.Size = new System.Drawing.Size(100, 22);
			this.tbox_huruf.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(298, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Menjadi";
			// 
			// tbox_convert
			// 
			this.tbox_convert.Location = new System.Drawing.Point(380, 76);
			this.tbox_convert.Name = "tbox_convert";
			this.tbox_convert.Size = new System.Drawing.Size(100, 22);
			this.tbox_convert.TabIndex = 5;
			// 
			// btn_konversi
			// 
			this.btn_konversi.Location = new System.Drawing.Point(174, 133);
			this.btn_konversi.Name = "btn_konversi";
			this.btn_konversi.Size = new System.Drawing.Size(306, 23);
			this.btn_konversi.TabIndex = 6;
			this.btn_konversi.Text = "Konversi!";
			this.btn_konversi.UseVisualStyleBackColor = true;
			this.btn_konversi.Click += new System.EventHandler(this.btn_konversi_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Hasil :";
			// 
			// lbl_output
			// 
			this.lbl_output.AutoSize = true;
			this.lbl_output.Location = new System.Drawing.Point(171, 192);
			this.lbl_output.Name = "lbl_output";
			this.lbl_output.Size = new System.Drawing.Size(0, 17);
			this.lbl_output.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 267);
			this.Controls.Add(this.lbl_output);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_konversi);
			this.Controls.Add(this.tbox_convert);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbox_huruf);
			this.Controls.Add(this.tbox_kalimat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbox_kalimat;
		private System.Windows.Forms.TextBox tbox_huruf;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbox_convert;
		private System.Windows.Forms.Button btn_konversi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_output;
	}
}

