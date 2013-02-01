/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 3:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biller
{
	partial class AddBill
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Name = new System.Windows.Forms.TextBox();
			this.Balance = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Min = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Balance:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Due Date:";
			// 
			// Name
			// 
			this.Name.Location = new System.Drawing.Point(95, 8);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(199, 20);
			this.Name.TabIndex = 3;
			// 
			// Balance
			// 
			this.Balance.Location = new System.Drawing.Point(95, 51);
			this.Balance.Name = "Balance";
			this.Balance.Size = new System.Drawing.Size(199, 20);
			this.Balance.TabIndex = 4;
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(95, 222);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(68, 28);
			this.Add.TabIndex = 6;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.AddClick);
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(186, 222);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(68, 28);
			this.Cancel.TabIndex = 7;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// Min
			// 
			this.Min.Location = new System.Drawing.Point(95, 98);
			this.Min.Name = "Min";
			this.Min.Size = new System.Drawing.Size(199, 20);
			this.Min.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "Min Payment:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker.Location = new System.Drawing.Point(95, 147);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(103, 20);
			this.dateTimePicker.TabIndex = 10;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 306);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.Min);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.Balance);
			this.Controls.Add(this.Name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			//this.Name = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Min;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.TextBox Balance;
		private System.Windows.Forms.TextBox Name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
