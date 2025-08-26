using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebformApp
{
    public partial class Search : System.Web.UI.Page
    {
        public class Word
        {
            public string EnglishWord { get; set; }
            public string Translation { get; set; }
        }
        public static List<Word> words = new List<Word>
        {
            new Word{ EnglishWord = "sequel", Translation = "subsequent event" },
            new Word{ EnglishWord = "adulation", Translation = "excessive flattery" },
            new Word{ EnglishWord = "fun", Translation = "" }
        };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtWord.Text.Trim();
            var word = words.FirstOrDefault(w => w.EnglishWord.ToLower() == input.ToLower());

            if (word != null)
            {
                Response.Redirect("AddWord.aspx?word=" + Server.UrlEncode(input));
            }
            else
            {
              

               string script = $"var confirmed = confirm('The word \\'{input}\\' is not present. Do you want to add it?');" +
                                $"if (confirmed) {{ window.location.href = 'AddWord.aspx?newword={Server.UrlEncode(input)}'; }}";

                ClientScript.RegisterStartupScript(this.GetType(), "ConfirmAdd", script, true);
            }
        }

        protected void txtWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}