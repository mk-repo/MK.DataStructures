using System.Windows.Forms;

namespace MK.DataStructures.Windows.Client
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Text = "Main";

			TextBox txtListInput = new TextBox();
			txtListInput.Name = "ListInput";
			txtListInput.Visible = true;
			this.Controls.Add(txtListInput);

			Button btnListInput = new Button();
			btnListInput.Text = "Add";
			btnListInput.Name = "ListInput";
			btnListInput.Visible = true;
			btnListInput.Location.Offset(50, 100);
			this.Controls.Add(btnListInput);

		}

		#endregion
	}
}

