using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_11MasterPage
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuItem mitm = new MenuItem();
            mitm.Text = "Database Yönetimi";
            mitm.Value = "4";
            mitm.NavigateUrl = "~/Database.aspx";
            Menu1.Items.Add(mitm);

            MenuItem citm = new MenuItem();
            citm.Text = "MSSQL Server";
            citm.Value = "5";
            citm.NavigateUrl = "~/MSSQL.aspx";
            mitm.ChildItems.Add(citm);

            MenuItem citm1 = new MenuItem();
            citm1.Text = "MYSQL Server";
            citm1.Value = "6";
            citm1.NavigateUrl = "~/MYSQL.aspx";
            mitm.ChildItems.Add(citm1);

            TreeNode tnode = new TreeNode();
            tnode.Text = "Mobile Projects";
            tnode.Value = "8";
            tnode.NavigateUrl = "~/Mobile.aspx";
            TreeView1.Nodes.Add(tnode);

            TreeNode cnode = new TreeNode();
            cnode.Text = "Windows Mobile";
            cnode.Value = "9";
            cnode.NavigateUrl = "~/WindowsMobile.aspx";
            tnode.ChildNodes.Add(cnode);
        }
    }
}