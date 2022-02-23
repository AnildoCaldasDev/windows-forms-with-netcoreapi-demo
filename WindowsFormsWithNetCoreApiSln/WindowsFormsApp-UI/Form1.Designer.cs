
namespace WindowsFormsApp_UI
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
            this.lbResult = new System.Windows.Forms.Label();
            this.btnListarAll = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCriarNovo = new System.Windows.Forms.Button();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(32, 184);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(58, 13);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Resultado:";
            // 
            // btnListarAll
            // 
            this.btnListarAll.Location = new System.Drawing.Point(15, 41);
            this.btnListarAll.Name = "btnListarAll";
            this.btnListarAll.Size = new System.Drawing.Size(75, 23);
            this.btnListarAll.TabIndex = 1;
            this.btnListarAll.Text = "Listar Get All";
            this.btnListarAll.UseVisualStyleBackColor = true;
            this.btnListarAll.Click += new System.EventHandler(this.btnListarAll_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 70);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(164, 61);
            this.txtResult.TabIndex = 2;
            // 
            // btnCriarNovo
            // 
            this.btnCriarNovo.Location = new System.Drawing.Point(245, 41);
            this.btnCriarNovo.Name = "btnCriarNovo";
            this.btnCriarNovo.Size = new System.Drawing.Size(75, 23);
            this.btnCriarNovo.TabIndex = 3;
            this.btnCriarNovo.Text = "Criar Novo";
            this.btnCriarNovo.UseVisualStyleBackColor = true;
            this.btnCriarNovo.Click += new System.EventHandler(this.btnCriarNovo_Click);
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.Location = new System.Drawing.Point(245, 70);
            this.txtBoxAdd.Multiline = true;
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxAdd.Size = new System.Drawing.Size(164, 61);
            this.txtBoxAdd.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(460, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(658, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxAdd);
            this.Controls.Add(this.btnCriarNovo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnListarAll);
            this.Controls.Add(this.lbResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnListarAll;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCriarNovo;
        private System.Windows.Forms.TextBox txtBoxAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

