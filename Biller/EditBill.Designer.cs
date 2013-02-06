/*
 * Created by SharpDevelop.
 * User: Sean
 * Date: 2/4/2013
 * Time: 1:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biller
{
	partial class EditBill
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox_editBill = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// comboBox_editBill
			// 
			this.comboBox_editBill.FormattingEnabled = true;
			this.comboBox_editBill.Location = new System.Drawing.Point(88, 23);
			this.comboBox_editBill.Name = "comboBox_editBill";
			this.comboBox_editBill.Size = new System.Drawing.Size(197, 21);
			this.comboBox_editBill.TabIndex = 1;
			// 
			// EditBill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 398);
			this.Controls.Add(this.comboBox_editBill);
			this.Controls.Add(this.label1);
			this.Name = "EditBill";
			this.Text = "EditBill";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox comboBox_editBill;
		private System.Windows.Forms.Label label1;
	}
}
