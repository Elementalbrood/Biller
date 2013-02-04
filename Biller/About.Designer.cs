/*
 * Created by SharpDevelop.
 * User: Sean
 * Date: 2/4/2013
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biller
{
	partial class About
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
			this.richTextBox1_about = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// richTextBox1_about
			// 
			this.richTextBox1_about.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1_about.Name = "richTextBox1_about";
			this.richTextBox1_about.ReadOnly = true;
			this.richTextBox1_about.Size = new System.Drawing.Size(399, 223);
			this.richTextBox1_about.TabIndex = 0;
			this.richTextBox1_about.Text = "About the designers:\n\nBrandon: Super awesome stoof\n\nSean: Super awesome stoof but" +
			" not as awesome of stoof as Brandon\'s stoof";
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 386);
			this.Controls.Add(this.richTextBox1_about);
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox richTextBox1_about;
	}
}
