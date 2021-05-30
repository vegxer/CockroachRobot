namespace Робот_Таракан
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Field = new System.Windows.Forms.Panel();
            this.Group = new System.Windows.Forms.Panel();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.NewHeroBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.StepBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.Algorithm = new System.Windows.Forms.ListBox();
            this.timerAlgorithm = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.AllowDrop = true;
            this.Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Field.Location = new System.Drawing.Point(12, 12);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(426, 420);
            this.Field.TabIndex = 0;
            this.Field.DragDrop += new System.Windows.Forms.DragEventHandler(this.Field_DragDrop);
            this.Field.DragEnter += new System.Windows.Forms.DragEventHandler(this.Field_DragEnter);
            // 
            // Group
            // 
            this.Group.Controls.Add(this.btnChangeImage);
            this.Group.Controls.Add(this.btnDelete);
            this.Group.Controls.Add(this.NewHeroBtn);
            this.Group.Controls.Add(this.RunBtn);
            this.Group.Controls.Add(this.ClearBtn);
            this.Group.Controls.Add(this.StepBtn);
            this.Group.Controls.Add(this.LeftBtn);
            this.Group.Controls.Add(this.DownBtn);
            this.Group.Controls.Add(this.RightBtn);
            this.Group.Controls.Add(this.UpBtn);
            this.Group.Location = new System.Drawing.Point(444, 12);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(120, 420);
            this.Group.TabIndex = 1;
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(25, 298);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(75, 23);
            this.btnChangeImage.TabIndex = 9;
            this.btnChangeImage.Text = "New Shell";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // NewHeroBtn
            // 
            this.NewHeroBtn.Location = new System.Drawing.Point(25, 269);
            this.NewHeroBtn.Name = "NewHeroBtn";
            this.NewHeroBtn.Size = new System.Drawing.Size(75, 23);
            this.NewHeroBtn.TabIndex = 7;
            this.NewHeroBtn.Text = "New hero";
            this.NewHeroBtn.UseVisualStyleBackColor = true;
            this.NewHeroBtn.Click += new System.EventHandler(this.NewHeroBtn_Click);
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(25, 356);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(75, 23);
            this.RunBtn.TabIndex = 6;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(25, 385);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // StepBtn
            // 
            this.StepBtn.Location = new System.Drawing.Point(25, 129);
            this.StepBtn.Name = "StepBtn";
            this.StepBtn.Size = new System.Drawing.Size(75, 23);
            this.StepBtn.TabIndex = 4;
            this.StepBtn.Text = "Step";
            this.StepBtn.UseVisualStyleBackColor = true;
            this.StepBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(25, 100);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(75, 23);
            this.LeftBtn.TabIndex = 3;
            this.LeftBtn.Text = "Left";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(25, 71);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 2;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(25, 42);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(75, 23);
            this.RightBtn.TabIndex = 1;
            this.RightBtn.Text = "Right";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.UpBtn.Location = new System.Drawing.Point(25, 13);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpBtn.TabIndex = 0;
            this.UpBtn.Text = "Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Location = new System.Drawing.Point(570, 12);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(145, 420);
            this.Algorithm.TabIndex = 2;
            this.Algorithm.SelectedIndexChanged += new System.EventHandler(this.Algorithm_SelectedIndexChanged);
            // 
            // timerAlgorithm
            // 
            this.timerAlgorithm.Interval = 200;
            this.timerAlgorithm.Tick += new System.EventHandler(this.timerAlgorithm_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 444);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робот-Таракан";
            this.Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.Panel Group;
        private System.Windows.Forms.ListBox Algorithm;
        private System.Windows.Forms.Button NewHeroBtn;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button StepBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Timer timerAlgorithm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

