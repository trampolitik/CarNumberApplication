namespace Mallenom.BD
{
	partial class Main
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
			this._txtNumberName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._btnAdd = new System.Windows.Forms.Button();
			this._btnDeleteCars = new System.Windows.Forms.Button();
			this._btnUpdate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this._txtIdCamer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._txtSearchIdCamer = new System.Windows.Forms.TextBox();
			this._btnSearchIdCamer = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.дополнительныеПозможностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._miSortOfId = new System.Windows.Forms.ToolStripMenuItem();
			this._miSortOfByNumberCars = new System.Windows.Forms.ToolStripMenuItem();
			this._miSortByData = new System.Windows.Forms.ToolStripMenuItem();
			this._btnDeleteOneThing = new System.Windows.Forms.Button();
			this._txtId = new System.Windows.Forms.Label();
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
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClick);
			// 
			// _txtNumberName
			// 
			this._txtNumberName.Location = new System.Drawing.Point(555, 17);
			this._txtNumberName.Name = "_txtNumberName";
			this._txtNumberName.Size = new System.Drawing.Size(128, 23);
			this._txtNumberName.TabIndex = 1;
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
			// _btnAdd
			// 
			this._btnAdd.Location = new System.Drawing.Point(689, 17);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(75, 52);
			this._btnAdd.TabIndex = 4;
			this._btnAdd.Text = "Добавить Машину";
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.Click += new System.EventHandler(this.OnAddButtonClick);
			// 
			// _btnDeleteCars
			// 
			this._btnDeleteCars.Location = new System.Drawing.Point(634, 268);
			this._btnDeleteCars.Name = "_btnDeleteCars";
			this._btnDeleteCars.Size = new System.Drawing.Size(126, 53);
			this._btnDeleteCars.TabIndex = 5;
			this._btnDeleteCars.Text = "Удаление всех элементов с данным номером";
			this._btnDeleteCars.UseVisualStyleBackColor = true;
			this._btnDeleteCars.Click += new System.EventHandler(this.OnDeleteManyCarsClick);
			// 
			// _btnUpdate
			// 
			this._btnUpdate.Location = new System.Drawing.Point(634, 327);
			this._btnUpdate.Name = "_btnUpdate";
			this._btnUpdate.Size = new System.Drawing.Size(127, 31);
			this._btnUpdate.TabIndex = 7;
			this._btnUpdate.Text = "Загрузить/обновить";
			this._btnUpdate.UseVisualStyleBackColor = true;
			this._btnUpdate.Click += new System.EventHandler(this.OnUpdateClick);
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
			// _txtIdCamer
			// 
			this._txtIdCamer.Location = new System.Drawing.Point(555, 46);
			this._txtIdCamer.Name = "_txtIdCamer";
			this._txtIdCamer.Size = new System.Drawing.Size(128, 23);
			this._txtIdCamer.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(449, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 32);
			this.label3.TabIndex = 14;
			this.label3.Text = "поиск по id или номеру ";
			// 
			// _txtSearchIdCamer
			// 
			this._txtSearchIdCamer.Location = new System.Drawing.Point(555, 86);
			this._txtSearchIdCamer.Name = "_txtSearchIdCamer";
			this._txtSearchIdCamer.Size = new System.Drawing.Size(128, 23);
			this._txtSearchIdCamer.TabIndex = 11;
			// 
			// _btnSearchIdCamer
			// 
			this._btnSearchIdCamer.Location = new System.Drawing.Point(689, 86);
			this._btnSearchIdCamer.Name = "_btnSearchIdCamer";
			this._btnSearchIdCamer.Size = new System.Drawing.Size(75, 23);
			this._btnSearchIdCamer.TabIndex = 0;
			this._btnSearchIdCamer.Text = "Поиск";
			this._btnSearchIdCamer.Click += new System.EventHandler(this.OnSearchClick);
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
            this._miSortOfId,
            this._miSortOfByNumberCars,
            this._miSortByData});
			this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
			this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сортировкаToolStripMenuItem.Text = "Сортировка ";
			// 
			// _miSortOfId
			// 
			this._miSortOfId.Name = "_miSortOfId";
			this._miSortOfId.Size = new System.Drawing.Size(254, 22);
			this._miSortOfId.Text = "Сортировка по id";
			this._miSortOfId.Click += new System.EventHandler(this.OnSortIdClick);
			// 
			// _miSortOfByNumberCars
			// 
			this._miSortOfByNumberCars.Name = "_miSortOfByNumberCars";
			this._miSortOfByNumberCars.Size = new System.Drawing.Size(254, 22);
			this._miSortOfByNumberCars.Text = "Сортировка по номеру машины";
			this._miSortOfByNumberCars.Click += new System.EventHandler(this.OnSortNumberCarsClick);
			// 
			// _miSortByData
			// 
			this._miSortByData.Name = "_miSortByData";
			this._miSortByData.Size = new System.Drawing.Size(254, 22);
			this._miSortByData.Text = "Сортировка по дате ";
			this._miSortByData.Click += new System.EventHandler(this.OnSortDataClick);
			// 
			// _btnDeleteOneThing
			// 
			this._btnDeleteOneThing.Location = new System.Drawing.Point(480, 126);
			this._btnDeleteOneThing.Name = "_btnDeleteOneThing";
			this._btnDeleteOneThing.Size = new System.Drawing.Size(179, 22);
			this._btnDeleteOneThing.TabIndex = 16;
			this._btnDeleteOneThing.Text = "Удалить выбранный элемент ";
			this._btnDeleteOneThing.Click += new System.EventHandler(this.OnDeleteClick);
			// 
			// _txtId
			// 
			this._txtId.Location = new System.Drawing.Point(449, 130);
			this._txtId.Name = "_txtId";
			this._txtId.Size = new System.Drawing.Size(25, 25);
			this._txtId.TabIndex = 17;
			this._txtId.Text = "id";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 370);
			this.Controls.Add(this._btnDeleteOneThing);
			this.Controls.Add(this._txtId);
			this.Controls.Add(this._btnSearchIdCamer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._txtSearchIdCamer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._txtIdCamer);
			this.Controls.Add(this._btnUpdate);
			this.Controls.Add(this._btnDeleteCars);
			this.Controls.Add(this._btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._txtNumberName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Car Application";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox _txtNumberName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Button _btnDeleteCars;
		private System.Windows.Forms.Button _btnUpdate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txtIdCamer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _txtSearchIdCamer;
		private System.Windows.Forms.Button _btnSearchIdCamer;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem дополнительныеПозможностиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _miSortOfId;
		private System.Windows.Forms.ToolStripMenuItem _miSortOfByNumberCars;
		private System.Windows.Forms.ToolStripMenuItem _miSortByData;
		private System.Windows.Forms.Button _btnDeleteOneThing;
		private System.Windows.Forms.Label _txtId;
	}
}
