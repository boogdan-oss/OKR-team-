using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okr_lab2.Services
{
    public class ThemeService
    {
        private readonly Form _form;
        private readonly List<Label> _labels;

        public ThemeService(Form form)
        {
            _form = form;

            _labels = form.Controls
                .OfType<Label>()
                .ToList();
        }

        public void ToggleTheme()
        {
            if (_form.BackColor == Color.Black)
            {
                ApplyLightTheme();
            }
            else
            {
                ApplyDarkTheme();
            }
        }

        public void ApplyLightTheme()
        {
            _form.BackColor = Color.White;

            foreach (var lbl in _labels)
                lbl.ForeColor = Color.Black;
        }

        public void ApplyDarkTheme()
        {
            _form.BackColor = Color.Black;

            foreach (var lbl in _labels)
                lbl.ForeColor = Color.White;
        }
    }
}
