/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biller
{
	partial class MainForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billToolStripMenuItemClick_newUtilityBill = new System.Windows.Forms.ToolStripMenuItem();
			this.otherBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stoofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
			this.textbox_amountDueMonth = new System.Windows.Forms.TextBox();
			this.progressBar_monthBills = new System.Windows.Forms.ProgressBar();
			this.progressBar_creditCards = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.billerCalendar = new System.Windows.Forms.MonthCalendar();
			this.textbox_amountDueByDate = new System.Windows.Forms.TextBox();
			this.button_refresh = new System.Windows.Forms.Button();
			this.button_PayABill = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(190, 238);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "Stoof Button";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.viewToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(555, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newBillToolStripMenuItem,
									this.saveToolStripMenuItem,
									this.infoToolStripMenuItem,
									this.stuffToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newBillToolStripMenuItem
			// 
			this.newBillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.billToolStripMenuItemClick_newUtilityBill,
									this.otherBillToolStripMenuItem});
			this.newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
			this.newBillToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.newBillToolStripMenuItem.Text = "New";
			// 
			// billToolStripMenuItemClick_newUtilityBill
			// 
			this.billToolStripMenuItemClick_newUtilityBill.Name = "billToolStripMenuItemClick_newUtilityBill";
			this.billToolStripMenuItemClick_newUtilityBill.Size = new System.Drawing.Size(124, 22);
			this.billToolStripMenuItemClick_newUtilityBill.Text = "Utility Bill";
			this.billToolStripMenuItemClick_newUtilityBill.Click += new System.EventHandler(this.BillToolStripMenuItem_newUtilityBillClick);
			// 
			// otherBillToolStripMenuItem
			// 
			this.otherBillToolStripMenuItem.Name = "otherBillToolStripMenuItem";
			this.otherBillToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.otherBillToolStripMenuItem.Text = "Other Bill";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.infoToolStripMenuItem.Text = "Info";
			// 
			// stuffToolStripMenuItem
			// 
			this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
			this.stuffToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.stuffToolStripMenuItem.Text = "Stuff";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.billToolStripMenuItem1});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// billToolStripMenuItem1
			// 
			this.billToolStripMenuItem1.Name = "billToolStripMenuItem1";
			this.billToolStripMenuItem1.Size = new System.Drawing.Size(90, 22);
			this.billToolStripMenuItem1.Text = "Bill";
			this.billToolStripMenuItem1.Click += new System.EventHandler(this.EditBillClick);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newWindowToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// newWindowToolStripMenuItem
			// 
			this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
			this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.newWindowToolStripMenuItem.Text = "Bill List";
			this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.Bill_List_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.stoofToolStripMenuItem,
									this.aboutToolStripMenuItem_about});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// stoofToolStripMenuItem
			// 
			this.stoofToolStripMenuItem.Name = "stoofToolStripMenuItem";
			this.stoofToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.stoofToolStripMenuItem.Text = "Stoof";
			// 
			// aboutToolStripMenuItem_about
			// 
			this.aboutToolStripMenuItem_about.Name = "aboutToolStripMenuItem_about";
			this.aboutToolStripMenuItem_about.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem_about.Text = "About";
			this.aboutToolStripMenuItem_about.Click += new System.EventHandler(this.AboutToolStripMenuItem_aboutClick);
			// 
			// textbox_amountDueMonth
			// 
			this.textbox_amountDueMonth.Location = new System.Drawing.Point(184, 34);
			this.textbox_amountDueMonth.Name = "textbox_amountDueMonth";
			this.textbox_amountDueMonth.ReadOnly = true;
			this.textbox_amountDueMonth.Size = new System.Drawing.Size(115, 20);
			this.textbox_amountDueMonth.TabIndex = 8;
			// 
			// progressBar_monthBills
			// 
			this.progressBar_monthBills.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.progressBar_monthBills.Location = new System.Drawing.Point(0, 347);
			this.progressBar_monthBills.Name = "progressBar_monthBills";
			this.progressBar_monthBills.Size = new System.Drawing.Size(555, 23);
			this.progressBar_monthBills.TabIndex = 10;
			// 
			// progressBar_creditCards
			// 
			this.progressBar_creditCards.Location = new System.Drawing.Point(0, 398);
			this.progressBar_creditCards.Name = "progressBar_creditCards";
			this.progressBar_creditCards.Size = new System.Drawing.Size(555, 23);
			this.progressBar_creditCards.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar_creditCards.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(137, 321);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Progress to pay months bills";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(137, 373);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(262, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Progress to pay off credit cards";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "Amount due this month:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 34);
			this.label5.TabIndex = 16;
			this.label5.Text = "Amount due by chosen date:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// billerCalendar
			// 
			this.billerCalendar.Location = new System.Drawing.Point(311, 18);
			this.billerCalendar.Name = "billerCalendar";
			this.billerCalendar.TabIndex = 17;
			this.billerCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.BillerCalendarDateSelected);
			// 
			// textbox_amountDueByDate
			// 
			this.textbox_amountDueByDate.Location = new System.Drawing.Point(184, 88);
			this.textbox_amountDueByDate.Name = "textbox_amountDueByDate";
			this.textbox_amountDueByDate.ReadOnly = true;
			this.textbox_amountDueByDate.Size = new System.Drawing.Size(115, 20);
			this.textbox_amountDueByDate.TabIndex = 18;
			// 
			// button_refresh
			// 
			this.button_refresh.Location = new System.Drawing.Point(11, 185);
			this.button_refresh.Name = "button_refresh";
			this.button_refresh.Size = new System.Drawing.Size(154, 82);
			this.button_refresh.TabIndex = 19;
			this.button_refresh.Text = "Refresh Stoof";
			this.button_refresh.UseVisualStyleBackColor = true;
			this.button_refresh.Click += new System.EventHandler(this.Button_refreshClick);
			// 
			// button_PayABill
			// 
			this.button_PayABill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_PayABill.Location = new System.Drawing.Point(372, 238);
			this.button_PayABill.Name = "button_PayABill";
			this.button_PayABill.Size = new System.Drawing.Size(165, 47);
			this.button_PayABill.TabIndex = 20;
			this.button_PayABill.Text = "Pay a bill";
			this.button_PayABill.UseVisualStyleBackColor = true;
			this.button_PayABill.Click += new System.EventHandler(this.Button_PayABillClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 433);
			this.Controls.Add(this.button_PayABill);
			this.Controls.Add(this.button_refresh);
			this.Controls.Add(this.textbox_amountDueByDate);
			this.Controls.Add(this.billerCalendar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar_creditCards);
			this.Controls.Add(this.progressBar_monthBills);
			this.Controls.Add(this.textbox_amountDueMonth);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Biller";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem otherBillToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem_about;
		private System.Windows.Forms.Button button_PayABill;
		private System.Windows.Forms.Button button_refresh;
		private System.Windows.Forms.TextBox textbox_amountDueByDate;
		private System.Windows.Forms.MonthCalendar billerCalendar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItemClick_newUtilityBill;
		private System.Windows.Forms.ToolStripMenuItem newBillToolStripMenuItem;
		private System.Windows.Forms.ProgressBar progressBar_creditCards;
		private System.Windows.Forms.ProgressBar progressBar_monthBills;
		private System.Windows.Forms.ToolStripMenuItem stoofToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox textbox_amountDueMonth;
		private System.Windows.Forms.Button button1;
	}
}
