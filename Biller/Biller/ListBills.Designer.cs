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
			this.listBillCancelButton = new System.Windows.Forms.Button();
			this.billDisplay = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.billDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// listBillCancelButton
			// 
			this.listBillCancelButton.Location = new System.Drawing.Point(376, 382);
			this.listBillCancelButton.Name = "listBillCancelButton";
			this.listBillCancelButton.Size = new System.Drawing.Size(78, 33);
			this.listBillCancelButton.TabIndex = 3;
			this.listBillCancelButton.Text = "Cancel";
			this.listBillCancelButton.UseVisualStyleBackColor = true;
			this.listBillCancelButton.Click += new System.EventHandler(this.ListBillCancelButtonClick);
			// 
			// billDisplay
			// 
			this.billDisplay.AllowUserToAddRows = false;
			this.billDisplay.AllowUserToDeleteRows = false;
			this.billDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.billDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.billDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.billDisplay.GridColor = System.Drawing.SystemColors.Control;
			this.billDisplay.Location = new System.Drawing.Point(0, 0);
			this.billDisplay.Name = "billDisplay";
			this.billDisplay.ReadOnly = true;
			this.billDisplay.ShowEditingIcon = false;
			this.billDisplay.Size = new System.Drawing.Size(463, 356);
			this.billDisplay.TabIndex = 5;
			// 
			// ListBills
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(466, 427);
			this.Controls.Add(this.listBillCancelButton);
			this.Controls.Add(this.billDisplay);
			this.Name = "ListBills";
			this.Text = "List Bills";
			((System.ComponentModel.ISupportInitialize)(this.billDisplay)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView billDisplay;
		private System.Windows.Forms.Button listBillCancelButton;
	}
}
