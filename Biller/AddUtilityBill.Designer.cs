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
	partial class AddUtilityBill
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
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.button_add = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.radioButton_monthly = new System.Windows.Forms.RadioButton();
			this.radioButton_biannual = new System.Windows.Forms.RadioButton();
			this.radioButton_annual = new System.Windows.Forms.RadioButton();
			this.radioButton_none = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
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
			this.label_balance.Location = new System.Drawing.Point(7, 52);
			this.label_balance.Name = "label_balance";
			this.label_balance.Size = new System.Drawing.Size(57, 18);
			this.label_balance.TabIndex = 1;
			this.label_balance.Text = "Balance:";
			// 
			// label_due_date
			// 
			this.label_due_date.Location = new System.Drawing.Point(7, 103);
			this.label_due_date.Name = "label_due_date";
			this.label_due_date.Size = new System.Drawing.Size(82, 18);
			this.label_due_date.TabIndex = 2;
			this.label_due_date.Text = "Due Date:";
			// 
			// textbox_name
			// 
			this.textbox_name.AutoCompleteCustomSource.AddRange(new string[] {
									"Water",
									"Gas",
									"Electric",
									"Rent"});
			this.textbox_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textbox_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.textbox_name.Location = new System.Drawing.Point(95, 8);
			this.textbox_name.Name = "textbox_name";
			this.textbox_name.Size = new System.Drawing.Size(197, 20);
			this.textbox_name.TabIndex = 3;
			// 
			// textbox_balance
			// 
			this.textbox_balance.Location = new System.Drawing.Point(93, 52);
			this.textbox_balance.Name = "textbox_balance";
			this.textbox_balance.Size = new System.Drawing.Size(199, 20);
			this.textbox_balance.TabIndex = 4;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker.Location = new System.Drawing.Point(95, 103);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(103, 20);
			this.dateTimePicker.TabIndex = 5;
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(70, 327);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(68, 28);
			this.button_add.TabIndex = 11;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.AddClick);
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(176, 327);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(68, 28);
			this.button_cancel.TabIndex = 12;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// radioButton_monthly
			// 
			this.radioButton_monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radioButton_monthly.Location = new System.Drawing.Point(159, 199);
			this.radioButton_monthly.Name = "radioButton_monthly";
			this.radioButton_monthly.Size = new System.Drawing.Size(77, 24);
			this.radioButton_monthly.TabIndex = 8;
			this.radioButton_monthly.TabStop = true;
			this.radioButton_monthly.Text = "Monthly";
			this.radioButton_monthly.UseVisualStyleBackColor = true;
			// 
			// radioButton_biannual
			// 
			this.radioButton_biannual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radioButton_biannual.Location = new System.Drawing.Point(34, 245);
			this.radioButton_biannual.Name = "radioButton_biannual";
			this.radioButton_biannual.Size = new System.Drawing.Size(104, 24);
			this.radioButton_biannual.TabIndex = 9;
			this.radioButton_biannual.TabStop = true;
			this.radioButton_biannual.Text = "Biannual";
			this.radioButton_biannual.UseVisualStyleBackColor = true;
			// 
			// radioButton_annual
			// 
			this.radioButton_annual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radioButton_annual.Location = new System.Drawing.Point(159, 245);
			this.radioButton_annual.Name = "radioButton_annual";
			this.radioButton_annual.Size = new System.Drawing.Size(104, 24);
			this.radioButton_annual.TabIndex = 10;
			this.radioButton_annual.TabStop = true;
			this.radioButton_annual.Text = "Annual";
			this.radioButton_annual.UseVisualStyleBackColor = true;
			// 
			// radioButton_none
			// 
			this.radioButton_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radioButton_none.Location = new System.Drawing.Point(34, 199);
			this.radioButton_none.Name = "radioButton_none";
			this.radioButton_none.Size = new System.Drawing.Size(104, 24);
			this.radioButton_none.TabIndex = 7;
			this.radioButton_none.TabStop = true;
			this.radioButton_none.Text = "None";
			this.radioButton_none.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.Location = new System.Drawing.Point(12, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Occurence:";
			// 
			// AddUtilityBill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 377);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radioButton_none);
			this.Controls.Add(this.radioButton_annual);
			this.Controls.Add(this.radioButton_biannual);
			this.Controls.Add(this.radioButton_monthly);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.textbox_balance);
			this.Controls.Add(this.textbox_name);
			this.Controls.Add(this.label_due_date);
			this.Controls.Add(this.label_balance);
			this.Controls.Add(this.label_name);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_add);
			this.Name = "AddUtilityBill";
			this.Text = "Add Utility Bill";
			this.Load += new System.EventHandler(this.AddBillLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton_none;
		private System.Windows.Forms.RadioButton radioButton_annual;
		private System.Windows.Forms.RadioButton radioButton_biannual;
		private System.Windows.Forms.RadioButton radioButton_monthly;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.TextBox textbox_name;
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
