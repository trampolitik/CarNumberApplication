namespace Mallenom.BD
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox_NumberName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button_add = new System.Windows.Forms.Button();
			this.deleteOneThing_button1 = new System.Windows.Forms.Button();
			this.Button_dounload_update = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_idCamer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_searchIdCamer = new System.Windows.Forms.TextBox();
			this.button_searchIdCamer = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.дополнительныеПозможностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortOfId_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortOfByNumberCars_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortByData_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button_DeleteCar = new System.Windows.Forms.Button();
			this.label_delete = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(431, 331);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// textBox_NumberName
			// 
			this.textBox_NumberName.Location = new System.Drawing.Point(555, 17);
			this.textBox_NumberName.Name = "textBox_NumberName";
			this.textBox_NumberName.Size = new System.Drawing.Size(128, 23);
			this.textBox_NumberName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(449, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Номер машины ";
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(689, 17);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(75, 52);
			this.button_add.TabIndex = 4;
			this.button_add.Text = "Добавить Машину";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.add_button_Click);
			// 
			// deleteOneThing_button1
			// 
			this.deleteOneThing_button1.Location = new System.Drawing.Point(634, 268);
			this.deleteOneThing_button1.Name = "deleteOneThing_button1";
			this.deleteOneThing_button1.Size = new System.Drawing.Size(126, 53);
			this.deleteOneThing_button1.TabIndex = 5;
			this.deleteOneThing_button1.Text = "Удаление всех элементов с данным номером";
			this.deleteOneThing_button1.UseVisualStyleBackColor = true;
			this.deleteOneThing_button1.Click += new System.EventHandler(this.deleteOneThing_button1_Click);
			// 
			// Button_dounload_update
			// 
			this.Button_dounload_update.Location = new System.Drawing.Point(634, 327);
			this.Button_dounload_update.Name = "Button_dounload_update";
			this.Button_dounload_update.Size = new System.Drawing.Size(127, 31);
			this.Button_dounload_update.TabIndex = 7;
			this.Button_dounload_update.Text = "Загрузить/обновить";
			this.Button_dounload_update.UseVisualStyleBackColor = true;
			this.Button_dounload_update.Click += new System.EventHandler(this.dounload_update_Button_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(465, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "Id камеры ";
			// 
			// textBox_idCamer
			// 
			this.textBox_idCamer.Location = new System.Drawing.Point(555, 46);
			this.textBox_idCamer.Name = "textBox_idCamer";
			this.textBox_idCamer.Size = new System.Drawing.Size(128, 23);
			this.textBox_idCamer.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(449, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 32);
			this.label3.TabIndex = 14;
			this.label3.Text = "поиск по id или номеру ";
			// 
			// textBox_searchIdCamer
			// 
			this.textBox_searchIdCamer.Location = new System.Drawing.Point(555, 86);
			this.textBox_searchIdCamer.Name = "textBox_searchIdCamer";
			this.textBox_searchIdCamer.Size = new System.Drawing.Size(128, 23);
			this.textBox_searchIdCamer.TabIndex = 11;
			// 
			// button_searchIdCamer
			// 
			this.button_searchIdCamer.Location = new System.Drawing.Point(689, 86);
			this.button_searchIdCamer.Name = "button_searchIdCamer";
			this.button_searchIdCamer.Size = new System.Drawing.Size(75, 23);
			this.button_searchIdCamer.TabIndex = 0;
			this.button_searchIdCamer.Text = "Поиск";
			this.button_searchIdCamer.Click += new System.EventHandler(this.button_searchIdCamer_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дополнительныеПозможностиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(773, 24);
			this.menuStrip1.TabIndex = 15;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// дополнительныеПозможностиToolStripMenuItem
			// 
			this.дополнительныеПозможностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem});
			this.дополнительныеПозможностиToolStripMenuItem.Name = "дополнительныеПозможностиToolStripMenuItem";
			this.дополнительныеПозможностиToolStripMenuItem.Size = new System.Drawing.Size(194, 20);
			this.дополнительныеПозможностиToolStripMenuItem.Text = "Дополнительные позможности";
			// 
			// сортировкаToolStripMenuItem
			// 
			this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortOfId_ToolStripMenuItem,
            this.sortOfByNumberCars_ToolStripMenuItem,
            this.sortByData_ToolStripMenuItem});
			this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
			this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.сортировкаToolStripMenuItem.Text = "Сортировка ";
			// 
			// sortOfId_ToolStripMenuItem
			// 
			this.sortOfId_ToolStripMenuItem.Name = "sortOfId_ToolStripMenuItem";
			this.sortOfId_ToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.sortOfId_ToolStripMenuItem.Text = "Сортировка по id";
			this.sortOfId_ToolStripMenuItem.Click += new System.EventHandler(this.sortOfId_ToolStripMenuItem_Click);
			// 
			// sortOfByNumberCars_ToolStripMenuItem
			// 
			this.sortOfByNumberCars_ToolStripMenuItem.Name = "sortOfByNumberCars_ToolStripMenuItem";
			this.sortOfByNumberCars_ToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.sortOfByNumberCars_ToolStripMenuItem.Text = "Сортировка по номеру машины";
			this.sortOfByNumberCars_ToolStripMenuItem.Click += new System.EventHandler(this.sortOfByNumberCars_ToolStripMenuItem_Click);
			// 
			// sortByData_ToolStripMenuItem
			// 
			this.sortByData_ToolStripMenuItem.Name = "sortByData_ToolStripMenuItem";
			this.sortByData_ToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.sortByData_ToolStripMenuItem.Text = "Сортировка по дате ";
			this.sortByData_ToolStripMenuItem.Click += new System.EventHandler(this.sortByData_ToolStripMenuItem_Click);
			// 
			// button_DeleteCar
			// 
			this.button_DeleteCar.Location = new System.Drawing.Point(480, 126);
			this.button_DeleteCar.Name = "button_DeleteCar";
			this.button_DeleteCar.Size = new System.Drawing.Size(179, 22);
			this.button_DeleteCar.TabIndex = 16;
			this.button_DeleteCar.Text = "Удалить выбранный элемент ";
			this.button_DeleteCar.Click += new System.EventHandler(this.button_DeleteCar_Click);
			// 
			// label_delete
			// 
			this.label_delete.Location = new System.Drawing.Point(449, 130);
			this.label_delete.Name = "label_delete";
			this.label_delete.Size = new System.Drawing.Size(25, 25);
			this.label_delete.TabIndex = 17;
			this.label_delete.Text = "id";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 370);
			this.Controls.Add(this.button_DeleteCar);
			this.Controls.Add(this.label_delete);
			this.Controls.Add(this.button_searchIdCamer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_searchIdCamer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_idCamer);
			this.Controls.Add(this.Button_dounload_update);
			this.Controls.Add(this.deleteOneThing_button1);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_NumberName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox_NumberName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button deleteOneThing_button1;
		private System.Windows.Forms.Button Button_dounload_update;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_idCamer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_searchIdCamer;
		private System.Windows.Forms.Button button_searchIdCamer;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem дополнительныеПозможностиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortOfId_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortOfByNumberCars_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortByData_ToolStripMenuItem;
		private System.Windows.Forms.Button button_DeleteCar;
		private System.Windows.Forms.Label label_delete;
	}
}
