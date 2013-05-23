<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/EightBall.svc" />
        </Services>
    </asp:ScriptManager>

    <input type="text" id="txtInput" />
    <p>Please enter a number between 0 and 4.</p>
    <input type="button" id="btnGo" value="Shake the ball!" onclick="ShakeIt();" />
    <p id="theResult"></p>

    <script type="text/javascript">
        function ShakeIt() {
            var i = document.getElementById('txtInput').value;
            
            EightBall.getQuote(i, TestServiceCallBack(), TestServiceError());
        }

        function TestServiceCallBack(result) {
            document.getElementById('theResult').innerHTML = result;

        }

        function TestServiceError() {
           //document.getElementById('theResult').innerHTML = "Danger Will Robinson, Danger!";
        }

    </script>
</asp:Content>

