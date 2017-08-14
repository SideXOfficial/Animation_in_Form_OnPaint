namespace SideX_Form
{
    partial class SideX_Form_Preview
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
            this.customControl1 = new CustomControl.CustomGraphics();
            this.SuspendLayout();
            // 
            // customControl1
            // 
            this.customControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customControl1.Location = new System.Drawing.Point(0, 0);
            this.customControl1.Margin = new System.Windows.Forms.Padding(0);
            this.customControl1.Name = "customControl1";
            this.customControl1.Show_Info = true;
            this.customControl1.Size = new System.Drawing.Size(688, 300);
            this.customControl1.TabIndex = 0;
            this.customControl1.Value = 8;
            // 
            // SideX_Form_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 300);
            this.Controls.Add(this.customControl1);
            this.DoubleBuffered = true;
            this.Name = "SideX_Form_Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.CustomGraphics customControl1;
    }
}

