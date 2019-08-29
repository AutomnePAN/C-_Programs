using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
   

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public RegistrationInfo RegistrationInfo
        {
            get
            {
                return new RegistrationInfo
                {
                    FirstName = textFirstName.Text,
                    LastName = textLastName.Text,
                    Email = textEmail.Text,
                    SelectedEvent = dropDownListEvents.SelectedValue
                };
            }
        }

    }


}