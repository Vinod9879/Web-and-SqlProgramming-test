using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebformApp
{
    public partial class AddWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string wordParam = Request.QueryString["word"];
                string newWordParam = Request.QueryString["newword"];

                if (wordParam != null)
                {
                    
                    var word = Search.words.FirstOrDefault(w => w.EnglishWord.ToLower() == wordParam);
                    if (word != null)
                    {
                        lblWord.Text = word.EnglishWord + " ";
                        txtTranslation.Text = word.Translation;
                        lblMessage.Text = "Updating existing word.";
                    }
                }
                else if (newWordParam != null)
                {
                    
                    lblWord.Text = newWordParam + " ";
                    txtTranslation.Text = "";
                    lblMessage.Text = "Adding new word. Please provide a translation.";
                }

                BindGrid();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string wordParam = Request.QueryString["word"];
            string newWordParam = Request.QueryString["newword"];
            string translation = txtTranslation.Text.Trim();

            if (wordParam != null)
            {
                
                var wordToUpdate = Search.words.FirstOrDefault(w => w.EnglishWord.ToLower() == wordParam);
                if (wordToUpdate != null)
                {
                    wordToUpdate.Translation = translation;
                }
            }
            else if (newWordParam != null)
            {
                
                Search.words.Add(new Search.Word { EnglishWord = newWordParam, Translation = translation });
            }

            BindGrid();

        }
        private void BindGrid()
        {
            gvWords.DataSource = Search.words;
            gvWords.DataBind();
        }
    }
}