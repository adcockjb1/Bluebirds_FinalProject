<!--
* Names: Joseph Adcock
* emails: adcockjb@mail.uc.edu
* Assignment: Final Project
* Due Date: 12/10/24
* Course #/Section: IS3050-001
* Semester/Year: Fall 2024
* Brief Description of the assignment: Using an ASP.NET website to solve a LeetCode problem in collaboration with a group using Git.

* Brief Description of what this module does. This project uses git to work with teamates to solve hard LeetCode problems. This is the web for for the solution.
* Citations: LeetCode, ChatGPT
* Anything else that's relevant: Displays asp buttons and executes behind-code C# files when clicked.
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Bluebirds_FinalProject.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Choose Which Problem to Solve</h1>
    </div>

    <div>
        <div>
            <p>Question 37, solved by Joseph Adcock</p>
        </div>
        <div>
            <asp:Button ID="JoeButton" runat="server" Text="Solve" OnClick="Problem37"/>
        </div>
        <br/>
        <div>
            <asp:Label ID="joeExplanation1" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="joeExplanation2" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="joeExplanation3" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="joeExplanation4" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="joeExplanation5" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="joeExplanation6" runat="server"></asp:Label>
        <br/>
        <br/>
            <asp:Label ID="example37" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard1" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard2" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard3" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard4" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard5" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard6" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard7" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard8" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="exBoard9" runat="server"></asp:Label>
        <br/>
        <br/>
            <asp:Label ID="response37" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard1" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard2" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard3" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard4" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard5" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard6" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard7" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard8" runat="server"></asp:Label>
        <br/>
            <asp:Label ID="solvedBoard9" runat="server"></asp:Label>
        <br/>
        </div>
        <br/>
        <br/>
    </div>

    <div>
        <p>Question xx, solved by xxx</p>
    </div>

    <br/>
    <br/>

    <div>
            <p>Question xx, solved by xxx</p>
        </div>

    <br/>
    <br/>

    <div>
        <p>Question xx, solved by xxx</p>
    </div>

    <br/>
    <br/>
    </form>
</body>
</html>