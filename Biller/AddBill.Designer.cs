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
			this.label_name = new System.Windows.Forms.Label();
			this.label_balance = new System.Windows.Forms.Label();
			this.label_due_date = new System.Windows.Forms.Label();
			this.textbox_name = new System.Windows.Forms.TextBox();
			this.textbox_balance = new System.Windows.Forms.TextBox();
			this.textbox_min = new System.Windows.Forms.TextBox();
			this.label_min_pay = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.button_add = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.combobox_typeOfBill = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label_name
			// 
			this.label_name.Location = new System.Drawing.Point(7, 11);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(82, 17);
			this.label_name.TabIndex = 0;
			this.label_name.Text = "Name:";
			// 
			// label_balance
			// 
			this.label_balance.Location = new System.Drawing.Point(6, 99);
			this.label_balance.Name = "label_balance";
			this.label_balance.Size = new System.Drawing.Size(57, 18);
			this.label_balance.TabIndex = 1;
			this.label_balance.Text = "Balance:";
			// 
			// label_due_date
			// 
			this.label_due_date.Location = new System.Drawing.Point(6, 192);
			this.label_due_date.Name = "label_due_date";
			this.label_due_date.Size = new System.Drawing.Size(92, 18);
			this.label_due_date.TabIndex = 2;
			this.label_due_date.Text = "Due Date:";
			// 
			// textbox_name
			// 
			this.textbox_name.Location = new System.Drawing.Point(95, 8);
			this.textbox_name.Name = "textbox_name";
			this.textbox_name.Size = new System.Drawing.Size(197, 20);
			this.textbox_name.TabIndex = 3;
			// 
			// textbox_balance
			// 
			this.textbox_balance.Location = new System.Drawing.Point(95, 96);
			this.textbox_balance.Name = "textbox_balance";
			this.textbox_balance.Size = new System.Drawing.Size(199, 20);
			this.textbox_balance.TabIndex = 4;
			// 
			// textbox_min
			// 
			this.textbox_min.Location = new System.Drawing.Point(95, 143);
			this.textbox_min.Name = "textbox_min";
			this.textbox_min.Size = new System.Drawing.Size(197, 20);
			this.textbox_min.TabIndex = 5;
			// 
			// label_min_pay
			// 
			this.label_min_pay.Location = new System.Drawing.Point(6, 146);
			this.label_min_pay.Name = "label_min_pay";
			this.label_min_pay.Size = new System.Drawing.Size(92, 18);
			this.label_min_pay.TabIndex = 9;
			this.label_min_pay.Text = "Min Payment:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker.Location = new System.Drawing.Point(95, 186);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(103, 20);
			this.dateTimePicker.TabIndex = 6;
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(70, 327);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(68, 28);
			this.button_add.TabIndex = 7;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.AddClick);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(176, 327);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(68, 28);
			this.button_cancel.TabIndex = 8;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 32);
			this.label1.TabIndex = 10;
			this.label1.Text = "Type of bill:";
			// 
			// combobox_typeOfBill
			// 
			this.combobox_typeOfBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.combobox_typeOfBill.FormattingEnabled = true;
			this.combobox_typeOfBill.Items.AddRange(new object[] {
									"Utilities bill",
									"Credit card",
									"Loan"});
			this.combobox_typeOfBill.Location = new System.Drawing.Point(95, 48);
			this.combobox_typeOfBill.MaxDropDownItems = 2;
			this.combobox_typeOfBill.Name = "combobox_typeOfBill";
			this.combobox_typeOfBill.Size = new System.Drawing.Size(197, 21);
			this.combobox_typeOfBill.TabIndex = 11;
			//this.combobox_typeOfBill.Click += new System.EventHandler(this.Combobox_typeOfBillClick);
			// 
			// AddBill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 377);
			this.Controls.Add(this.combobox_typeOfBill);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.textbox_min);
			this.Controls.Add(this.label_min_pay);
			this.Controls.Add(this.textbox_balance);
			this.Controls.Add(this.textbox_name);
			this.Controls.Add(this.label_due_date);
			this.Controls.Add(this.label_balance);
			this.Controls.Add(this.label_name);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_add);
			this.Name = "AddBill";
			this.Text = "Add Bill";
			this.Load += new System.EventHandler(this.AddBillLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox combobox_typeOfBill;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label_min_pay;
		private System.Windows.Forms.TextBox textbox_name;
		private System.Windows.Forms.TextBox textbox_min;
		private System.Windows.Forms.TextBox textbox_balance;
		private System.Windows.Forms.Label label_due_date;
		private System.Windows.Forms.Label label_balance;
		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_add;
		
		
		void AddBillLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}
