
namespace Smoke_beta_test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LeftTB = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.leftCPSCount = new System.Windows.Forms.Label();
            this.LeftCliker = new System.Windows.Forms.Timer(this.components);
            this.LeftCheckB_on = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RightTB = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.RightCPSCount = new System.Windows.Forms.Label();
            this.RightClicker = new System.Windows.Forms.Timer(this.components);
            this.RightCheckB_on = new System.Windows.Forms.CheckBox();
            this.Leftjitter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Questrian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "left click";
            // 
            // LeftTB
            // 
            this.LeftTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LeftTB.Location = new System.Drawing.Point(17, 40);
            this.LeftTB.Maximum = 35;
            this.LeftTB.Minimum = 5;
            this.LeftTB.Name = "LeftTB";
            this.LeftTB.Size = new System.Drawing.Size(233, 24);
            this.LeftTB.TabIndex = 1;
            this.LeftTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.LeftTB.Value = 5;
            this.LeftTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LeftTB_Scroll);
            // 
            // leftCPSCount
            // 
            this.leftCPSCount.AutoSize = true;
            this.leftCPSCount.BackColor = System.Drawing.Color.Transparent;
            this.leftCPSCount.Font = new System.Drawing.Font("Questrian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftCPSCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(196)))));
            this.leftCPSCount.Location = new System.Drawing.Point(256, 40);
            this.leftCPSCount.Name = "leftCPSCount";
            this.leftCPSCount.Size = new System.Drawing.Size(76, 28);
            this.leftCPSCount.TabIndex = 2;
            this.leftCPSCount.Text = "5 CPS";
            // 
            // LeftCliker
            // 
            this.LeftCliker.Enabled = true;
            this.LeftCliker.Tick += new System.EventHandler(this.LeftCliker_Tick);
            // 
            // LeftCheckB_on
            // 
            this.LeftCheckB_on.AutoSize = true;
            this.LeftCheckB_on.Font = new System.Drawing.Font("Questrian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftCheckB_on.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(124)))), ((int)(((byte)(147)))));
            this.LeftCheckB_on.Location = new System.Drawing.Point(17, 71);
            this.LeftCheckB_on.Name = "LeftCheckB_on";
            this.LeftCheckB_on.Size = new System.Drawing.Size(85, 22);
            this.LeftCheckB_on.TabIndex = 3;
            this.LeftCheckB_on.Text = "enable";
            this.LeftCheckB_on.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Questrian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "right Click";
            // 
            // RightTB
            // 
            this.RightTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RightTB.Location = new System.Drawing.Point(407, 40);
            this.RightTB.Maximum = 50;
            this.RightTB.Minimum = 5;
            this.RightTB.Name = "RightTB";
            this.RightTB.Size = new System.Drawing.Size(233, 24);
            this.RightTB.TabIndex = 5;
            this.RightTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.RightTB.Value = 5;
            this.RightTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RightTB_Scroll);
            // 
            // RightCPSCount
            // 
            this.RightCPSCount.AutoSize = true;
            this.RightCPSCount.BackColor = System.Drawing.Color.Transparent;
            this.RightCPSCount.Font = new System.Drawing.Font("Questrian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCPSCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(196)))));
            this.RightCPSCount.Location = new System.Drawing.Point(646, 36);
            this.RightCPSCount.Name = "RightCPSCount";
            this.RightCPSCount.Size = new System.Drawing.Size(76, 28);
            this.RightCPSCount.TabIndex = 6;
            this.RightCPSCount.Text = "5 CPS";
            // 
            // RightClicker
            // 
            this.RightClicker.Enabled = true;
            this.RightClicker.Tick += new System.EventHandler(this.RightClicker_Tick);
            // 
            // RightCheckB_on
            // 
            this.RightCheckB_on.AutoSize = true;
            this.RightCheckB_on.Font = new System.Drawing.Font("Questrian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCheckB_on.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(124)))), ((int)(((byte)(147)))));
            this.RightCheckB_on.Location = new System.Drawing.Point(407, 71);
            this.RightCheckB_on.Name = "RightCheckB_on";
            this.RightCheckB_on.Size = new System.Drawing.Size(85, 22);
            this.RightCheckB_on.TabIndex = 7;
            this.RightCheckB_on.Text = "enable";
            this.RightCheckB_on.UseVisualStyleBackColor = true;
            // 
            // Leftjitter
            // 
            this.Leftjitter.Enabled = true;
            this.Leftjitter.Tick += new System.EventHandler(this.Leftjitter_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.RightCheckB_on);
            this.Controls.Add(this.RightCPSCount);
            this.Controls.Add(this.RightTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeftCheckB_on);
            this.Controls.Add(this.leftCPSCount);
            this.Controls.Add(this.LeftTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Smoke [beta]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar LeftTB;
        private System.Windows.Forms.Label leftCPSCount;
        private System.Windows.Forms.Timer LeftCliker;
        private System.Windows.Forms.CheckBox LeftCheckB_on;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar RightTB;
        private System.Windows.Forms.Label RightCPSCount;
        private System.Windows.Forms.Timer RightClicker;
        private System.Windows.Forms.CheckBox RightCheckB_on;
        private System.Windows.Forms.Timer Leftjitter;
    }
}

