using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hacks;

namespace hacks
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtWord.Text.Trim();

            var word = WordRepository.Words.FirstOrDefault(
                w => w.EnglishWord.ToLower() == searchWord.ToLower()
            );

            if (word != null)
            {
                // Word found → go to AddWord page
                Response.Redirect($"AddWord.aspx?word={searchWord}");
            }
            else
            {
                // Word not found → go to Error page
                Response.Redirect($"Error.aspx?word={searchWord}");
            }
        }
    }
}