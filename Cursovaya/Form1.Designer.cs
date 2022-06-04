
namespace Cursovaya
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
            this.Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.Distance__Value1 = new System.Windows.Forms.TextBox();
            this.Distance__Value2 = new System.Windows.Forms.TextBox();
            this.Distance__Value4 = new System.Windows.Forms.TextBox();
            this.Distance__Value3 = new System.Windows.Forms.TextBox();
            this.Distance__Value6 = new System.Windows.Forms.TextBox();
            this.Distance__Value5 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.changeSizeOfMatrix = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(127, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(732, 67);
            this.Title.TabIndex = 0;
            this.Title.Text = "Введите расстояния в матрицу";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.28416F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.71584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label31, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label41, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label33, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label22, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label44, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Distance__Value1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Distance__Value2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Distance__Value4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Distance__Value3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Distance__Value6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Distance__Value5, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 449);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(307, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 111);
            this.label12.TabIndex = 30;
            this.label12.Text = "2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(94, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 111);
            this.label11.TabIndex = 29;
            this.label11.Text = "1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label21.Location = new System.Drawing.Point(5, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 109);
            this.label21.TabIndex = 27;
            this.label21.Text = "1";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label31.Location = new System.Drawing.Point(5, 226);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(81, 109);
            this.label31.TabIndex = 25;
            this.label31.Text = "2";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(556, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 111);
            this.label13.TabIndex = 23;
            this.label13.Text = "3";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label41.Location = new System.Drawing.Point(5, 337);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(81, 110);
            this.label41.TabIndex = 19;
            this.label41.Text = "3";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(307, 226);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(241, 109);
            this.label33.TabIndex = 9;
            this.label33.Text = "М";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(94, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(205, 109);
            this.label22.TabIndex = 8;
            this.label22.Text = "М";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.Location = new System.Drawing.Point(556, 337);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(279, 110);
            this.label44.TabIndex = 21;
            this.label44.Text = "M";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Distance__Value1
            // 
            this.Distance__Value1.BackColor = System.Drawing.SystemColors.Control;
            this.Distance__Value1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Distance__Value1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Distance__Value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance__Value1.Location = new System.Drawing.Point(307, 143);
            this.Distance__Value1.Margin = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.Distance__Value1.Name = "Distance__Value1";
            this.Distance__Value1.Size = new System.Drawing.Size(241, 48);
            this.Distance__Value1.TabIndex = 1;
            this.Distance__Value1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Distance__Value1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Distance_is_number);
            // 
            // Distance__Value2
            // 
            this.Distance__Value2.BackColor = System.Drawing.SystemColors.Control;
            this.Distance__Value2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Distance__Value2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Distance__Value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance__Value2.Location = new System.Drawing.Point(556, 143);
            this.Distance__Value2.Margin = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.Distance__Value2.Name = "Distance__Value2";
            this.Distance__Value2.Size = new System.Drawing.Size(279, 48);
            this.Distance__Value2.TabIndex = 2;
            this.Distance__Value2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Distance__Value2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Distance_is_number);
            // 
            // Distance__Value4
            // 
            this.Distance__Value4.BackColor = System.Drawing.SystemColors.Control;
            this.Distance__Value4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Distance__Value4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Distance__Value4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance__Value4.Location = new System.Drawing.Point(556, 254);
            this.Distance__Value4.Margin = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.Distance__Value4.Name = "Distance__Value4";
            this.Distance__Value4.Size = new System.Drawing.Size(279, 48);
            this.Distance__Value4.TabIndex = 4;
            this.Distance__Value4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Distance__Value4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Distance_is_number);
            // 
            // Distance__Value3
            // 
            this.Distance__Value3.BackColor = System.Drawing.SystemColors.Control;
            this.Distance__Value3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Distance__Value3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Distance__Value3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance__Value3.Location = new System.Drawing.Point(94, 254);
            this.Distance__Value3.Margin = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.Distance__Value3.Name = "Distance__Value3";
            this.Distance__Value3.Size = new System.Drawing.Size(205, 48);
            this.Distance__Value3.TabIndex = 3;
            this.Distance__Value3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Distance__Value3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Distance_is_number);
            // 
            // Distance__Value6
            // 
            this.Distance__Value6.BackColor = System.Drawing.SystemColors.Control;
            this.Distance__Value6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Distance__Value6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Distance__Value6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance__Value6.Location = new System.Drawing.Point(307, 365);
            this.Distance__Value6.Margin = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.Distance__Value6.Name = "Distance__Value6";
            this.Distance__Value6.Size = new System.Drawing.Size(241, 48);
            this.Distance__Value6.TabIndex = 6;
            this.Distance__Value6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Distance__Value6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Distance_is_number);
            // 
            // Distance__Value5
            // 
            this.Distance__Value5.BackColor = System.Drawing.SystemColors.Control;
            this.Distance__Value5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Distance__Value5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Distance__Value5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance__Value5.Location = new System.Drawing.Point(94, 365);
            this.Distance__Value5.Margin = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.Distance__Value5.Name = "Distance__Value5";
            this.Distance__Value5.Size = new System.Drawing.Size(205, 48);
            this.Distance__Value5.TabIndex = 5;
            this.Distance__Value5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Distance__Value5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Distance_is_number);
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Location = new System.Drawing.Point(939, 251);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(287, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Очистить поля";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calc
            // 
            this.Calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calc.Location = new System.Drawing.Point(939, 309);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(287, 23);
            this.Calc.TabIndex = 8;
            this.Calc.Text = "Рассчет кратчайшего пути";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // changeSizeOfMatrix
            // 
            this.changeSizeOfMatrix.Location = new System.Drawing.Point(939, 366);
            this.changeSizeOfMatrix.Name = "changeSizeOfMatrix";
            this.changeSizeOfMatrix.Size = new System.Drawing.Size(287, 23);
            this.changeSizeOfMatrix.TabIndex = 9;
            this.changeSizeOfMatrix.Text = "Изменить размер матрицы";
            this.changeSizeOfMatrix.UseVisualStyleBackColor = true;
            this.changeSizeOfMatrix.Click += new System.EventHandler(this.changeSizeOfMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 589);
            this.Controls.Add(this.changeSizeOfMatrix);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Поиск кратчайшего расстояния между городами";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox Distance__Value1;
        private System.Windows.Forms.TextBox Distance__Value2;
        private System.Windows.Forms.TextBox Distance__Value4;
        private System.Windows.Forms.TextBox Distance__Value3;
        private System.Windows.Forms.TextBox Distance__Value6;
        private System.Windows.Forms.TextBox Distance__Value5;
        private System.Windows.Forms.Button changeSizeOfMatrix;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
    }
}

