namespace Exec2_OOP
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
			this.NewGamebutton = new System.Windows.Forms.Button();
			this.answerlabel = new System.Windows.Forms.Label();
			this.GuesstextBox = new System.Windows.Forms.TextBox();
			this.historyTextbox = new System.Windows.Forms.TextBox();
			this.playButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NewGamebutton
			// 
			this.NewGamebutton.Location = new System.Drawing.Point(56, 17);
			this.NewGamebutton.Name = "NewGamebutton";
			this.NewGamebutton.Size = new System.Drawing.Size(75, 42);
			this.NewGamebutton.TabIndex = 0;
			this.NewGamebutton.Text = "新遊戲";
			this.NewGamebutton.UseVisualStyleBackColor = true;
			this.NewGamebutton.Click += new System.EventHandler(this.NewGamebutton_Click);
			// 
			// answerlabel
			// 
			this.answerlabel.AutoSize = true;
			this.answerlabel.Location = new System.Drawing.Point(188, 29);
			this.answerlabel.Name = "answerlabel";
			this.answerlabel.Size = new System.Drawing.Size(50, 18);
			this.answerlabel.TabIndex = 1;
			this.answerlabel.Text = "label1";
			// 
			// GuesstextBox
			// 
			this.GuesstextBox.Location = new System.Drawing.Point(56, 77);
			this.GuesstextBox.Name = "GuesstextBox";
			this.GuesstextBox.Size = new System.Drawing.Size(100, 29);
			this.GuesstextBox.TabIndex = 2;
			// 
			// historyTextbox
			// 
			this.historyTextbox.Location = new System.Drawing.Point(56, 143);
			this.historyTextbox.Multiline = true;
			this.historyTextbox.Name = "historyTextbox";
			this.historyTextbox.ReadOnly = true;
			this.historyTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.historyTextbox.Size = new System.Drawing.Size(252, 339);
			this.historyTextbox.TabIndex = 3;
			// 
			// playButton
			// 
			this.playButton.Location = new System.Drawing.Point(191, 77);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(75, 29);
			this.playButton.TabIndex = 4;
			this.playButton.Text = "確定";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 512);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.historyTextbox);
			this.Controls.Add(this.GuesstextBox);
			this.Controls.Add(this.answerlabel);
			this.Controls.Add(this.NewGamebutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "1A2B";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button NewGamebutton;
		private System.Windows.Forms.Label answerlabel;
		private System.Windows.Forms.TextBox GuesstextBox;
		private System.Windows.Forms.TextBox historyTextbox;
		private System.Windows.Forms.Button playButton;
	}
}

