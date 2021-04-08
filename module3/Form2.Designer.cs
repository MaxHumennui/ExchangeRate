namespace module3
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Filtr = new System.Windows.Forms.ComboBox();
            this.Variable = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // Filtr
            // 
            this.Filtr.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filtr.FormattingEnabled = true;
            this.Filtr.Location = new System.Drawing.Point(61, 10);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(121, 26);
            this.Filtr.TabIndex = 1;
            this.Filtr.SelectionChangeCommitted += new System.EventHandler(this.Filtr_SelectionChangeCommitted);
            // 
            // Variable
            // 
            this.Variable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Variable.FormattingEnabled = true;
            this.Variable.Location = new System.Drawing.Point(188, 10);
            this.Variable.Name = "Variable";
            this.Variable.Size = new System.Drawing.Size(121, 26);
            this.Variable.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(655, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 29);
            this.Search.TabIndex = 2;
            this.Search.Text = "Шукати";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фільтр";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Variable);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Filtr;
        private System.Windows.Forms.ComboBox Variable;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
    }
}