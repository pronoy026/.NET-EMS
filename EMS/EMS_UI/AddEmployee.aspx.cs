using EMS_DAL;
using EMS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS_UI
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownListDept.DataSource = DAL.GetDepartments();
                DropDownListDept.DataBind();

                DropDownListManager.DataSource = DAL.GetEmployeeIdAndName();
                DropDownListManager.DataBind();

                DropDownListManager.Items.Add(new ListItem("--Select--", "0"));
                DropDownListManager.SelectedValue = "0";

                CompareValidator1.ValueToCompare = DateTime.Now.ToShortDateString();  // for comparing with current date
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Name = TextBoxName.Text,
                Email = TextBoxEmail.Text,
                Gender = RadioButtonListGender.SelectedItem.Text,
                DepartmentNo = Convert.ToInt32(DropDownListDept.SelectedItem.Value),
                DateOfBirth = Convert.ToDateTime(TextBoxDOB.Text),
                DateOfJoining = Convert.ToDateTime(TextBoxDOJ.Text),
                ReportingTo = Convert.ToInt32(DropDownListManager.SelectedItem.Value),
                Phone = Convert.ToInt64(TextBoxPhone.Text),
                Salary = Convert.ToInt32(TextBoxSalary.Text),
                Commission = Convert.ToInt32(TextBoxCommision.Text),
                JobTitle = DropDownListJobTitle.SelectedItem.Text
            };
            var result = DAL.AddEmployee(employee);

            if (result)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Employee Added Successfully');" +
                    "window.location='EmployeeList.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Failed to Add employee');", true);
            }

            Response.Redirect("EmployeeList.aspx");
        }
    }
}