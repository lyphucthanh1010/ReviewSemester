﻿namespace VietGraph
{
    partial class ThemBotBieuThuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemBotBieuThuc));
            this.clbExpression = new System.Windows.Forms.CheckedListBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbExpression
            // 
            this.clbExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbExpression.FormattingEnabled = true;
            this.clbExpression.Location = new System.Drawing.Point(16, 15);
            this.clbExpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbExpression.Name = "clbExpression";
            this.clbExpression.Size = new System.Drawing.Size(277, 130);
            this.clbExpression.TabIndex = 0;
            this.clbExpression.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(303, 15);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(100, 33);
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(303, 55);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Đóng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ThemBotBieuThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 182);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.clbExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThemBotBieuThuc";
            this.Text = "Thêm Bớt Biểu Thức";
            this.Load += new System.EventHandler(this.ThemBotBieuThuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbExpression;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnXoa;
    }
}