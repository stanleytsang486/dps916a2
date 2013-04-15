﻿@ModelType A2MVCApplication.A2Models.RecordModel

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>RecordModel</legend>
         @Html.HiddenFor(Function(model) model.AddressBookId)
        @Html.HiddenFor(Function(model) model.RecordId)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.UserName, "UserName")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.UserName)
            @Html.ValidationMessageFor(Function(model) model.AddressBookId)
        </div>
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Notes)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Notes)
            @Html.ValidationMessageFor(Function(model) model.Notes)
        </div>
        <br />
        <table>
            <tr>
                <th>Addresses</th>
                <td class="adjusted">@Html.ActionLink("Add New Address", "Create", "Address", New With {.id = Model.RecordId}, Nothing)</td>
            </tr>

        @For Each item In Model.Addresses
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.DisplayFor(Function(Model) currentItem.Text)
                </td>
                <td class="adjusted">
                    @Html.ActionLink("Edit", "Edit", "Address", New With {.id = currentItem.AddressId}, Nothing)
                    @Html.ActionLink("Delete", "Delete", "Address", New With {.id = currentItem.AddressId}, Nothing)
                </td>
            </tr>
        Next
        </table>
        <br />
        <table>
            <tr>
                <th>Phone Numbers</th>
                <td class="adjusted">@Html.ActionLink("Add New Phone Number", "Create", "PhoneNumber", New With {.id = Model.RecordId}, Nothing)</td>
            </tr>

        @For Each item In Model.PhoneNumbers
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.DisplayFor(Function(Model) currentItem.Text)
                </td>
                <td class="adjusted">
                    @Html.ActionLink("Edit", "Edit", "PhoneNumber", New With {.id = currentItem.PhoneNumberId}, Nothing)
                    @Html.ActionLink("Delete", "Delete", "PhoneNumber", New With {.id = currentItem.PhoneNumberId}, Nothing)
                </td>
            </tr>
        Next
        </table>
        <br />
        <table>
            <tr>
                <th>Cell Phone Numbers</th>
                <td class="adjusted">@Html.ActionLink("Add New Cell Phone Number", "Create", "CellPhoneNumber", New With {.id = Model.RecordId}, Nothing)</td>
            </tr>

        @For Each item In Model.CellPhoneNumbers
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.DisplayFor(Function(Model) currentItem.Text)
                </td>
                <td class="adjusted">
                    @Html.ActionLink("Edit", "Edit", "CellPhoneNumber", New With {.id = currentItem.CellPhoneId}, Nothing)
                    @Html.ActionLink("Delete", "Delete", "CellPhoneNumber", New With {.id = currentItem.CellPhoneId}, Nothing)
                </td>
            </tr>
        Next
        </table>
        <br />
        <table>
            <tr>
                <th>Email Addresses</th>
                <td class="adjusted">@Html.ActionLink("Add New Email Address", "Create", "Email", New With {.id = Model.RecordId}, Nothing)</td>
            </tr>

        @For Each item In Model.EmailAddresses
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.DisplayFor(Function(Model) currentItem.Text)
                </td>
                <td class="adjusted">
                    @Html.ActionLink("Edit", "Edit", "Email", New With {.id = currentItem.EmailId}, Nothing)
                    @Html.ActionLink("Delete", "Delete", "Email", New With {.id = currentItem.EmailId}, Nothing)
                </td>
            </tr>
        Next
        </table>
        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
