﻿namespace Formulaire
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_personne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.input_age = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.input_nom = new System.Windows.Forms.TextBox();
            this.btn_enregister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_personne,
            this.Nom,
            this.Prenom,
            this.Age});
            this.dataGridView1.Location = new System.Drawing.Point(93, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 180);
            this.dataGridView1.TabIndex = 0;
            
            // 
            // Id_personne
            // 
            this.Id_personne.HeaderText = "Id_personne";
            this.Id_personne.Name = "Id_personne";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(620, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(77, 36);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(620, 61);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(77, 38);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(620, 149);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(77, 38);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(620, 105);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(77, 38);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Location = new System.Drawing.Point(90, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(66, 13);
            this.txt_id.TabIndex = 5;
            this.txt_id.Text = "Id_personne";
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Location = new System.Drawing.Point(90, 80);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_nom.Size = new System.Drawing.Size(29, 13);
            this.txt_nom.TabIndex = 6;
            this.txt_nom.Text = "Nom";
            // 
            // txt_age
            // 
            this.txt_age.AutoSize = true;
            this.txt_age.Location = new System.Drawing.Point(93, 177);
            this.txt_age.Name = "txt_age";
            this.txt_age.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_age.Size = new System.Drawing.Size(26, 13);
            this.txt_age.TabIndex = 7;
            this.txt_age.Text = "Age";
            this.txt_age.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_prenom
            // 
            this.txt_prenom.AutoSize = true;
            this.txt_prenom.Location = new System.Drawing.Point(90, 130);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(43, 13);
            this.txt_prenom.TabIndex = 8;
            this.txt_prenom.Text = "Prenom";
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(188, 35);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(192, 20);
            this.input_id.TabIndex = 9;
            // 
            // input_age
            // 
            this.input_age.Location = new System.Drawing.Point(188, 174);
            this.input_age.Name = "input_age";
            this.input_age.Size = new System.Drawing.Size(192, 20);
            this.input_age.TabIndex = 10;
            // 
            // input_prenom
            // 
            this.input_prenom.Location = new System.Drawing.Point(188, 130);
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(192, 20);
            this.input_prenom.TabIndex = 11;
            this.input_prenom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // input_nom
            // 
            this.input_nom.Location = new System.Drawing.Point(188, 80);
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(192, 20);
            this.input_nom.TabIndex = 12;
            // 
            // btn_enregister
            // 
            this.btn_enregister.Location = new System.Drawing.Point(620, 193);
            this.btn_enregister.Name = "btn_enregister";
            this.btn_enregister.Size = new System.Drawing.Size(77, 38);
            this.btn_enregister.TabIndex = 13;
            this.btn_enregister.Text = "Confirm";
            this.btn_enregister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_enregister);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_age);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_personne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txt_nom;
        private System.Windows.Forms.Label txt_age;
        private System.Windows.Forms.Label txt_prenom;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.TextBox input_age;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.Button btn_enregister;
    }
}
