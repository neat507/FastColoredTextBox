using System;

using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace FastColoredTextBoxNS
{
    class Locale
    {
        public void translate(FindForm findform)
        {
            findform.TopMost = false;
            findform.Text = "찾기";

            foreach (var c in findform.Controls)
            {

                if (c is CheckBox ||
                    c is Button ||
                    c is Label)
                {
                    Control cc = (c as Control);


                    if (cc.Text == "Match whole word")
                        cc.Text = "단어 전체 일치";

                    else if (cc.Text == "Find: ")
                        cc.Text = "찾기: ";
                    else if (cc.Text == "Match case")
                        cc.Text = "대소문자 일치";
                    else if (cc.Text == "Regex")
                        cc.Text = "정규표현식";
                    else if (cc.Text == "Find next")
                    {
                        var sizef = new SizeF(1.1f, 1.1f);
                        cc.Scale(sizef);
                        cc.Text = "다음 찾기";
                        //Point p = new Point(205, 67);
                        var p = cc.Location;
                        var t = new Point(-50, -6);
                        p.X += t.X; p.Y += t.Y;
                        cc.Location = p;
                        
                    }

                    else if (cc.Text == "Close")
                    {
                        var sizef = new SizeF(1.1f, 1.1f);
                        cc.Scale(sizef);
                        cc.Text = "닫기";
                        var p = cc.Location;
                        var t = new Point(-52, -6);
                        p.X += t.X; p.Y += t.Y;
                        cc.Location = p;
                    }
                }


            }


        }

    }

}
