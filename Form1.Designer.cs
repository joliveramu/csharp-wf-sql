
namespace CRUDAmurao
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(47, 196);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(153, 20);
            this.txtAge.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 207);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(47, 312);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(119, 52);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(47, 391);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(119, 52);
            this.btnUPDATE.TabIndex = 5;
            this.btnUPDATE.Text = "Update";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(200, 312);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(119, 52);
            this.btnDELETE.TabIndex = 6;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

