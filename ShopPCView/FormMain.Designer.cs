﻿namespace ShopPCView
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Справочники = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системныйблокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСистемблокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системныеблокиПоКомпонентамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonPayOrder = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Справочники,
            this.отчетыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(797, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // Справочники
            // 
            this.Справочники.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.системныйблокToolStripMenuItem});
            this.Справочники.Name = "Справочники";
            this.Справочники.Size = new System.Drawing.Size(94, 22);
            this.Справочники.Text = "Справочники";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.продуктыToolStripMenuItem_Click);
            // 
            // системныйблокToolStripMenuItem
            // 
            this.системныйблокToolStripMenuItem.Name = "системныйблокToolStripMenuItem";
            this.системныйблокToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.системныйблокToolStripMenuItem.Text = "Системный блок";
            this.системныйблокToolStripMenuItem.Click += new System.EventHandler(this.закускиToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСистемблокToolStripMenuItem,
            this.списокЗаказовToolStripMenuItem,
            this.системныеблокиПоКомпонентамToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // списокСистемблокToolStripMenuItem
            // 
            this.списокСистемблокToolStripMenuItem.Name = "списокСистемблокToolStripMenuItem";
            this.списокСистемблокToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.списокСистемблокToolStripMenuItem.Text = "Список системных блоков";
            this.списокСистемблокToolStripMenuItem.Click += new System.EventHandler(this.списокПродуктовToolStripMenuItem_Click);
            // 
            // списокЗаказовToolStripMenuItem
            // 
            this.списокЗаказовToolStripMenuItem.Name = "списокЗаказовToolStripMenuItem";
            this.списокЗаказовToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.списокЗаказовToolStripMenuItem.Text = "Список заказов";
            this.списокЗаказовToolStripMenuItem.Click += new System.EventHandler(this.списокЗаказовToolStripMenuItem_Click);
            // 
            // системныеблокиПоКомпонентамToolStripMenuItem
            // 
            this.системныеблокиПоКомпонентамToolStripMenuItem.Name = "системныеблокиПоКомпонентамToolStripMenuItem";
            this.системныеблокиПоКомпонентамToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.системныеблокиПоКомпонентамToolStripMenuItem.Text = "Системные блоки по компонентам";
            this.системныеблокиПоКомпонентамToolStripMenuItem.Click += new System.EventHandler(this.закускиПоПродуктамToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 32);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(624, 290);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(644, 32);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(132, 25);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(644, 61);
            this.buttonTakeOrderInWork.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(132, 29);
            this.buttonTakeOrderInWork.TabIndex = 2;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.ButtonTakeOrderInWork_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(644, 94);
            this.buttonOrderReady.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(132, 26);
            this.buttonOrderReady.TabIndex = 2;
            this.buttonOrderReady.Text = "Заказ готов";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.ButtonOrderReady_Click);
            // 
            // buttonPayOrder
            // 
            this.buttonPayOrder.Location = new System.Drawing.Point(644, 124);
            this.buttonPayOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayOrder.Name = "buttonPayOrder";
            this.buttonPayOrder.Size = new System.Drawing.Size(132, 26);
            this.buttonPayOrder.TabIndex = 2;
            this.buttonPayOrder.Text = "Заказ оплачен";
            this.buttonPayOrder.UseVisualStyleBackColor = true;
            this.buttonPayOrder.Click += new System.EventHandler(this.ButtonPayOrder_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(644, 154);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(132, 27);
            this.buttonRef.TabIndex = 2;
            this.buttonRef.Text = "Обновить список";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 333);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonPayOrder);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Магазин ПК";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Справочники;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системныйблокToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonOrderReady;
        private System.Windows.Forms.Button buttonPayOrder;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСистемблокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системныеблокиПоКомпонентамToolStripMenuItem;
    }
}