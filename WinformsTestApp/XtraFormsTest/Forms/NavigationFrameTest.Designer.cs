namespace XtraFormsTest.Forms
{
    partial class NavigationFrameTest
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
            navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            popupContainerEdit1 = new DevExpress.XtraEditors.PopupContainerEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)navigationFrame1).BeginInit();
            navigationFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)popupContainerControl1).BeginInit();
            popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radioGroup1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).BeginInit();
            tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)popupContainerEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // navigationFrame1
            // 
            tablePanel1.SetColumn(navigationFrame1, 1);
            navigationFrame1.Controls.Add(navigationPage1);
            navigationFrame1.Controls.Add(navigationPage2);
            navigationFrame1.Controls.Add(navigationPage3);
            navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            navigationFrame1.Location = new System.Drawing.Point(231, 85);
            navigationFrame1.Name = "navigationFrame1";
            navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { navigationPage1, navigationPage2, navigationPage3 });
            tablePanel1.SetRow(navigationFrame1, 1);
            navigationFrame1.SelectedPage = navigationPage1;
            navigationFrame1.Size = new System.Drawing.Size(978, 726);
            navigationFrame1.TabIndex = 0;
            navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            navigationPage1.Caption = "navigationPage1";
            navigationPage1.Name = "navigationPage1";
            navigationPage1.Size = new System.Drawing.Size(978, 726);
            // 
            // navigationPage2
            // 
            navigationPage2.Caption = "navigationPage2";
            navigationPage2.Name = "navigationPage2";
            navigationPage2.Size = new System.Drawing.Size(978, 726);
            // 
            // navigationPage3
            // 
            navigationPage3.Caption = "navigationPage3";
            navigationPage3.Name = "navigationPage3";
            navigationPage3.Size = new System.Drawing.Size(978, 726);
            // 
            // popupContainerControl1
            // 
            tablePanel2.SetColumn(popupContainerControl1, 1);
            popupContainerControl1.Controls.Add(radioGroup1);
            popupContainerControl1.Location = new System.Drawing.Point(778, 37);
            popupContainerControl1.Name = "popupContainerControl1";
            tablePanel2.SetRow(popupContainerControl1, 1);
            popupContainerControl1.Size = new System.Drawing.Size(187, 18);
            popupContainerControl1.TabIndex = 3;
            // 
            // radioGroup1
            // 
            radioGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            radioGroup1.Location = new System.Drawing.Point(0, 0);
            radioGroup1.Name = "radioGroup1";
            radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            radioGroup1.Size = new System.Drawing.Size(187, 18);
            radioGroup1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            tablePanel1.SetColumn(accordionControl1, 0);
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1, accordionControlElement2 });
            accordionControl1.Location = new System.Drawing.Point(13, 12);
            accordionControl1.Name = "accordionControl1";
            tablePanel1.SetRow(accordionControl1, 0);
            tablePanel1.SetRowSpan(accordionControl1, 2);
            accordionControl1.Size = new System.Drawing.Size(214, 799);
            accordionControl1.TabIndex = 0;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Appearance.Default.FontSizeDelta = 3;
            accordionControlElement1.Appearance.Default.FontStyleDelta = System.Drawing.FontStyle.Bold;
            accordionControlElement1.Appearance.Default.Options.UseFont = true;
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement1.Text = "Element1";
            accordionControlElement1.Click += accordionControlElement1_Click;
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Appearance.Default.FontSizeDelta = 3;
            accordionControlElement2.Appearance.Default.FontStyleDelta = System.Drawing.FontStyle.Bold;
            accordionControlElement2.Appearance.Default.Options.UseFont = true;
            accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement3, accordionControlElement4 });
            accordionControlElement2.Expanded = true;
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Text = "Element2";
            // 
            // accordionControlElement3
            // 
            accordionControlElement3.Name = "accordionControlElement3";
            accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement3.Text = "Element3";
            accordionControlElement3.Click += accordionControlElement3_Click;
            // 
            // accordionControlElement4
            // 
            accordionControlElement4.Name = "accordionControlElement4";
            accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement4.Text = "Element4";
            accordionControlElement4.Click += accordionControlElement4_Click;
            // 
            // tablePanel1
            // 
            tablePanel1.AutoSize = true;
            tablePanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 20F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F) });
            tablePanel1.Controls.Add(tablePanel2);
            tablePanel1.Controls.Add(accordionControl1);
            tablePanel1.Controls.Add(navigationFrame1);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(0, 0);
            tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
            tablePanel1.Size = new System.Drawing.Size(1222, 824);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // tablePanel2
            // 
            tablePanel1.SetColumn(tablePanel2, 1);
            tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 20F) });
            tablePanel2.Controls.Add(popupContainerControl1);
            tablePanel2.Controls.Add(popupContainerEdit1);
            tablePanel2.Controls.Add(labelControl1);
            tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel2.Location = new System.Drawing.Point(231, 12);
            tablePanel2.Name = "tablePanel2";
            tablePanel1.SetRow(tablePanel2, 0);
            tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F) });
            tablePanel2.Size = new System.Drawing.Size(978, 69);
            tablePanel2.TabIndex = 1;
            tablePanel2.UseSkinIndents = true;
            // 
            // popupContainerEdit1
            // 
            tablePanel2.SetColumn(popupContainerEdit1, 1);
            popupContainerEdit1.Location = new System.Drawing.Point(778, 12);
            popupContainerEdit1.Name = "popupContainerEdit1";
            popupContainerEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel2.SetRow(popupContainerEdit1, 0);
            popupContainerEdit1.Size = new System.Drawing.Size(187, 20);
            popupContainerEdit1.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            tablePanel2.SetColumn(labelControl1, 0);
            labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl1.Location = new System.Drawing.Point(13, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            tablePanel2.SetRow(labelControl1, 0);
            labelControl1.Size = new System.Drawing.Size(761, 20);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Toolbar?";
            // 
            // NavigationFrameTest
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1222, 824);
            Controls.Add(tablePanel1);
            Name = "NavigationFrameTest";
            Text = "NavigationFrameTest";
            ((System.ComponentModel.ISupportInitialize)navigationFrame1).EndInit();
            navigationFrame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)popupContainerControl1).EndInit();
            popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radioGroup1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablePanel2).EndInit();
            tablePanel2.ResumeLayout(false);
            tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)popupContainerEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.PopupContainerEdit popupContainerEdit1;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}