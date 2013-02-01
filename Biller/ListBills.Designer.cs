/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 4:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biller
{
	partial class ListBills
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
			this.billTable = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBillCancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// billTable
			// 
			this.billTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.billTable.ColumnCount = 2;
			this.billTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.billTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.billTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.billTable.Location = new System.Drawing.Point(12, 25);
			this.billTable.Name = "billTable";
			this.billTable.RowCount = 2;
			this.billTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.94521F));
			this.billTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.05479F));
			this.billTable.Size = new System.Drawing.Size(260, 40);
			this.billTable.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bills";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(229, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Due";
			// 
			// listBillCancelButton
			// 
			this.listBillCancelButton.Location = new System.Drawing.Point(204, 374);
			this.listBillCancelButton.Name = "listBillCancelButton";
			this.listBillCancelButton.Size = new System.Drawing.Size(78, 33);
			this.listBillCancelButton.TabIndex = 3;
			this.listBillCancelButton.Text = "Cancel";
			this.listBillCancelButton.UseVisualStyleBackColor = true;
			this.listBillCancelButton.Click += new System.EventHandler(this.ListBillCancelButtonClick);
			// 
			// ListBills
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 419);
			this.Controls.Add(this.listBillCancelButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.billTable);
			this.Name = "ListBills";
			this.Text = "ListBills";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button listBillCancelButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel billTable;
	}
}
