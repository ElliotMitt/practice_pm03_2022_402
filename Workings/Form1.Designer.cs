﻿namespace Workings
{
    partial class FormMain
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(196)))));
            this.labelTitle.Location = new System.Drawing.Point(55, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(261, 58);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "База данных \"Компьютерный магазин\"";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCategory
            // 
            this.buttonCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategory.Location = new System.Drawing.Point(75, 90);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(241, 44);
            this.buttonCategory.TabIndex = 1;
            this.buttonCategory.Text = "Таблица \"Категории\"";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItems.Location = new System.Drawing.Point(75, 153);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(241, 44);
            this.buttonItems.TabIndex = 2;
            this.buttonItems.Text = "Таблица \"Товары\"";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.Location = new System.Drawing.Point(75, 224);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(241, 44);
            this.buttonOrders.TabIndex = 3;
            this.buttonOrders.Text = "Таблица \"Заказы\"";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUsers.Location = new System.Drawing.Point(75, 295);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(241, 44);
            this.buttonUsers.TabIndex = 4;
            this.buttonUsers.Text = "Таблица \"Пользователи\"";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 428);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonCategory);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Главная страница";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonUsers;
    }
}

