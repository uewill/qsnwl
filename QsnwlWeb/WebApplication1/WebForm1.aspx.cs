﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TFXK.BLL.ArticlesBLL bllArticles = new TFXK.BLL.ArticlesBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            bllArticles.GetAllList();
        }
    }
}