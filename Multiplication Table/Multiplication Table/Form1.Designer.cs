
namespace Multiplication_Table
{
    partial class multiplicationTable
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
            this.lblMultiplicationTavle = new System.Windows.Forms.Label();
            this.cmbMultiplier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMultiplicationTavle
            // 
            this.lblMultiplicationTavle.AutoSize = true;
            this.lblMultiplicationTavle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMultiplicationTavle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblMultiplicationTavle.Location = new System.Drawing.Point(398, 19);
            this.lblMultiplicationTavle.Name = "lblMultiplicationTavle";
            this.lblMultiplicationTavle.Size = new System.Drawing.Size(503, 58);
            this.lblMultiplicationTavle.TabIndex = 0;
            this.lblMultiplicationTavle.Text = "Multiplication Table";
            // 
            // cmbMultiplier
            // 
            this.cmbMultiplier.FormattingEnabled = true;
            this.cmbMultiplier.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cmbMultiplier.Location = new System.Drawing.Point(575, 90);
            this.cmbMultiplier.Name = "cmbMultiplier";
            this.cmbMultiplier.Size = new System.Drawing.Size(141, 28);
            this.cmbMultiplier.TabIndex = 1;
            this.cmbMultiplier.Text = "    ";
            this.cmbMultiplier.SelectedIndexChanged += new System.EventHandler(this.cmbMultiplier_SelectedIndexChanged);
            // 
            // multiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1281, 763);
            this.Controls.Add(this.cmbMultiplier);
            this.Controls.Add(this.lblMultiplicationTavle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "multiplicationTable";
            this.Text = "Multiplication Table";
            this.Load += new System.EventHandler(this.multiplicationTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMultiplicationTavle;
        private System.Windows.Forms.ComboBox cmbMultiplier;
    }
}

