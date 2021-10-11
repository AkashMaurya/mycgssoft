<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CGSSOFT.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>



    <div class="container mt-5">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <!-- <img class="mb-4" src="" alt="" width="72" height="72"> -->
                <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
                <label for="inputEmail" class="sr-only">Username</label>


                <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="User Name"></asp:TextBox>

                <label for="inputPassword" class="sr-only">Password</label>
                <br />
              


                <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>


                <div class="checkbox mb-3">
                    <label>
                        <input type="checkbox" value="remember-me">
                        Remember me
                    </label>
                &nbsp;</div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:Button ID="Button1" runat="server" Text="Sign in" class="btn btn-lg btn-primary btn-block" UseSubmitBehavior="false" OnClick="Button1_Click" />
        <p class="mt-5 mb-3 text-muted">© 2017-2018</p>

    </div>





</asp:Content>
