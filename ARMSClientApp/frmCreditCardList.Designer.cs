
namespace ARMSClientApp
{
    partial class frmCreditCardList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListCreditCards = new System.Windows.Forms.Button();
            this.dgvCreditCardList = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Credit Card Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click List All Button to List all Credit Cards";
            // 
            // btnListCreditCards
            // 
            this.btnListCreditCards.Location = new System.Drawing.Point(53, 221);
            this.btnListCreditCards.Name = "btnListCreditCards";
            this.btnListCreditCards.Size = new System.Drawing.Size(317, 46);
            this.btnListCreditCards.TabIndex = 2;
            this.btnListCreditCards.Text = "List All Credit Cards";
            this.btnListCreditCards.UseVisualStyleBackColor = true;
            this.btnListCreditCards.Click += new System.EventHandler(this.btnListCreditCards_Click);
            // 
            // dgvCreditCardList
            // 
            this.dgvCreditCardList.AllowUserToOrderColumns = true;
            this.dgvCreditCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditCardList.Location = new System.Drawing.Point(53, 319);
            this.dgvCreditCardList.Name = "dgvCreditCardList";
            this.dgvCreditCardList.RowHeadersWidth = 82;
            this.dgvCreditCardList.RowTemplate.Height = 33;
            this.dgvCreditCardList.Size = new System.Drawing.Size(2246, 302);
            this.dgvCreditCardList.TabIndex = 3;
            this.dgvCreditCardList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditCardList_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1082, 645);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 56);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // frmCreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2370, 742);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvCreditCardList);
            this.Controls.Add(this.btnListCreditCards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreditCardList";
            this.Text = "CreditCardList";
            this.Load += new System.EventHandler(this.frmCreditCardList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListCreditCards;
        private System.Windows.Forms.DataGridView dgvCreditCardList;
        private System.Windows.Forms.Button btnExit;
    }
}