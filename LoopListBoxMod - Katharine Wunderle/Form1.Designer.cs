
namespace LoopListBoxMod___Katharine_Wunderle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.srtYrLbl = new System.Windows.Forms.Label();
            this.endYrLbl = new System.Windows.Forms.Label();
            this.startYrInput = new System.Windows.Forms.TextBox();
            this.endYrInpt = new System.Windows.Forms.TextBox();
            this.eleCkBx = new System.Windows.Forms.CheckBox();
            this.censusCkBx = new System.Windows.Forms.CheckBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.yrLst = new System.Windows.Forms.ListBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // srtYrLbl
            // 
            this.srtYrLbl.AutoSize = true;
            this.srtYrLbl.Location = new System.Drawing.Point(67, 13);
            this.srtYrLbl.Name = "srtYrLbl";
            this.srtYrLbl.Size = new System.Drawing.Size(91, 13);
            this.srtYrLbl.TabIndex = 0;
            this.srtYrLbl.Text = "Start Year (YYYY)";
            // 
            // endYrLbl
            // 
            this.endYrLbl.AutoSize = true;
            this.endYrLbl.Location = new System.Drawing.Point(200, 13);
            this.endYrLbl.Name = "endYrLbl";
            this.endYrLbl.Size = new System.Drawing.Size(88, 13);
            this.endYrLbl.TabIndex = 1;
            this.endYrLbl.Text = "End Year (YYYY)";
            // 
            // startYrInput
            // 
            this.startYrInput.Location = new System.Drawing.Point(63, 30);
            this.startYrInput.Name = "startYrInput";
            this.startYrInput.Size = new System.Drawing.Size(100, 20);
            this.startYrInput.TabIndex = 2;
            // 
            // endYrInpt
            // 
            this.endYrInpt.Location = new System.Drawing.Point(194, 30);
            this.endYrInpt.Name = "endYrInpt";
            this.endYrInpt.Size = new System.Drawing.Size(100, 20);
            this.endYrInpt.TabIndex = 3;
            // 
            // eleCkBx
            // 
            this.eleCkBx.AutoSize = true;
            this.eleCkBx.Location = new System.Drawing.Point(70, 65);
            this.eleCkBx.Name = "eleCkBx";
            this.eleCkBx.Size = new System.Drawing.Size(192, 17);
            this.eleCkBx.TabIndex = 4;
            this.eleCkBx.Text = "Indicate Presidential Election Years";
            this.eleCkBx.UseVisualStyleBackColor = true;
            // 
            // censusCkBx
            // 
            this.censusCkBx.AutoSize = true;
            this.censusCkBx.Location = new System.Drawing.Point(70, 90);
            this.censusCkBx.Name = "censusCkBx";
            this.censusCkBx.Size = new System.Drawing.Size(132, 17);
            this.censusCkBx.TabIndex = 5;
            this.censusCkBx.Text = "Indicate Census Years";
            this.censusCkBx.UseVisualStyleBackColor = true;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(155, 121);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(47, 23);
            this.goBtn.TabIndex = 6;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // yrLst
            // 
            this.yrLst.FormattingEnabled = true;
            this.yrLst.Location = new System.Drawing.Point(28, 156);
            this.yrLst.Name = "yrLst";
            this.yrLst.Size = new System.Drawing.Size(298, 160);
            this.yrLst.TabIndex = 7;
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(145, 326);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 8;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 358);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.yrLst);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.censusCkBx);
            this.Controls.Add(this.eleCkBx);
            this.Controls.Add(this.endYrInpt);
            this.Controls.Add(this.startYrInput);
            this.Controls.Add(this.endYrLbl);
            this.Controls.Add(this.srtYrLbl);
            this.Name = "Form1";
            this.Text = "Looping, Mod Division, Listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label srtYrLbl;
        private System.Windows.Forms.Label endYrLbl;
        private System.Windows.Forms.TextBox startYrInput;
        private System.Windows.Forms.TextBox endYrInpt;
        private System.Windows.Forms.CheckBox eleCkBx;
        private System.Windows.Forms.CheckBox censusCkBx;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.ListBox yrLst;
        private System.Windows.Forms.Button clrBtn;
    }
}

