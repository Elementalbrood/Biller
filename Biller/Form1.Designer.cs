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
			this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stoofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.amountDueMonth = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.amountDueWeek = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.billerCalendar = new System.Windows.Forms.MonthCalendar();
			this.amountDueByDate = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(199, 256);
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
									this.billToolStripMenuItem});
			this.newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
			this.newBillToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.newBillToolStripMenuItem.Text = "New";
			// 
			// billToolStripMenuItem
			// 
			this.billToolStripMenuItem.Name = "billToolStripMenuItem";
			this.billToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
			this.billToolStripMenuItem.Text = "Bill";
			this.billToolStripMenuItem.Click += new System.EventHandler(this.BillToolStripMenuItemClick);
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
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
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
									this.stoofToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// stoofToolStripMenuItem
			// 
			this.stoofToolStripMenuItem.Name = "stoofToolStripMenuItem";
			this.stoofToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.stoofToolStripMenuItem.Text = "Stoof";
			// 
			// amountDueMonth
			// 
			this.amountDueMonth.Location = new System.Drawing.Point(184, 34);
			this.amountDueMonth.Name = "amountDueMonth";
			this.amountDueMonth.Size = new System.Drawing.Size(115, 20);
			this.amountDueMonth.TabIndex = 8;
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.progressBar1.Location = new System.Drawing.Point(0, 347);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(555, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 10;
			this.progressBar1.Click += new System.EventHandler(this.ProgressBar1Click);
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(0, 398);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(555, 23);
			this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar2.TabIndex = 11;
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
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "Amount due this week:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// amountDueWeek
			// 
			this.amountDueWeek.Location = new System.Drawing.Point(184, 80);
			this.amountDueWeek.Name = "amountDueWeek";
			this.amountDueWeek.Size = new System.Drawing.Size(115, 20);
			this.amountDueWeek.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 124);
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
			this.billerCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.BillerCalendarDateChanged);
			// 
			// amountDueByDate
			// 
			this.amountDueByDate.Location = new System.Drawing.Point(184, 132);
			this.amountDueByDate.Name = "amountDueByDate";
			this.amountDueByDate.Size = new System.Drawing.Size(115, 20);
			this.amountDueByDate.TabIndex = 18;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 433);
			this.Controls.Add(this.amountDueByDate);
			this.Controls.Add(this.billerCalendar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.amountDueWeek);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.amountDueMonth);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Biller";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox amountDueByDate;
		private System.Windows.Forms.MonthCalendar billerCalendar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox amountDueWeek;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newBillToolStripMenuItem;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar1;
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
		private System.Windows.Forms.TextBox amountDueMonth;
		private System.Windows.Forms.Button button1;
	}
}
