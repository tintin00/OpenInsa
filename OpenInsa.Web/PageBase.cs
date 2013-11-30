using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using IBatisNet.Common;
using IBatisNet.DataMapper;


namespace OpenInsa.Web
{
    public class PageBase : System.Web.UI.Page, IDisposable
    {
        public string UserID = null;
        public string UserName = null;
        public string UserPwd = null;

        protected ISqlMapper mapper = Mapper.Instance();
        
        protected override void OnPreLoad(EventArgs e)
        {
            base.OnPreLoad(e);

            if (Session["UserID"] != null)
            {
                this.UserID = Session["UserID"].ToString();
                this.UserName = Session["UserName"].ToString();
                this.UserPwd = Session["UserPwd"].ToString();
            }
            else
            {
                this.UserID = null;
            }

        }
        
        public PageBase()
        {
        }

        public override void  Dispose()
        {
            ;
        }

        //public void SetUserInfo()
        //{
        //    if (Session["USER_ID"] != null)
        //    {
        //        this.UserID = Session["USER_ID"].ToString();
        //    }
        //    else
        //    {
        //        this.UserID = null;
        //    }
        //}


        //public virtual void Dispose();
        //protected virtual void Dispose(bool disposing);

    }
}