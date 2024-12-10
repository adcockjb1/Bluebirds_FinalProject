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
        <p>Question 273, solved by Peyton Bock</p>
    </div>
        <div>
             <p>Question - Convert Integer to English Words, solved by Peyton Bock</p>
        </div>
        <div>
            <p>Problem description: Convert a non-negative integer num to its English words representation.</p>
        </div>
        <div>
            <asp:Label ID="peytonInputLabel" runat="server" Text="Enter a number:"></asp:Label>
            <asp:TextBox ID="peytonInput" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="PeytonButton" runat="server" Text="Solve" OnClick="ProblemConvertToWords" />
            <br />
            <asp:Label ID="peytonExplanation" runat="server"></asp:Label>
            <br />
            <asp:Label ID="peytonSolution" runat="server"></asp:Label>
        </div>
    <br/>
    <br/>

    <div>
    <p>Question 773, solved by Evan Bolin</p>
</div>
      <div>
                <asp:Button ID="LeetCode773Button" runat="server" Text="Solve Problem 773" OnClick="SolveLeetCode773" />
            <br />
            <asp:Label ID="problemDescription" runat="server"></asp:Label>
            <br />
            <asp:Label ID="exampleBoardLabel" runat="server"></asp:Label>
            <br />
            <asp:Label ID="solutionLabel" runat="server"></asp:Label>
        </div>
    <div>
        <p>Question xx, solved by xxx</p>
    </div>

    <br/>
    <br/>
    </form>
</body>
</html>