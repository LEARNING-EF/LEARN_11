namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.peopleListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// peopleListBox
			// 
			this.peopleListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.peopleListBox.FormattingEnabled = true;
			this.peopleListBox.Location = new System.Drawing.Point(0, 0);
			this.peopleListBox.Name = "peopleListBox";
			this.peopleListBox.Size = new System.Drawing.Size(284, 262);
			this.peopleListBox.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.peopleListBox);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox peopleListBox;
	}
}
