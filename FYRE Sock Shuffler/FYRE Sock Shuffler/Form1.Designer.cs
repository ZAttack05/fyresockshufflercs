namespace FYRE_Sock_Shuffler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enterTxt = new System.Windows.Forms.TextBox();
            this.instLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.rdmBtn = new System.Windows.Forms.Button();
            this.listRTxt = new System.Windows.Forms.RichTextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterTxt
            // 
            this.enterTxt.Font = new System.Drawing.Font("Jumper PERSONAL USE ONLY", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTxt.Location = new System.Drawing.Point(12, 49);
            this.enterTxt.Name = "enterTxt";
            this.enterTxt.Size = new System.Drawing.Size(254, 30);
            this.enterTxt.TabIndex = 0;
            // 
            // instLbl
            // 
            this.instLbl.AutoSize = true;
            this.instLbl.BackColor = System.Drawing.Color.Transparent;
            this.instLbl.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instLbl.Location = new System.Drawing.Point(12, 17);
            this.instLbl.Name = "instLbl";
            this.instLbl.Size = new System.Drawing.Size(120, 29);
            this.instLbl.TabIndex = 1;
            this.instLbl.Text = "Enter a name";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 84);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 26);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // rdmBtn
            // 
            this.rdmBtn.Location = new System.Drawing.Point(143, 84);
            this.rdmBtn.Name = "rdmBtn";
            this.rdmBtn.Size = new System.Drawing.Size(122, 26);
            this.rdmBtn.TabIndex = 3;
            this.rdmBtn.Text = "Randomize";
            this.rdmBtn.UseVisualStyleBackColor = true;
            this.rdmBtn.Click += new System.EventHandler(this.rdmBtn_Click);
            // 
            // listRTxt
            // 
            this.listRTxt.Font = new System.Drawing.Font("Jumper PERSONAL USE ONLY", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRTxt.Location = new System.Drawing.Point(12, 118);
            this.listRTxt.Name = "listRTxt";
            this.listRTxt.ReadOnly = true;
            this.listRTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.listRTxt.Size = new System.Drawing.Size(226, 386);
            this.listRTxt.TabIndex = 4;
            this.listRTxt.Text = "";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 510);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(254, 34);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear and Reset";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FYRE_Sock_Shuffler.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(244, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 384);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FYRE_Sock_Shuffler.Properties.Resources.formBG;
            this.ClientSize = new System.Drawing.Size(281, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.listRTxt);
            this.Controls.Add(this.rdmBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.instLbl);
            this.Controls.Add(this.enterTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BSU FYRE Sock Shuffler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterTxt;
        private System.Windows.Forms.Label instLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button rdmBtn;
        private System.Windows.Forms.RichTextBox listRTxt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

