using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace XtraFormsTest.Services
{
    public interface IUIConfigService
    {
        void ApplyLabelDefaults(LabelControl labelControl);
    }
}
