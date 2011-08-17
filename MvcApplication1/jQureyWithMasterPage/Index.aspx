<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="jQureyWithMasterPage.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Styles/validationEngine.jquery.css" rel="stylesheet" type="text/css" />
    <link href="Styles/template.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Jquery Inline Form Validation Engine</h2>
    <form id="formID" class="formular" method="post" action="">
    <fieldset>
        <legend>User informations</legend>
        <label>
            <span>Desired username : </span>
            <input class="validate[required,custom[noSpecialCaracters],length[0,20]]" type="text"
                name="user" />
        </label>
        <label>
            <span>First name : </span>
            <input class="validate[required,custom[onlyLetter],length[0,100]] text-input" type="text"
                name="firstname" />
        </label>
        <label>
            <span>Last name : </span>
            <input class="validate[required,custom[onlyLetter],length[0,100]] text-input" type="text"
                name="lasttname" />
        </label>
        <div>
            <span>Radio Groupe :
                <br />
            </span><span>radio 1: </span>
            <input class="validate[required] radio" type="radio" name="radiogoupe" value="5">
            <span>radio 2: </span>
            <input class="validate[required] radio" type="radio" name="radiogoupe" value="3" />
            <span>radio 3: </span>
            <input class="validate[required] radio" type="radio" name="radiogoupe" value="9" />
        </div>
        <div>
            <span>Max 2 checkbox :
                <br />
            </span>
            <input class="validate[minCheckbox[2]] checkbox" type="checkbox" name="checkboxgroupe"
                value="5">
            <input class="validate[minCheckbox[2]] checkbox" type="checkbox" name="checkboxgroupe"
                value="3" />
            <input class="validate[minCheckbox[2]] checkbox" type="checkbox" name="checkboxgroupe"
                value="9" />
        </div>
        <label>
            <span>Date : (format YYYY-MM-DD)</span>
            <input class="validate[required,custom[date]] text-input" type="text" name="date" />
        </label>
        <label>
            <span>Favorite sport 1:</span>
            <select name="sport" id="sport" class="validate[required]">
                <option value="">Choose a sport</option>
                <option value="option1">Tennis</option>
                <option value="option2">Football</option>
                <option value="option3">Golf</option>
            </select>
        </label>
        <label>
            <span>Favorite sport 2:</span>
            <select name="sport2" id="sport2" multiple class="validate[required]">
                <option value="">Choose a sport</option>
                <option value="option1">Tennis</option>
                <option value="option2">Football</option>
                <option value="option3">Golf</option>
            </select>
        </label>
        <label>
            <span>Age : </span>
            <input class="validate[required,custom[onlyNumber],length[0,3]] text-input" type="text"
                name="age" />
        </label>
        <label>
            <span>Telephone : </span>
            <input class="validate[required,custom[telephone]] text-input" type="text" name="telephone" />
        </label>
    </fieldset>
    <fieldset>
        <legend>Password</legend>
        <label>
            <span>Password : </span>
            <input class="validate[required,length[6,11]] text-input" type="password" name="password"
                id="password" />
        </label>
        <label>
            <span>Confirm password : </span>
            <input class="validate[required,confirm[password]] text-input" type="password" name="password2" />
        </label>
    </fieldset>
    <fieldset>
        <legend>Email</legend>
        <label>
            <span>Email address : </span>
            <input class="validate[required,custom[email]] text-input" type="text" name="email"
                id="email" />
        </label>
        <label>
            <span>Confirm email address : </span>
            <input class="validate[required,confirm[email]]] text-input" type="text" name="email2" />
        </label>
    </fieldset>
    <fieldset>
        <legend>Comments</legend>
        <label>
            <span>Comments : </span>
            <textarea class="validate[required,length[6,300]] text-input" name="comments" id="comments" />
            </textarea>
        </label>
    </fieldset>
    <fieldset>
        <legend>Conditions</legend>
        <div class="infos">
            Checking this box indicates that you accept terms of use. If you do not accept these
            terms, do not use this website :
        </div>
        <label>
            <span class="checkbox">I accept terms of use : </span>
            <input class="validate[required] checkbox" type="checkbox" name="agree" />
        </label>
    </fieldset>
    <input class="submit" type="submit" value="Validate & Send the form!" />
    <hr />
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
    <script src="Scripts/jquery.js" type="text/javascript"></script>
    <script src="Scripts/jquery.validationEngine-fr.js" type="text/javascript"></script>
    <script src="Scripts/jquery.validationEngine.js" type="text/javascript"></script>
</asp:Content>
