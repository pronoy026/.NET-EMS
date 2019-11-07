using EMS_DAL;
using EMS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS_UI
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            DataSet employee = DAL.GetEmployeeById(Convert.ToInt32(TextBoxEmpID.Text));

            if (employee.Tables[0].Rows.Count == 0)
            {
                // employees not found
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "showalert", "alert('Employee not found.');", true);
            }
            else
            {
                TextBoxName.Text = employee.Tables[0].Rows[0]["Name"].ToString();
                TextBoxEmail.Text = employee.Tables[0].Rows[0]["Email"].ToString();
                RadioButtonListGender.SelectedValue = employee.Tables[0].Rows[0]["Gender"].ToString();
                DropDownListDept.SelectedValue = employee.Tables[0].Rows[0]["DepartmentNo"].ToString();
                TextBoxDOB.Text = Convert.ToDateTime(employee.Tables[0].Rows[0]["DateOfBirth"]).ToString("yyyy-MM-dd");
                TextBoxDOJ.Text = Convert.ToDateTime(employee.Tables[0].Rows[0]["DateOfJoining"]).ToString("yyyy-MM-dd");
                if (!string.IsNullOrEmpty(employee.Tables[0].Rows[0]["ReportingTo"].ToString()))
                {
                    DropDownListManager.SelectedValue = employee.Tables[0].Rows[0]["ReportingTo"].ToString();
                }
                TextBoxPhone.Text = employee.Tables[0].Rows[0]["Phone"].ToString();
                TextBoxSalary.Text = employee.Tables[0].Rows[0]["Salary"].ToString();
                TextBoxCommission.Text = employee.Tables[0].Rows[0]["Commission"].ToString();
                DropDownListJobTitle.SelectedValue = employee.Tables[0].Rows[0]["JobTitle"].ToString();
            }
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Number = Convert.ToInt32(TextBoxEmpID.Text),
                Name = TextBoxName.Text,
                Email = TextBoxEmail.Text,
                Gender = RadioButtonListGender.SelectedItem.Text,
                DepartmentNo = Convert.ToInt32(DropDownListDept.SelectedItem.Value),
                DateOfBirth = Convert.ToDateTime(TextBoxDOB.Text),
                DateOfJoining = Convert.ToDateTime(TextBoxDOJ.Text),
                ReportingTo = Convert.ToInt32(DropDownListManager.SelectedItem.Value),
                Phone = Convert.ToInt64(TextBoxPhone.Text),
                Salary = Convert.ToInt32(TextBoxSalary.Text.Split('.')[0]),
                Commission = Convert.ToInt32(TextBoxCommission.Text.Split('.')[0]),
                JobTitle = DropDownListJobTitle.SelectedItem.Text
            };
           bool result =  DAL.UpdateEmployee(employee);
            if (result)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Employee Updated Successfully');" +
                    "window.location='EmployeeList.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Failed to Update employee');", true);
            }
        }
    }
}