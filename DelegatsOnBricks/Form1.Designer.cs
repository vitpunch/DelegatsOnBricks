namespace DelegatsOnBricks
{
    partial class Form1
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
            this.textDices = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.buttonGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            this.SuspendLayout();
            // 
            // textDices
            // 
            this.textDices.Location = new System.Drawing.Point(13, 13);
            this.textDices.Name = "textDices";
            this.textDices.Size = new System.Drawing.Size(178, 22);
            this.textDices.TabIndex = 0;
            // 
            // labelSum
            // 
            this.labelSum.Location = new System.Drawing.Point(12, 76);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(179, 23);
            this.labelSum.TabIndex = 1;
            this.labelSum.Text = "label1";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(15, 128);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(76, 74);
            this.Box1.TabIndex = 2;
            this.Box1.TabStop = false;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(113, 128);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(78, 74);
            this.Box2.TabIndex = 3;
            this.Box2.TabStop = false;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(273, 12);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(96, 70);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Бросить кубики";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 458);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textDices);
            this.Name = "Form1";
            this.Text = "Игральные кубики";
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDices;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.Button buttonGo;
    }
}

