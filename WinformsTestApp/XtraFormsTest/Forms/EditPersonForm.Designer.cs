namespace XtraFormsTest.Forms
{
    partial class EditPersonForm
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
            nameLabel = new DevExpress.XtraEditors.LabelControl();
            valueLabel = new DevExpress.XtraEditors.LabelControl();
            okButton = new DevExpress.XtraEditors.SimpleButton();
            cancelButton = new DevExpress.XtraEditors.SimpleButton();
            nameEdit = new DevExpress.XtraEditors.TextEdit();
            valueEdit = new DevExpress.XtraEditors.SpinEdit();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)nameEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valueEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Appearance.Options.UseTextOptions = true;
            nameLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            nameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            tablePanel1.SetColumn(nameLabel, 0);
            nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nameLabel.Location = new System.Drawing.Point(26, 25);
            nameLabel.Margin = new System.Windows.Forms.Padding(15);
            nameLabel.Name = "nameLabel";
            tablePanel1.SetRow(nameLabel, 0);
            nameLabel.Size = new System.Drawing.Size(356, 97);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // valueLabel
            // 
            valueLabel.Appearance.Options.UseTextOptions = true;
            valueLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            valueLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            tablePanel1.SetColumn(valueLabel, 0);
            valueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            valueLabel.Location = new System.Drawing.Point(26, 152);
            valueLabel.Margin = new System.Windows.Forms.Padding(15);
            valueLabel.Name = "valueLabel";
            tablePanel1.SetRow(valueLabel, 1);
            valueLabel.Size = new System.Drawing.Size(356, 97);
            valueLabel.TabIndex = 1;
            valueLabel.Text = "Value";
            // 
            // okButton
            // 
            okButton.AutoSize = true;
            tablePanel1.SetColumn(okButton, 0);
            okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            okButton.Location = new System.Drawing.Point(26, 406);
            okButton.Margin = new System.Windows.Forms.Padding(15);
            okButton.MinimumSize = new System.Drawing.Size(0, 30);
            okButton.Name = "okButton";
            tablePanel1.SetRow(okButton, 3);
            okButton.Size = new System.Drawing.Size(356, 95);
            okButton.TabIndex = 4;
            okButton.Text = "Ok";
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            tablePanel1.SetColumn(cancelButton, 1);
            cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            cancelButton.Location = new System.Drawing.Point(412, 406);
            cancelButton.Margin = new System.Windows.Forms.Padding(15);
            cancelButton.MinimumSize = new System.Drawing.Size(0, 30);
            cancelButton.Name = "cancelButton";
            tablePanel1.SetRow(cancelButton, 3);
            cancelButton.Size = new System.Drawing.Size(356, 95);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // nameEdit
            // 
            tablePanel1.SetColumn(nameEdit, 1);
            nameEdit.Location = new System.Drawing.Point(412, 63);
            nameEdit.Margin = new System.Windows.Forms.Padding(15);
            nameEdit.Name = "nameEdit";
            nameEdit.Properties.Appearance.Options.UseTextOptions = true;
            nameEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tablePanel1.SetRow(nameEdit, 0);
            nameEdit.Size = new System.Drawing.Size(356, 20);
            nameEdit.TabIndex = 2;
            nameEdit.Validating += nameEdit_Validating;
            // 
            // valueEdit
            // 
            tablePanel1.SetColumn(valueEdit, 1);
            valueEdit.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            valueEdit.Location = new System.Drawing.Point(412, 190);
            valueEdit.Margin = new System.Windows.Forms.Padding(15);
            valueEdit.Name = "valueEdit";
            valueEdit.Properties.Appearance.Options.UseTextOptions = true;
            valueEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            valueEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel1.SetRow(valueEdit, 1);
            valueEdit.Size = new System.Drawing.Size(356, 20);
            valueEdit.TabIndex = 6;
            // 
            // tablePanel1
            // 
            tablePanel1.AutoSize = true;
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F) });
            tablePanel1.Controls.Add(nameLabel);
            tablePanel1.Controls.Add(cancelButton);
            tablePanel1.Controls.Add(valueEdit);
            tablePanel1.Controls.Add(okButton);
            tablePanel1.Controls.Add(nameEdit);
            tablePanel1.Controls.Add(valueLabel);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(0, 0);
            tablePanel1.Margin = new System.Windows.Forms.Padding(15);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F) });
            tablePanel1.Size = new System.Drawing.Size(794, 527);
            tablePanel1.TabIndex = 7;
            tablePanel1.UseSkinIndents = true;
            // 
            // EditPersonForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(794, 527);
            Controls.Add(tablePanel1);
            Name = "EditPersonForm";
            Text = "EditPersonForm";
            ((System.ComponentModel.ISupportInitialize)nameEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)valueEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl valueLabel;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.TextEdit nameEdit;
        private DevExpress.XtraEditors.SpinEdit valueEdit;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}