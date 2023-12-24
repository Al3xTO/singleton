namespace SingletonDemo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_NewForm = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvColDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvColDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ListFill = new System.Windows.Forms.Button();
            this.btn_ListDelItem = new System.Windows.Forms.Button();
            this.btn_ListClear = new System.Windows.Forms.Button();
            this.lbl_ListBtnStatus = new System.Windows.Forms.Label();
            this.btn_NewListView = new System.Windows.Forms.Button();
            this.btn_DelRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DocName,
            this.DocDescr});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grid_View_UserAddedRow);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DocName
            // 
            this.DocName.HeaderText = "Назва документу";
            this.DocName.Name = "DocName";
            this.DocName.Width = 200;
            // 
            // DocDescr
            // 
            this.DocDescr.HeaderText = "Опис документу";
            this.DocDescr.Name = "DocDescr";
            this.DocDescr.Width = 300;
            // 
            // btn_NewForm
            // 
            this.btn_NewForm.Location = new System.Drawing.Point(690, 338);
            this.btn_NewForm.Name = "btn_NewForm";
            this.btn_NewForm.Size = new System.Drawing.Size(98, 40);
            this.btn_NewForm.TabIndex = 1;
            this.btn_NewForm.Text = "Нова форма dataGridView";
            this.btn_NewForm.UseVisualStyleBackColor = true;
            this.btn_NewForm.Click += new System.EventHandler(this.btn_NewForm_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvColId,
            this.LvColDoc,
            this.LvColDesc});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 313);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 102);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvColId
            // 
            this.lvColId.Text = "ID";
            // 
            // LvColDoc
            // 
            this.LvColDoc.Text = "Назва";
            this.LvColDoc.Width = 150;
            // 
            // LvColDesc
            // 
            this.LvColDesc.Text = "Опис";
            this.LvColDesc.Width = 200;
            // 
            // btn_ListFill
            // 
            this.btn_ListFill.Location = new System.Drawing.Point(433, 313);
            this.btn_ListFill.Name = "btn_ListFill";
            this.btn_ListFill.Size = new System.Drawing.Size(109, 23);
            this.btn_ListFill.TabIndex = 3;
            this.btn_ListFill.Text = "Заповнити список";
            this.btn_ListFill.UseVisualStyleBackColor = true;
            this.btn_ListFill.Click += new System.EventHandler(this.btn_ListFill_Click);
            // 
            // btn_ListDelItem
            // 
            this.btn_ListDelItem.Location = new System.Drawing.Point(433, 342);
            this.btn_ListDelItem.Name = "btn_ListDelItem";
            this.btn_ListDelItem.Size = new System.Drawing.Size(109, 23);
            this.btn_ListDelItem.TabIndex = 3;
            this.btn_ListDelItem.Text = "Видалити елемент";
            this.btn_ListDelItem.UseVisualStyleBackColor = true;
            this.btn_ListDelItem.Click += new System.EventHandler(this.btn_ListDelItem_Click);
            // 
            // btn_ListClear
            // 
            this.btn_ListClear.Location = new System.Drawing.Point(433, 392);
            this.btn_ListClear.Name = "btn_ListClear";
            this.btn_ListClear.Size = new System.Drawing.Size(109, 23);
            this.btn_ListClear.TabIndex = 3;
            this.btn_ListClear.Text = "Очистити список";
            this.btn_ListClear.UseVisualStyleBackColor = true;
            this.btn_ListClear.Click += new System.EventHandler(this.btn_ListClear_Click);
            // 
            // lbl_ListBtnStatus
            // 
            this.lbl_ListBtnStatus.AutoSize = true;
            this.lbl_ListBtnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ListBtnStatus.Location = new System.Drawing.Point(12, 418);
            this.lbl_ListBtnStatus.Name = "lbl_ListBtnStatus";
            this.lbl_ListBtnStatus.Size = new System.Drawing.Size(85, 15);
            this.lbl_ListBtnStatus.TabIndex = 4;
            this.lbl_ListBtnStatus.Text = "                          ";
            // 
            // btn_NewListView
            // 
            this.btn_NewListView.Location = new System.Drawing.Point(690, 384);
            this.btn_NewListView.Name = "btn_NewListView";
            this.btn_NewListView.Size = new System.Drawing.Size(98, 38);
            this.btn_NewListView.TabIndex = 5;
            this.btn_NewListView.Text = "Нова форма listView";
            this.btn_NewListView.UseVisualStyleBackColor = true;
            this.btn_NewListView.Click += new System.EventHandler(this.btn_NewListView_Click);
            // 
            // btn_DelRow
            // 
            this.btn_DelRow.Location = new System.Drawing.Point(690, 12);
            this.btn_DelRow.Name = "btn_DelRow";
            this.btn_DelRow.Size = new System.Drawing.Size(98, 23);
            this.btn_DelRow.TabIndex = 6;
            this.btn_DelRow.Text = "Видалити строку";
            this.btn_DelRow.UseVisualStyleBackColor = true;
            this.btn_DelRow.Click += new System.EventHandler(this.btn_DelRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DelRow);
            this.Controls.Add(this.btn_NewListView);
            this.Controls.Add(this.lbl_ListBtnStatus);
            this.Controls.Add(this.btn_ListClear);
            this.Controls.Add(this.btn_ListDelItem);
            this.Controls.Add(this.btn_ListFill);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_NewForm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocDescr;
        private System.Windows.Forms.Button btn_NewForm;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lvColId;
        private System.Windows.Forms.ColumnHeader LvColDoc;
        private System.Windows.Forms.ColumnHeader LvColDesc;
        private System.Windows.Forms.Button btn_ListFill;
        private System.Windows.Forms.Button btn_ListDelItem;
        private System.Windows.Forms.Button btn_ListClear;
        private System.Windows.Forms.Label lbl_ListBtnStatus;
        private System.Windows.Forms.Button btn_NewListView;
        private System.Windows.Forms.Button btn_DelRow;
    }
}

