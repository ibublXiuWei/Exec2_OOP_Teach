namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.playTextbox = new System.Windows.Forms.Button();
			this.historyTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// playTextbox
			// 
			this.playTextbox.Location = new System.Drawing.Point(146, 39);
			this.playTextbox.Name = "playTextbox";
			this.playTextbox.Size = new System.Drawing.Size(81, 47);
			this.playTextbox.TabIndex = 0;
			this.playTextbox.Text = "擲骰";
			this.playTextbox.UseVisualStyleBackColor = true;
			this.playTextbox.Click += new System.EventHandler(this.playTextbox_Click);
			// 
			// historyTextBox
			// 
			this.historyTextBox.Location = new System.Drawing.Point(61, 134);
			this.historyTextBox.Multiline = true;
			this.historyTextBox.Name = "historyTextBox";
			this.historyTextBox.ReadOnly = true;
			this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.historyTextBox.Size = new System.Drawing.Size(262, 341);
			this.historyTextBox.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 527);
			this.Controls.Add(this.historyTextBox);
			this.Controls.Add(this.playTextbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button playTextbox;
		private System.Windows.Forms.TextBox historyTextBox;
	}
}

