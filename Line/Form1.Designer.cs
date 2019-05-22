namespace Line
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.pb_Result_B = new System.Windows.Forms.PictureBox();
            this.nud_Max = new System.Windows.Forms.NumericUpDown();
            this.nud_Min = new System.Windows.Forms.NumericUpDown();
            this.nud_A = new System.Windows.Forms.NumericUpDown();
            this.nud_B = new System.Windows.Forms.NumericUpDown();
            this.dgv_PayMatrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Result_A = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayMatrix)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_A)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(575, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Create.Location = new System.Drawing.Point(575, 20);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(134, 42);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Generate.Location = new System.Drawing.Point(575, 66);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(134, 44);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // pb_Result_B
            // 
            this.pb_Result_B.BackColor = System.Drawing.Color.White;
            this.pb_Result_B.Location = new System.Drawing.Point(734, 20);
            this.pb_Result_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Result_B.Name = "pb_Result_B";
            this.pb_Result_B.Size = new System.Drawing.Size(54, 54);
            this.pb_Result_B.TabIndex = 5;
            this.pb_Result_B.TabStop = false;
            this.pb_Result_B.Visible = false;
            this.pb_Result_B.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Result_Paint);
            // 
            // nud_Max
            // 
            this.nud_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_Max.Location = new System.Drawing.Point(137, 26);
            this.nud_Max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_Max.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_Max.Name = "nud_Max";
            this.nud_Max.Size = new System.Drawing.Size(60, 26);
            this.nud_Max.TabIndex = 7;
            this.nud_Max.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nud_Min
            // 
            this.nud_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_Min.Location = new System.Drawing.Point(137, 62);
            this.nud_Min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_Min.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud_Min.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.nud_Min.Name = "nud_Min";
            this.nud_Min.Size = new System.Drawing.Size(60, 26);
            this.nud_Min.TabIndex = 8;
            this.nud_Min.Value = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            // 
            // nud_A
            // 
            this.nud_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_A.Location = new System.Drawing.Point(110, 26);
            this.nud_A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_A.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_A.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_A.Name = "nud_A";
            this.nud_A.Size = new System.Drawing.Size(180, 26);
            this.nud_A.TabIndex = 7;
            this.nud_A.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_B
            // 
            this.nud_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_B.Location = new System.Drawing.Point(110, 62);
            this.nud_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_B.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_B.Name = "nud_B";
            this.nud_B.Size = new System.Drawing.Size(180, 26);
            this.nud_B.TabIndex = 7;
            this.nud_B.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // dgv_PayMatrix
            // 
            this.dgv_PayMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PayMatrix.Location = new System.Drawing.Point(103, 159);
            this.dgv_PayMatrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_PayMatrix.Name = "dgv_PayMatrix";
            this.dgv_PayMatrix.Size = new System.Drawing.Size(534, 342);
            this.dgv_PayMatrix.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Максимальний";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Гравець А";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(319, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Гравець В";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Гравець А";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Гравець В";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_A);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nud_B);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кількість стратегій";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_Max);
            this.groupBox2.Controls.Add(this.nud_Min);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(335, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Платежі";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Максимальний";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_Result_A
            // 
            this.pb_Result_A.BackColor = System.Drawing.Color.White;
            this.pb_Result_A.Location = new System.Drawing.Point(734, 20);
            this.pb_Result_A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Result_A.Name = "pb_Result_A";
            this.pb_Result_A.Size = new System.Drawing.Size(101, 73);
            this.pb_Result_A.TabIndex = 5;
            this.pb_Result_A.TabStop = false;
            this.pb_Result_A.Visible = false;
            this.pb_Result_A.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Result_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_PayMatrix);
            this.Controls.Add(this.pb_Result_B);
            this.Controls.Add(this.pb_Result_A);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Розв\'язування матричних задач Pay Matrix Solution v.0.3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayMatrix)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.PictureBox pb_Result_B;
        private System.Windows.Forms.NumericUpDown nud_Max;
        private System.Windows.Forms.NumericUpDown nud_Min;
        private System.Windows.Forms.NumericUpDown nud_A;
        private System.Windows.Forms.NumericUpDown nud_B;
        private System.Windows.Forms.DataGridView dgv_PayMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Result_A;
    }
}

