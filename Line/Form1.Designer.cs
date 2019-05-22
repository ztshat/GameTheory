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
            this.pb_Result_A = new System.Windows.Forms.PictureBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.pb_Result_B = new System.Windows.Forms.PictureBox();
            this.nud_Max = new System.Windows.Forms.NumericUpDown();
            this.nud_Min = new System.Windows.Forms.NumericUpDown();
            this.nud_A = new System.Windows.Forms.NumericUpDown();
            this.nud_B = new System.Windows.Forms.NumericUpDown();
            this.dgv_PayMatrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(275, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_Result_A
            // 
            this.pb_Result_A.BackColor = System.Drawing.Color.White;
            this.pb_Result_A.Location = new System.Drawing.Point(374, 12);
            this.pb_Result_A.Name = "pb_Result_A";
            this.pb_Result_A.Size = new System.Drawing.Size(500, 500);
            this.pb_Result_A.TabIndex = 5;
            this.pb_Result_A.TabStop = false;
            this.pb_Result_A.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Result_Paint);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Create.Location = new System.Drawing.Point(8, 292);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(89, 30);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Generate.Location = new System.Drawing.Point(136, 292);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(89, 30);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // pb_Result_B
            // 
            this.pb_Result_B.BackColor = System.Drawing.Color.White;
            this.pb_Result_B.Location = new System.Drawing.Point(880, 12);
            this.pb_Result_B.Name = "pb_Result_B";
            this.pb_Result_B.Size = new System.Drawing.Size(500, 500);
            this.pb_Result_B.TabIndex = 5;
            this.pb_Result_B.TabStop = false;
            this.pb_Result_B.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Result_Paint);
            // 
            // nud_Max
            // 
            this.nud_Max.Location = new System.Drawing.Point(244, 12);
            this.nud_Max.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_Max.Name = "nud_Max";
            this.nud_Max.Size = new System.Drawing.Size(120, 20);
            this.nud_Max.TabIndex = 7;
            this.nud_Max.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nud_Min
            // 
            this.nud_Min.Location = new System.Drawing.Point(244, 38);
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
            this.nud_Min.Size = new System.Drawing.Size(120, 20);
            this.nud_Min.TabIndex = 8;
            this.nud_Min.Value = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            // 
            // nud_A
            // 
            this.nud_A.Location = new System.Drawing.Point(56, 12);
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
            this.nud_A.Size = new System.Drawing.Size(120, 20);
            this.nud_A.TabIndex = 7;
            this.nud_A.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_B
            // 
            this.nud_B.Location = new System.Drawing.Point(56, 38);
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
            this.nud_B.Size = new System.Drawing.Size(120, 20);
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
            this.dgv_PayMatrix.Location = new System.Drawing.Point(8, 64);
            this.dgv_PayMatrix.Name = "dgv_PayMatrix";
            this.dgv_PayMatrix.Size = new System.Drawing.Size(356, 222);
            this.dgv_PayMatrix.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_PayMatrix);
            this.Controls.Add(this.nud_Min);
            this.Controls.Add(this.nud_B);
            this.Controls.Add(this.nud_A);
            this.Controls.Add(this.nud_Max);
            this.Controls.Add(this.pb_Result_B);
            this.Controls.Add(this.pb_Result_A);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_Result_A;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.PictureBox pb_Result_B;
        private System.Windows.Forms.NumericUpDown nud_Max;
        private System.Windows.Forms.NumericUpDown nud_Min;
        private System.Windows.Forms.NumericUpDown nud_A;
        private System.Windows.Forms.NumericUpDown nud_B;
        private System.Windows.Forms.DataGridView dgv_PayMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

