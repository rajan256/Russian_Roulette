namespace Russianroulletegun
{
    partial class Russian_Roullete
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
            this.PicBox_Shoot = new System.Windows.Forms.PictureBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_ShootAway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Shoot)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_Shoot
            // 
            this.PicBox_Shoot.Location = new System.Drawing.Point(12, 12);
            this.PicBox_Shoot.Name = "PicBox_Shoot";
            this.PicBox_Shoot.Size = new System.Drawing.Size(434, 338);
            this.PicBox_Shoot.TabIndex = 1;
            this.PicBox_Shoot.TabStop = false;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Gold;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Load.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Load.Location = new System.Drawing.Point(479, 28);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(120, 48);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Gold;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Exit.Location = new System.Drawing.Point(532, 208);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(145, 48);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.Color.Gold;
            this.btn_Spin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Spin.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spin.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Spin.Location = new System.Drawing.Point(655, 28);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(120, 48);
            this.btn_Spin.TabIndex = 4;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = false;
            this.btn_Spin.Click += new System.EventHandler(this.btn_Spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.Color.Gold;
            this.btn_Shoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Shoot.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Shoot.Location = new System.Drawing.Point(479, 107);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(120, 48);
            this.btn_Shoot.TabIndex = 5;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            this.btn_Shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // btn_ShootAway
            // 
            this.btn_ShootAway.BackColor = System.Drawing.Color.Gold;
            this.btn_ShootAway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ShootAway.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShootAway.ForeColor = System.Drawing.Color.Indigo;
            this.btn_ShootAway.Location = new System.Drawing.Point(620, 107);
            this.btn_ShootAway.Name = "btn_ShootAway";
            this.btn_ShootAway.Size = new System.Drawing.Size(155, 48);
            this.btn_ShootAway.TabIndex = 6;
            this.btn_ShootAway.Text = "Shoot Away";
            this.btn_ShootAway.UseVisualStyleBackColor = false;
            this.btn_ShootAway.Click += new System.EventHandler(this.btn_ShootAway_Click);
            // 
            // Russian_Roullete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.btn_ShootAway);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.PicBox_Shoot);
            this.Name = "Russian_Roullete";
            this.Text = "Russian_Roullete";
            this.Load += new System.EventHandler(this.Russian_Roullete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Shoot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PicBox_Shoot;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_ShootAway;
    }
}