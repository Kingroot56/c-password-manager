
namespace Şifre_Yöneticisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.passsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a_ad = new System.Windows.Forms.TextBox();
            this.k_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.passBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordDataSet1 = new Şifre_Yöneticisi.passwordDataSet();
            this.passTableAdapter = new Şifre_Yöneticisi.passwordDataSetTableAdapters.passTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.passsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(527, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Uygulama Adı:";
            // 
            // a_ad
            // 
            this.a_ad.Location = new System.Drawing.Point(92, 317);
            this.a_ad.Name = "a_ad";
            this.a_ad.Size = new System.Drawing.Size(577, 20);
            this.a_ad.TabIndex = 6;
            // 
            // k_ad
            // 
            this.k_ad.Location = new System.Drawing.Point(92, 343);
            this.k_ad.Name = "k_ad";
            this.k_ad.Size = new System.Drawing.Size(576, 20);
            this.k_ad.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // p_ad
            // 
            this.p_ad.Location = new System.Drawing.Point(92, 369);
            this.p_ad.Name = "p_ad";
            this.p_ad.Size = new System.Drawing.Size(576, 20);
            this.p_ad.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // appnameDataGridViewTextBoxColumn
            // 
            this.appnameDataGridViewTextBoxColumn.Name = "appnameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(92, 397);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(33, 20);
            this.id.TabIndex = 12;
            this.id.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "İd:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.appnameDataGridViewTextBoxColumn2,
            this.usernameDataGridViewTextBoxColumn2,
            this.passwordDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.passBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(657, 285);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // passBindingSource
            // 
            this.passBindingSource.DataMember = "pass";
            this.passBindingSource.DataSource = this.passwordDataSet1;
            // 
            // passwordDataSet1
            // 
            this.passwordDataSet1.DataSetName = "passwordDataSet";
            this.passwordDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passTableAdapter
            // 
            this.passTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // appnameDataGridViewTextBoxColumn2
            // 
            this.appnameDataGridViewTextBoxColumn2.DataPropertyName = "app_name";
            this.appnameDataGridViewTextBoxColumn2.HeaderText = "Uygulama Adı";
            this.appnameDataGridViewTextBoxColumn2.Name = "appnameDataGridViewTextBoxColumn2";
            this.appnameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn2
            // 
            this.usernameDataGridViewTextBoxColumn2.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn2.HeaderText = "Kullanıcı Adı";
            this.usernameDataGridViewTextBoxColumn2.Name = "usernameDataGridViewTextBoxColumn2";
            this.usernameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn2
            // 
            this.passwordDataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn2.HeaderText = "Şifre";
            this.passwordDataGridViewTextBoxColumn2.Name = "passwordDataGridViewTextBoxColumn2";
            this.passwordDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.k_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre Yoneticisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a_ad;
        private System.Windows.Forms.TextBox k_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource passwordDataSetBindingSource;
     
        private System.Windows.Forms.BindingSource passsBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private passwordDataSet passwordDataSet;
        private System.Windows.Forms.BindingSource passsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private passwordDataSet passwordDataSet1;
        private System.Windows.Forms.BindingSource passBindingSource;
        private passwordDataSetTableAdapters.passTableAdapter passTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn appnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn2;
    }
}

