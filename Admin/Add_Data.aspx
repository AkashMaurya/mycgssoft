<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Add_Data.aspx.cs" Inherits="CGSSOFT.Admin.Add_Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <h2 class="display-4" style="text-align: center;">Add Data to CGS Soft </h2>

                <!-- Ques 1 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Select Thesis Type
                    </div>
                    <div class="col-md-6">

                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Thesis_Type" DataValueField="Thesis_Type">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CS %>" SelectCommand="SELECT DISTINCT [Thesis_Type] FROM [ThesisType]"></asp:SqlDataSource>
                    </div>
                </div>



                <!-- Ques 2 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Select Department
                    </div>
                    <div class="col-md-6">

                        <asp:DropDownList ID="DropDownList2" runat="server" class="form-control" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="Department" DataValueField="Department">
                        </asp:DropDownList>

                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CS %>" SelectCommand="SELECT DISTINCT [Department] FROM [Department] WHERE ([Thesis_Type] = @Thesis_Type)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList1" Name="Thesis_Type" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                    </div>
                </div>




                <!-- Ques 3 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Type The Thesis Title
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Type the Thesis Type" class="form-control"></asp:TextBox>

                    </div>
                </div>





                <!-- Ques 4 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Type Student Name
                    </div>
                    <div class="col-md-6">


                        <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Type the Student Name"></asp:TextBox>
                    </div>
                </div>



                <!-- Ques 5 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Type the First Supervisor Name
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Type the First Supervisor Name"></asp:TextBox>

                    </div>
                </div>


                <!-- Ques 6 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Type the Second Supervisor Name
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox4" runat="server" class="form-control" placeholder=" Type the Second Supervisor Name"></asp:TextBox>

                    </div>
                </div>

                <!-- Ques 7 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Type the External Supervisor Name
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox5" runat="server" class="form-control" placeholder=" Type the Second Supervisor Name"></asp:TextBox>

                    </div>
                </div>

                <!-- Ques 8 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Paste the Link of View PDF Link
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox6" runat="server" class="form-control" placeholder="Paste the Link of View PDF Link"></asp:TextBox>

                    </div>
                </div>

                <!-- Ques 9 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Type The Year
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox7" runat="server" class="form-control" placeholder="Type The Year" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" MaxLength="4"></asp:TextBox>

                    </div>
                </div>

                <!-- Ques 9 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        Paste the Link of Download PDF Link
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox8" runat="server" class="form-control" placeholder="Paste the Link of Download PDF Link"></asp:TextBox>

                    </div>
                </div>

                <br>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>


        <div class="text-center">

            <asp:Button ID="Button1" runat="server" Text="Save Records" class="btn btn-primary" OnClick="Button1_Click" UseSubmitBehavior="false" />
        </div>
    </div>
    <br>
    <br>
</asp:Content>
