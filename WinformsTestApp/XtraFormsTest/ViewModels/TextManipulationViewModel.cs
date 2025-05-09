using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace XtraFormsTest.ViewModels
{
    public class TextManipulationViewModel : ViewModelBase
    {
        private string editedText;
        public string EditedText { get => editedText; private set => SetEditedText(); }
        public string LabelText { get; set; } = "Text Manipulation View";
        public int NumValue { get; set; } = 10;

        public TextManipulationViewModel()
        {
            SetEditedText();
        }

        public void ResetValues()
        {
            LabelText = "Text Manipulation View";
            NumValue = 10;
            SetEditedText();
        }

        private void SetEditedText()
        {
            //EditedText = $"{LabelText} - {NumValue}";
        }
    }
}
