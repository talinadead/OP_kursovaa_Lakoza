namespace OP_kursovaa
{
    partial class FormSortGnomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSortGnomes));
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.textBoxSortNumbers = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxFromName = new System.Windows.Forms.TextBox();
            this.textBoxToName = new System.Windows.Forms.TextBox();
            this.textBoxCountName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(417, 172);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownCount.TabIndex = 3;
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(492, 12);
            this.textBoxNumbers.Multiline = true;
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.ReadOnly = true;
            this.textBoxNumbers.Size = new System.Drawing.Size(234, 81);
            this.textBoxNumbers.TabIndex = 4;
            // 
            // textBoxSortNumbers
            // 
            this.textBoxSortNumbers.Location = new System.Drawing.Point(492, 111);
            this.textBoxSortNumbers.Multiline = true;
            this.textBoxSortNumbers.Name = "textBoxSortNumbers";
            this.textBoxSortNumbers.ReadOnly = true;
            this.textBoxSortNumbers.Size = new System.Drawing.Size(234, 81);
            this.textBoxSortNumbers.TabIndex = 5;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(492, 209);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(111, 61);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(609, 209);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(117, 61);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Сгенерировать массив чисел";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(417, 209);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(69, 33);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очистить ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // textBoxFromName
            // 
            this.textBoxFromName.Location = new System.Drawing.Point(417, 12);
            this.textBoxFromName.Name = "textBoxFromName";
            this.textBoxFromName.ReadOnly = true;
            this.textBoxFromName.Size = new System.Drawing.Size(69, 20);
            this.textBoxFromName.TabIndex = 9;
            this.textBoxFromName.Text = "Минимум ";
            // 
            // textBoxToName
            // 
            this.textBoxToName.Location = new System.Drawing.Point(417, 85);
            this.textBoxToName.Name = "textBoxToName";
            this.textBoxToName.ReadOnly = true;
            this.textBoxToName.Size = new System.Drawing.Size(69, 20);
            this.textBoxToName.TabIndex = 10;
            this.textBoxToName.Text = "Максимум";
            // 
            // textBoxCountName
            // 
            this.textBoxCountName.Location = new System.Drawing.Point(417, 146);
            this.textBoxCountName.Name = "textBoxCountName";
            this.textBoxCountName.ReadOnly = true;
            this.textBoxCountName.Size = new System.Drawing.Size(69, 20);
            this.textBoxCountName.TabIndex = 11;
            this.textBoxCountName.Text = "Количество";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(417, 248);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 24);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(418, 38);
            this.textBoxFrom.Multiline = true;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(68, 20);
            this.textBoxFrom.TabIndex = 13;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(417, 111);
            this.textBoxTo.Multiline = true;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(68, 20);
            this.textBoxTo.TabIndex = 14;
            // 
            // FormSortGnomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OP_kursovaa.Properties.Resources._19e863e1;
            this.ClientSize = new System.Drawing.Size(735, 284);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxCountName);
            this.Controls.Add(this.textBoxToName);
            this.Controls.Add(this.textBoxFromName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxSortNumbers);
            this.Controls.Add(this.textBoxNumbers);
            this.Controls.Add(this.numericUpDownCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(751, 323);
            this.MinimumSize = new System.Drawing.Size(751, 323);
            this.Name = "FormSortGnomes";
            this.Text = "Гномья сортировка";
            this.Load += new System.EventHandler(this.FormSortGnomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.TextBox textBoxSortNumbers;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxFromName;
        private System.Windows.Forms.TextBox textBoxToName;
        private System.Windows.Forms.TextBox textBoxCountName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
    }
}

