using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Common
{
    public class WebUIHelper
    {
        public WebUIHelper(string secondMenuText,string secondMenuLink = null,string thirdMenuText = null
            , string firstMenuText = null, string firstMenuLink = null)
        {
            FirstMenuLink = firstMenuLink ?? "/Admin/Home/Index";
            FirstMenuText = firstMenuText ?? "主页";
            SecondMenuLink = secondMenuLink;
            SecondMenuText = secondMenuText;
            ThirdMenuText = thirdMenuText;
        }
        public string FirstMenuLink { get; set; } 
        public string FirstMenuText { get; set; } 
        public string SecondMenuLink { get; set; }
        public string SecondMenuText { get; set; }
        public string ThirdMenuText { get; set; }
    }
}
