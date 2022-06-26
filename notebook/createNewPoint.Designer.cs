
namespace notebook
{
    partial class createNewPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createNewPoint));
            this.namePointBox = new System.Windows.Forms.GroupBox();
            this.textNamePoint = new System.Windows.Forms.TextBox();
            this.savePointButton = new System.Windows.Forms.Button();
            this.namePointBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // namePointBox
            // 
            this.namePointBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namePointBox.Controls.Add(this.textNamePoint);
            this.namePointBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePointBox.Location = new System.Drawing.Point(14, 10);
            this.namePointBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.namePointBox.Name = "namePointBox";
            this.namePointBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.namePointBox.Size = new System.Drawing.Size(236, 50);
            this.namePointBox.TabIndex = 19;
            this.namePointBox.TabStop = false;
            this.namePointBox.Text = "Название пункта";
            // 
            // textNamePoint
            // 
            this.textNamePoint.BackColor = System.Drawing.Color.White;
            this.textNamePoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNamePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNamePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNamePoint.Location = new System.Drawing.Point(10, 22);
            this.textNamePoint.MaxLength = 40;
            this.textNamePoint.Name = "textNamePoint";
            this.textNamePoint.Size = new System.Drawing.Size(220, 16);
            this.textNamePoint.TabIndex = 0;
            this.textNamePoint.TextChanged += new System.EventHandler(this.textNamePoint_TextChanged);
            // 
            // savePointButton
            // 
            this.savePointButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savePointButton.BackColor = System.Drawing.Color.Transparent;
            this.savePointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savePointButton.Location = new System.Drawing.Point(14, 63);
            this.savePointButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.savePointButton.Name = "savePointButton";
            this.savePointButton.Size = new System.Drawing.Size(236, 27);
            this.savePointButton.TabIndex = 18;
            this.savePointButton.Text = "Сохранить";
            this.savePointButton.UseVisualStyleBackColor = false;
            this.savePointButton.Click += new System.EventHandler(this.savePointButton_Click);
            // 
            // createNewPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 101);
            this.Controls.Add(this.namePointBox);
            this.Controls.Add(this.savePointButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "createNewPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пункт";
            this.Load += new System.EventHandler(this.createNewPoint_Load);
            this.namePointBox.ResumeLayout(false);
            this.namePointBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox namePointBox;
        private System.Windows.Forms.Button savePointButton;
        private System.Windows.Forms.TextBox textNamePoint;
    }
}