<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Mvc_Demo.Models.Employee>>" %>
        <h2>Index - ASCX</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Name) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Gender) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.City) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.DepartmentId) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Name) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Gender) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.City) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DepartmentId) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.EmployeeId }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.EmployeeId }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.EmployeeId }) %>
        </td>
    </tr>
<% } %>

</table>
