using System;
using System.Collections.Generic;
using System.Text;
using Commons;

namespace Presentation.ViewModels
{
    public class CenterPageViewModel : ViewModel
    {
        private int _radiusBlur = 0;
        public int RadiusBlur
        {
            get
            {
                return _radiusBlur;
            }
            set
            {
                _radiusBlur = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand ClickCommand
        {
            get
            {
                return new RelayCommand((_) =>
                {
                    if (RadiusBlur == 0)
                        RadiusBlur = 10;
                    else
                        RadiusBlur = 0;
                });
            }
        }
    }
}
