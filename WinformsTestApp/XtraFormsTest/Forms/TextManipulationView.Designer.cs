namespace XtraFormsTest.Forms
{
    partial class TextManipulationView
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelControl1.Location = new System.Drawing.Point(12, 26);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(63, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "labelControl1";
            // 
            // textEdit1
            // 
            textEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            textEdit1.Location = new System.Drawing.Point(0, 0);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(100, 20);
            textEdit1.TabIndex = 1;
            // 
            // spinEdit1
            // 
            spinEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new System.Drawing.Point(100, 0);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Size = new System.Drawing.Size(100, 20);
            spinEdit1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(100, 26);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(75, 23);
            simpleButton1.TabIndex = 3;
            simpleButton1.Text = "simpleButton1";
            // 
            // TextManipulationView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(785, 538);
            Controls.Add(simpleButton1);
            Controls.Add(spinEdit1);
            Controls.Add(textEdit1);
            Controls.Add(labelControl1);
            Name = "TextManipulationView";
            Text = "TextManipulationView";
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}