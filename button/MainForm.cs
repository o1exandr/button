using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button
{
    public partial class fmMain : Form
    {
        ContentAlignment currAligment = ContentAlignment.MiddleCenter;
        int currEnumPos = 0;
        public fmMain()
        {
            InitializeComponent();
        }

        private void btStandart_Click(object sender, EventArgs e)
        {
            // отримання значення переліку ContentAligment
            Array values = Enum.GetValues(currAligment.GetType());

            // читання поточної позиції в переліку
            // і циклічне повернення
            currEnumPos++;
            if (currEnumPos >= values.Length)
                currEnumPos = 0;

            // читання поточного значення переліку
            currAligment =
                (ContentAlignment)Enum.Parse(currAligment.GetType(),
                values.GetValue(currEnumPos).ToString());

            // вивід тексту и його вирівнювання на btStandart
            btStandart.TextAlign = currAligment;
            btStandart.Text = currAligment.ToString();

            // розміщення піктограми на btImage
            btImage.ImageAlign = currAligment;
        }
    }
}
