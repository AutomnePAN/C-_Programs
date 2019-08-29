using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!PreviousPage.IsValid)
                {
                    labelResult.Text = "Error in previous page";
                    return;
                }
                //DropDownList dropDownListEvents = (DropDownList)PreviousPage.FindControl("dropDownListEvents");
                //string selectedEvent = dropDownListEvents.SelectedValue;
                labelResult.Text = "1";
                string firstName = ((TextBox) (PreviousPage.FindControl(
                "textFirstName"))).Text;
                labelResult.Text = "2";
                string lastName = ((TextBox) (PreviousPage.FindControl(
                "textLastName"))).Text;
                labelResult.Text = "3";
                string email = ((TextBox) (PreviousPage.FindControl(
                "textEmail"))).Text;
                labelResult.Text = "4";
                //labelResult.Text = String.Format("{0} {1} selected the event",firstName, lastName);
                //RegistrationInfo ri = PreviousPage.RegistrationInfo;
                /*LabelResult.Text = String.Format("{0} {1} selected the event {2}",
                ri.FirstName, ri.LastName, ri.SelectedEvent);*/
            }
            catch
            {
                labelResult.Text = "The originating page must contain " +
                "textFirstName, textLastName, textEmail controls";
            }
        }
    }
}