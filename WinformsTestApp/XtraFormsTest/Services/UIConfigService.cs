using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using XtraFormsTest.Configuration;

namespace XtraFormsTest.Services
{
    public class UIConfigService : IUIConfigService
    {
        private readonly UIConfig uIConfig;

        public UIConfigService()
        {
            // Initialize default configuration
            uIConfig = new UIConfig
            {
                LabelBackColor = System.Drawing.Color.LightBlue,
                LabelFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
            };
        }

        public void ApplyLabelDefaults(LabelControl labelControl)
        {
            labelControl.Appearance.BackColor = uIConfig.LabelBackColor;
            labelControl.Appearance.Font = uIConfig.LabelFont;
            labelControl.Appearance.Options.UseBackColor = true;
            labelControl.Appearance.Options.UseFont = true;
        }
    }
}
