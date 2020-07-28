namespace CourseManager
{
    partial class OfficeAssignment
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
            this.officeGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // officeGridView
            // 
            this.officeGridView.AllowUserToAddRows = false;
            this.officeGridView.AllowUserToDeleteRows = false;
            this.officeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeGridView.Location = new System.Drawing.Point(29, 28);
            this.officeGridView.Name = "officeGridView";
            this.officeGridView.Size = new System.Drawing.Size(410, 230);
            this.officeGridView.TabIndex = 0;
            // 
            // saveChanges
            // 
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.Location = new System.Drawing.Point(169, 290);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(117, 47);
            this.saveChanges.TabIndex = 1;
            this.saveChanges.Text = "Update";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            this.saveChanges.MouseLeave += new System.EventHandler(this.saveChanges_MouseLeave);
            this.saveChanges.MouseHover += new System.EventHandler(this.saveChanges_MouseHover);
            // 
            // OfficeAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 354);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.officeGridView);
            this.Name = "OfficeAssignment";
            this.Text = "OfficeAssignment";
            this.Load += new System.EventHandler(this.OfficeAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView officeGridView;
        private System.Windows.Forms.Button saveChanges;
    }
}