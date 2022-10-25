namespace Exec2_Star
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
			this.Generationbutton = new System.Windows.Forms.Button();
			this.symetrybutton = new System.Windows.Forms.Button();
			this.rightbutton = new System.Windows.Forms.Button();
			this.starslabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.resulttext = new System.Windows.Forms.TextBox();
			this.rowstext = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Generationbutton
			// 
			this.Generationbutton.Location = new System.Drawing.Point(259, 39);
			this.Generationbutton.Name = "Generationbutton";
			this.Generationbutton.Size = new System.Drawing.Size(75, 23);
			this.Generationbutton.TabIndex = 1;
			this.Generationbutton.Text = "靠左";
			this.Generationbutton.UseVisualStyleBackColor = true;
			this.Generationbutton.Click += new System.EventHandler(this.Generationbutton_Click);
			// 
			// symetrybutton
			// 
			this.symetrybutton.Location = new System.Drawing.Point(361, 39);
			this.symetrybutton.Name = "symetrybutton";
			this.symetrybutton.Size = new System.Drawing.Size(75, 23);
			this.symetrybutton.TabIndex = 2;
			this.symetrybutton.Text = "等腰";
			this.symetrybutton.UseVisualStyleBackColor = true;
			this.symetrybutton.Click += new System.EventHandler(this.symetrybutton_Click);
			// 
			// rightbutton
			// 
			this.rightbutton.Location = new System.Drawing.Point(463, 39);
			this.rightbutton.Name = "rightbutton";
			this.rightbutton.Size = new System.Drawing.Size(75, 23);
			this.rightbutton.TabIndex = 3;
			this.rightbutton.Text = "靠右";
			this.rightbutton.UseVisualStyleBackColor = true;
			this.rightbutton.Click += new System.EventHandler(this.rightbutton_Click);
			// 
			// starslabel
			// 
			this.starslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.starslabel.Location = new System.Drawing.Point(69, 340);
			this.starslabel.Name = "starslabel";
			this.starslabel.Size = new System.Drawing.Size(473, 82);
			this.starslabel.TabIndex = 5;
			this.starslabel.Text = "starlabel";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "列數：";
			// 
			// resulttext
			// 
			this.resulttext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resulttext.Location = new System.Drawing.Point(72, 84);
			this.resulttext.Multiline = true;
			this.resulttext.Name = "resulttext";
			this.resulttext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resulttext.Size = new System.Drawing.Size(470, 240);
			this.resulttext.TabIndex = 4;
			this.resulttext.WordWrap = false;
			// 
			// rowstext
			// 
			this.rowstext.Location = new System.Drawing.Point(72, 41);
			this.rowstext.MaxLength = 2;
			this.rowstext.Name = "rowstext";
			this.rowstext.Size = new System.Drawing.Size(160, 20);
			this.rowstext.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 441);
			this.Controls.Add(this.rowstext);
			this.Controls.Add(this.resulttext);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.starslabel);
			this.Controls.Add(this.rightbutton);
			this.Controls.Add(this.symetrybutton);
			this.Controls.Add(this.Generationbutton);
			this.MinimumSize = new System.Drawing.Size(585, 480);
			this.Name = "Form1";
			this.Text = "1~10列星號";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Generationbutton;
		private System.Windows.Forms.Button symetrybutton;
		private System.Windows.Forms.Button rightbutton;
		private System.Windows.Forms.Label starslabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox resulttext;
		private System.Windows.Forms.TextBox rowstext;
	}
}

