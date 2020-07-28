namespace CourseManager
{
    partial class CourseViewer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.viewOffices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(29, 332);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(121, 21);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // closeForm
            // 
            this.closeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeForm.Location = new System.Drawing.Point(29, 390);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(121, 39);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "Закрыть";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            this.closeForm.MouseLeave += new System.EventHandler(this.closeForm_MouseLeave);
            this.closeForm.MouseHover += new System.EventHandler(this.closeForm_MouseHover);
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(12, 12);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.Size = new System.Drawing.Size(776, 282);
            this.courseGridView.TabIndex = 2;
            // 
            // saveChanges
            // 
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.Location = new System.Drawing.Point(193, 390);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(105, 39);
            this.saveChanges.TabIndex = 3;
            this.saveChanges.Text = "Обновить";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            this.saveChanges.MouseLeave += new System.EventHandler(this.saveChanges_MouseLeave);
            this.saveChanges.MouseHover += new System.EventHandler(this.saveChanges_MouseHover);
            // 
            // viewOffices
            // 
            this.viewOffices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewOffices.Location = new System.Drawing.Point(355, 390);
            this.viewOffices.Name = "viewOffices";
            this.viewOffices.Size = new System.Drawing.Size(105, 39);
            this.viewOffices.TabIndex = 4;
            this.viewOffices.Text = "View Offices";
            this.viewOffices.UseVisualStyleBackColor = true;
            this.viewOffices.Click += new System.EventHandler(this.viewOffices_Click);
            this.viewOffices.MouseLeave += new System.EventHandler(this.viewOffices_MouseLeave);
            this.viewOffices.MouseHover += new System.EventHandler(this.viewOffices_MouseHover);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewOffices);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.departmentList);
            this.Name = "CourseViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button viewOffices;
    }
}

