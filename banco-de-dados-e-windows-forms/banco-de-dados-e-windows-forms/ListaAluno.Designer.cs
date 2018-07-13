namespace banco_de_dados_e_windows_forms
{
    partial class ListaAluno
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrdenarNome = new System.Windows.Forms.RadioButton();
            this.rbOrdenarCodigoDeMatricula = new System.Windows.Forms.RadioButton();
            this.NomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeMatriculaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbOrdenar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 44);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColumn,
            this.CodigoDeMatriculaColumn,
            this.Nota_1Column,
            this.Nota_2Column,
            this.Nota_3Column,
            this.MediaColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(391, 303);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(311, 415);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(87, 44);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(218, 415);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(87, 44);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(116, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 44);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbOrdenarCodigoDeMatricula);
            this.gbOrdenar.Controls.Add(this.rbOrdenarNome);
            this.gbOrdenar.Location = new System.Drawing.Point(21, 12);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(182, 67);
            this.gbOrdenar.TabIndex = 6;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAsc);
            this.groupBox1.Controls.Add(this.rbDesc);
            this.groupBox1.Location = new System.Drawing.Point(222, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coluna";
            // 
            // rbOrdenarNome
            // 
            this.rbOrdenarNome.AutoSize = true;
            this.rbOrdenarNome.Location = new System.Drawing.Point(3, 30);
            this.rbOrdenarNome.Name = "rbOrdenarNome";
            this.rbOrdenarNome.Size = new System.Drawing.Size(53, 17);
            this.rbOrdenarNome.TabIndex = 0;
            this.rbOrdenarNome.TabStop = true;
            this.rbOrdenarNome.Text = "Nome";
            this.rbOrdenarNome.UseVisualStyleBackColor = true;
            // 
            // rbOrdenarCodigoDeMatricula
            // 
            this.rbOrdenarCodigoDeMatricula.AutoSize = true;
            this.rbOrdenarCodigoDeMatricula.Location = new System.Drawing.Point(62, 30);
            this.rbOrdenarCodigoDeMatricula.Name = "rbOrdenarCodigoDeMatricula";
            this.rbOrdenarCodigoDeMatricula.Size = new System.Drawing.Size(120, 17);
            this.rbOrdenarCodigoDeMatricula.TabIndex = 1;
            this.rbOrdenarCodigoDeMatricula.TabStop = true;
            this.rbOrdenarCodigoDeMatricula.Text = "Código de matrícula";
            this.rbOrdenarCodigoDeMatricula.UseVisualStyleBackColor = true;
            // 
            // NomeColumn
            // 
            this.NomeColumn.HeaderText = "Nome";
            this.NomeColumn.Name = "NomeColumn";
            this.NomeColumn.ReadOnly = true;
            // 
            // CodigoDeMatriculaColumn
            // 
            this.CodigoDeMatriculaColumn.HeaderText = "Código de matrícula";
            this.CodigoDeMatriculaColumn.Name = "CodigoDeMatriculaColumn";
            this.CodigoDeMatriculaColumn.ReadOnly = true;
            // 
            // Nota_1Column
            // 
            this.Nota_1Column.HeaderText = "Nota 1";
            this.Nota_1Column.Name = "Nota_1Column";
            this.Nota_1Column.ReadOnly = true;
            // 
            // Nota_2Column
            // 
            this.Nota_2Column.HeaderText = "Nota 2";
            this.Nota_2Column.Name = "Nota_2Column";
            this.Nota_2Column.ReadOnly = true;
            // 
            // Nota_3Column
            // 
            this.Nota_3Column.HeaderText = "Nota 3";
            this.Nota_3Column.Name = "Nota_3Column";
            this.Nota_3Column.ReadOnly = true;
            // 
            // MediaColumn
            // 
            this.MediaColumn.HeaderText = "Média";
            this.MediaColumn.Name = "MediaColumn";
            this.MediaColumn.ReadOnly = true;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(89, 30);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(86, 17);
            this.rbDesc.TabIndex = 1;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "Decrescente";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Location = new System.Drawing.Point(6, 30);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(73, 17);
            this.rbAsc.TabIndex = 2;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Crescente";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // ListaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(410, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "ListaAluno";
            this.Text = "Lista_Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbOrdenarCodigoDeMatricula;
        private System.Windows.Forms.RadioButton rbOrdenarNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeMatriculaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaColumn;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.RadioButton rbDesc;
    }
}

