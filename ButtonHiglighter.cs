using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_POS_system
{
    //This class is for setting the highlight color 
    internal class ButtonHiglighter
    {
        List<Button> buttons;
        Color defaultColor;

        public ButtonHiglighter(List<Button> buttons,Color defaultColor) { 
        
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            setDefaultBtnColor();
        }

        public void setDefaultBtnColor() {
        
            foreach (Button button in buttons) { 
            
                button.ForeColor = defaultColor;

            }
        }

       

        public void highlightBtn(Button selectedButton,Color selectedColor)
        {

            foreach(Button button in buttons)
            {
                if(button == selectedButton)
                {
                    selectedButton.ForeColor = selectedColor;
                }
                else
                {
                    button.ForeColor = defaultColor;
                }
            }

        }

    }
}
