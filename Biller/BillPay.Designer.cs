/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 2/2/2013
 * Time: 12:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biller
{
	partial class BillPay
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
			this.comboBox_bill = new System.Windows.Forms.ComboBox();
			this.label_bill = new System.Windows.Forms.Label();
			this.label_amount_paid = new System.Windows.Forms.Label();
			this.textBox_amount_paid = new System.Windows.Forms.TextBox();
			this.button_pay_me = new System.Windows.Forms.Button();
			this.label_date_paid = new System.Windows.Forms.Label();
			this.dateTimePicker_paid = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// comboBox_bill
			// 
			this.comboBox_bill.FormattingEnabled = true;
			this.comboBox_bill.Location = new System.Drawing.Point(120, 23);
			this.comboBox_bill.Name = "comboBox_bill";
			this.comboBox_bill.Size = new System.Drawing.Size(124, 21);
			this.comboBox_bill.TabIndex = 0;
			// 
			// label_bill
			// 
			this.label_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label_bill.Location = new System.Drawing.Point(19, 23);
			this.label_bill.Name = "label_bill";
			this.label_bill.Size = new System.Drawing.Size(86, 20);
			this.label_bill.TabIndex = 4;
			this.label_bill.Text = "Bill:";
			// 
			// label_amount_paid
			// 
			this.label_amount_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label_amount_paid.Location = new System.Drawing.Point(19, 73);
			this.label_amount_paid.Name = "label_amount_paid";
			this.label_amount_paid.Size = new System.Drawing.Size(91, 21);
			this.label_amount_paid.TabIndex = 5;
			this.label_amount_paid.Text = "Amount Paid:";
			// 
			// textBox_amount_paid
			// 
			this.textBox_amount_paid.Location = new System.Drawing.Point(120, 72);
			this.textBox_amount_paid.Name = "textBox_amount_paid";
			this.textBox_amount_paid.Size = new System.Drawing.Size(124, 20);
			this.textBox_amount_paid.TabIndex = 1;
			// 
			// button_pay_me
			// 
			this.button_pay_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.button_pay_me.Location = new System.Drawing.Point(57, 174);
			this.button_pay_me.Name = "button_pay_me";
			this.button_pay_me.Size = new System.Drawing.Size(147, 76);
			this.button_pay_me.TabIndex = 3;
			this.button_pay_me.Text = "PAY ME NOW!!!";
			this.button_pay_me.UseVisualStyleBackColor = true;
			// 
			// label_date_paid
			// 
			this.label_date_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label_date_paid.Location = new System.Drawing.Point(19, 116);
			this.label_date_paid.Name = "label_date_paid";
			this.label_date_paid.Size = new System.Drawing.Size(74, 24);
			this.label_date_paid.TabIndex = 6;
			this.label_date_paid.Text = "Date Paid:";
			// 
			// dateTimePicker_paid
			// 
			this.dateTimePicker_paid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker_paid.Location = new System.Drawing.Point(120, 118);
			this.dateTimePicker_paid.Name = "dateTimePicker_paid";
			this.dateTimePicker_paid.Size = new System.Drawing.Size(123, 20);
			this.dateTimePicker_paid.TabIndex = 2;
			// 
			// BillPay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.dateTimePicker_paid);
			this.Controls.Add(this.label_date_paid);
			this.Controls.Add(this.button_pay_me);
			this.Controls.Add(this.textBox_amount_paid);
			this.Controls.Add(this.label_amount_paid);
			this.Controls.Add(this.label_bill);
			this.Controls.Add(this.comboBox_bill);
			this.Name = "BillPay";
			this.Text = "BillPay";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dateTimePicker_paid;
		private System.Windows.Forms.Label label_date_paid;
		private System.Windows.Forms.Button button_pay_me;
		private System.Windows.Forms.TextBox textBox_amount_paid;
		private System.Windows.Forms.Label label_amount_paid;
		private System.Windows.Forms.Label label_bill;
		private System.Windows.Forms.ComboBox comboBox_bill;
	}
}
