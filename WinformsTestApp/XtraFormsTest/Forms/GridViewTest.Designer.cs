namespace XtraFormsTest.Forms
{
    partial class GridViewTest
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            valuedColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            rowDeleteButton = new DevExpress.XtraEditors.SimpleButton();
            rowCreateButton = new DevExpress.XtraEditors.SimpleButton();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).BeginInit();
            tablePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            tablePanel1.SetColumn(gridControl1, 0);
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(13, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            tablePanel1.SetRow(gridControl1, 0);
            gridControl1.Size = new System.Drawing.Size(1358, 662);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { nameColumn, valuedColumn });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(nameColumn, DevExpress.Data.ColumnSortOrder.Ascending) });
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
            gridView1.InitNewRow += gridView1_InitNewRow_1;
            gridView1.RowUpdated += gridView1_RowUpdated;
            gridView1.DoubleClick += gridView1_DoubleClick;
            gridView1.InvalidValueException += gridView1_InvalidValueException;
            // 
            // nameColumn
            // 
            nameColumn.Caption = "nameColumn";
            nameColumn.FieldName = "Name";
            nameColumn.Name = "nameColumn";
            nameColumn.Visible = true;
            nameColumn.VisibleIndex = 0;
            // 
            // valuedColumn
            // 
            valuedColumn.Caption = "valueColumn";
            valuedColumn.Name = "valuedColumn";
            valuedColumn.Visible = true;
            valuedColumn.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tablePanel2.SetColumn(labelControl1, 3);
            labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl1.Location = new System.Drawing.Point(894, 25);
            labelControl1.Margin = new System.Windows.Forms.Padding(15);
            labelControl1.Name = "labelControl1";
            tablePanel2.SetRow(labelControl1, 0);
            labelControl1.Size = new System.Drawing.Size(438, 78);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "labelControl1";
            // 
            // rowDeleteButton
            // 
            tablePanel2.SetColumn(rowDeleteButton, 0);
            rowDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            rowDeleteButton.Location = new System.Drawing.Point(26, 25);
            rowDeleteButton.Margin = new System.Windows.Forms.Padding(15);
            rowDeleteButton.Name = "rowDeleteButton";
            rowDeleteButton.Padding = new System.Windows.Forms.Padding(15);
            tablePanel2.SetRow(rowDeleteButton, 0);
            rowDeleteButton.Size = new System.Drawing.Size(304, 78);
            rowDeleteButton.TabIndex = 0;
            rowDeleteButton.Text = "Delete";
            rowDeleteButton.Click += rowDeleteButton_Click;
            // 
            // rowCreateButton
            // 
            tablePanel2.SetColumn(rowCreateButton, 1);
            rowCreateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            rowCreateButton.Location = new System.Drawing.Point(360, 25);
            rowCreateButton.Margin = new System.Windows.Forms.Padding(15);
            rowCreateButton.Name = "rowCreateButton";
            rowCreateButton.Padding = new System.Windows.Forms.Padding(15);
            tablePanel2.SetRow(rowCreateButton, 0);
            rowCreateButton.Size = new System.Drawing.Size(304, 78);
            rowCreateButton.TabIndex = 1;
            rowCreateButton.Text = "Create";
            rowCreateButton.Click += rowCreateButton_Click;
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel1.Controls.Add(tablePanel2);
            tablePanel1.Controls.Add(gridControl1);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(0, 0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F) });
            tablePanel1.Size = new System.Drawing.Size(1384, 820);
            tablePanel1.TabIndex = 3;
            tablePanel1.UseSkinIndents = true;
            // 
            // tablePanel2
            // 
            tablePanel1.SetColumn(tablePanel2, 0);
            tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F) });
            tablePanel2.Controls.Add(labelControl2);
            tablePanel2.Controls.Add(labelControl1);
            tablePanel2.Controls.Add(rowDeleteButton);
            tablePanel2.Controls.Add(rowCreateButton);
            tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel2.Location = new System.Drawing.Point(13, 678);
            tablePanel2.Name = "tablePanel2";
            tablePanel1.SetRow(tablePanel2, 1);
            tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            tablePanel2.Size = new System.Drawing.Size(1358, 129);
            tablePanel2.TabIndex = 1;
            tablePanel2.UseSkinIndents = true;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tablePanel2.SetColumn(labelControl2, 2);
            labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl2.Location = new System.Drawing.Point(694, 25);
            labelControl2.Margin = new System.Windows.Forms.Padding(15);
            labelControl2.Name = "labelControl2";
            tablePanel2.SetRow(labelControl2, 0);
            labelControl2.Size = new System.Drawing.Size(170, 78);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Row Count:";
            // 
            // GridViewTest
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1384, 820);
            Controls.Add(tablePanel1);
            Name = "GridViewTest";
            Text = "GridViewTest";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablePanel2).EndInit();
            tablePanel2.ResumeLayout(false);
            tablePanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn valuedColumn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton rowDeleteButton;
        private DevExpress.XtraEditors.SimpleButton rowCreateButton;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}