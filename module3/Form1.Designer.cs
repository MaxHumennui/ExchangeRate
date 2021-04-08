namespace module3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Summ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PIB = new System.Windows.Forms.TextBox();
            this.ExchangeField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.ComboBox();
            this.SummUAH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExchangeRateF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид операції";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Валюта";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OK.Location = new System.Drawing.Point(324, 325);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 31);
            this.OK.TabIndex = 2;
            this.OK.Text = "Готово";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Summ
            // 
            this.Summ.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summ.Location = new System.Drawing.Point(281, 175);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(171, 26);
            this.Summ.TabIndex = 4;
            this.Summ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Summ_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(226, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сума";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(231, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "ПІБ";
            // 
            // PIB
            // 
            this.PIB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PIB.Location = new System.Drawing.Point(281, 47);
            this.PIB.Name = "PIB";
            this.PIB.Size = new System.Drawing.Size(171, 26);
            this.PIB.TabIndex = 4;
            this.PIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PIB_KeyPress);
            // 
            // ExchangeField
            // 
            this.ExchangeField.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeField.Location = new System.Drawing.Point(598, 56);
            this.ExchangeField.Name = "ExchangeField";
            this.ExchangeField.Size = new System.Drawing.Size(71, 23);
            this.ExchangeField.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(604, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Курс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(174, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Паспорт №";
            // 
            // Passport
            // 
            this.Passport.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport.Location = new System.Drawing.Point(281, 79);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(171, 26);
            this.Passport.TabIndex = 4;
            this.Passport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Summ_KeyPress);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.White;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.History.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.Location = new System.Drawing.Point(12, 12);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(100, 62);
            this.History.TabIndex = 2;
            this.History.Text = "Історія операцій";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Operation
            // 
            this.Operation.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Operation.FormattingEnabled = true;
            this.Operation.Location = new System.Drawing.Point(281, 111);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(171, 26);
            this.Operation.TabIndex = 5;
            // 
            // SummUAH
            // 
            this.SummUAH.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummUAH.Location = new System.Drawing.Point(302, 267);
            this.SummUAH.Name = "SummUAH";
            this.SummUAH.Size = new System.Drawing.Size(124, 26);
            this.SummUAH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(298, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сума в гривнях";
            // 
            // ExchangeRateF
            // 
            this.ExchangeRateF.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeRateF.FormattingEnabled = true;
            this.ExchangeRateF.Location = new System.Drawing.Point(598, 29);
            this.ExchangeRateF.Name = "ExchangeRateF";
            this.ExchangeRateF.Size = new System.Drawing.Size(71, 23);
            this.ExchangeRateF.TabIndex = 5;
            this.ExchangeRateF.SelectionChangeCommitted += new System.EventHandler(this.Kurs_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(545, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Продаж";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(547, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Валюта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(547, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Купівля";
            // 
            // Currency
            // 
            this.Currency.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Currency.FormattingEnabled = true;
            this.Currency.Location = new System.Drawing.Point(281, 143);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(171, 26);
            this.Currency.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(598, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 23);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(681, 452);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.ExchangeRateF);
            this.Controls.Add(this.PIB);
            this.Controls.Add(this.SummUAH);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.History);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExchangeField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Summ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PIB;
        private System.Windows.Forms.TextBox ExchangeField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.ComboBox Operation;
        private System.Windows.Forms.ComboBox ExchangeRateF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SummUAH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.TextBox textBox2;
    }
}

