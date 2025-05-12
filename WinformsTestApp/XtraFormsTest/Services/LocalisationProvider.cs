using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraPdfViewer.Native;

namespace XtraFormsTest.Services
{
    public class LocalisationProvider : ILocalisationProvider
    {
        public CultureInfo CultureInfo { get; private set; } = new CultureInfo("en");


        public void SetCulture(CultureCode cultureCode)
        {
            switch (cultureCode)
            {
                case CultureCode.French:
                    CultureInfo = new CultureInfo("fr");
                    break;
                default:
                case CultureCode.English:
                    CultureInfo = new CultureInfo("en");
                    break;
            }

            Thread.CurrentThread.CurrentUICulture = CultureInfo;
            Thread.CurrentThread.CurrentCulture = CultureInfo;
        }
    }

    public enum CultureCode
    {
        English,
        French
    }
}
