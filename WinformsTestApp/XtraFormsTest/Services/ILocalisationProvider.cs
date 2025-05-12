using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtraFormsTest.Services
{
    public interface ILocalisationProvider
    {
        CultureInfo CultureInfo { get; }
        void SetCulture(CultureCode cultureCode);
    }
}
