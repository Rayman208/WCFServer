namespace WCFClient
{
    partial class FormStockClient
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
            this.buttonGetCurrentRubleCourse = new System.Windows.Forms.Button();
            this.textBoxRubleCourse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGetCurrentRubleCourse
            // 
            this.buttonGetCurrentRubleCourse.Location = new System.Drawing.Point(13, 13);
            this.buttonGetCurrentRubleCourse.Name = "buttonGetCurrentRubleCourse";
            this.buttonGetCurrentRubleCourse.Size = new System.Drawing.Size(398, 29);
            this.buttonGetCurrentRubleCourse.TabIndex = 0;
            this.buttonGetCurrentRubleCourse.Text = "Получить курс рубля на текущий день";
            this.buttonGetCurrentRubleCourse.UseVisualStyleBackColor = true;
            this.buttonGetCurrentRubleCourse.Click += new System.EventHandler(this.buttonGetCurrentRubleCourse_Click);
            // 
            // textBoxRubleCourse
            // 
            this.textBoxRubleCourse.Location = new System.Drawing.Point(13, 49);
            this.textBoxRubleCourse.Name = "textBoxRubleCourse";
            this.textBoxRubleCourse.ReadOnly = true;
            this.textBoxRubleCourse.Size = new System.Drawing.Size(398, 22);
            this.textBoxRubleCourse.TabIndex = 1;
            // 
            // FormStockClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 324);
            this.Controls.Add(this.textBoxRubleCourse);
            this.Controls.Add(this.buttonGetCurrentRubleCourse);
            this.Name = "FormStockClient";
            this.Text = "FormStockClient";
            this.Load += new System.EventHandler(this.FormStockClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetCurrentRubleCourse;
        private System.Windows.Forms.TextBox textBoxRubleCourse;
    }
}

