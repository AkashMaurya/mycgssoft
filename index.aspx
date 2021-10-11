<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CGSSOFT.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>



            <!-- Navbar -->

            <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
                <div class="carousel-indicators">
                    <!-- <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" runat="server" aria-label="Slide 1"></button> -->
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2" runat="server"></button>

                </div>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <!-- <img src="images/2.png" class="d-block w-100" alt="..."> -->
                    </div>
                    <div class="carousel-item active">
                        <img src="images/3.png" class="d-block w-100" alt="...">
                    </div>

                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>

            <!-- CGS SOFT -->
            <div class="row mt-4" id="thesis">
                <div class="col-md-12" style="text-align: center;">
                    <h1 class="display-4" style="font-weight: 400; font-style: italic;">CGS THESIS PORTAL</h1>
                    <i class=" fa-3x las la-angle-double-down "></i>
                </div>
            </div>

            <!-- search and tags -->
            <div class="container">
                <div class="row">
                    <div class="col-md-6">
                        <h3>Discover Thesis</h3>
                        <p>
                            Access over 1117 Thesis and stay up to date with what&#39;s happening in your field
                        </p>

                        <asp:TextBox ID="TextBox1" runat="server" class="form-control" type="text" placeholder="Search...." AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

                    </div>

                    <div class="col-md-6 " style="text-align: center;">
                        <h3 class="mt-4">Sort By Type </h3>

                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-select mt-md-4" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>All Thesis</asp:ListItem>
                            <asp:ListItem>PHD Thesis</asp:ListItem>
                            <asp:ListItem>Master Thesis</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;


                            <br />
                    </div>
                </div>

                <!-- Sort by Department-->
                <div class="row mt-3">

                    <div class="col-md-12 mt-2 " style="text-align: center;">

                        <h3 class="mb-2">Sort By Deparment </h3>

                        <asp:DropDownList ID="DropDownList2" runat="server" class="form-select mt-md-4" AutoPostBack="True" DataTextField="Department" DataValueField="Department" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>All</asp:ListItem>
                            <asp:ListItem>Learning & Developmental Disabilities</asp:ListItem>
                            <asp:ListItem>Distance Learning</asp:ListItem>
                            <asp:ListItem>Natural Resources & Environment</asp:ListItem>
                            <asp:ListItem>Life Science</asp:ListItem>
                            <asp:ListItem>Geoinformatics</asp:ListItem>
                            <asp:ListItem>Gifted Education</asp:ListItem>
                            <asp:ListItem>Technology and Innovation</asp:ListItem>



                        </asp:DropDownList>




                        <br />
                    </div>
                </div>



                <!-- Sort by Department-->
                <div class="row">

                    <div class="col-md-12 " style="text-align: center;">

                        <br />
                        <br />
                    </div>
                </div>



                <div class="row mt-4">
                    <div class="col-md-12">
                        <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" CssClass="table-responsive">
                            <!-- Gridview -->
                            <div class="auto-style1">
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" CssClass="table table-bordered table-hover table-responsive" ForeColor="#333333" GridLines="None" PageSize="25" OnPageIndexChanging="GridView1_PageIndexChanging1">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:BoundField DataField="Thesis_Type" HeaderText="Thesis Type" />
                                        <asp:BoundField DataField="Department" HeaderText="Department" />
                                        <asp:BoundField DataField="ThesisTitle" HeaderText="Thesis Title" />
                                        <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                                        <asp:BoundField DataField="First_Supervisor" HeaderText="First Supervisor" />
                                        <asp:BoundField DataField="Second_Supervisor" HeaderText="Second Supervisor" />
                                        <asp:BoundField DataField="Ext_Supervisor" HeaderText="Ext. Supervisor" />
                                        <asp:HyperLinkField DataNavigateUrlFields="Files" HeaderText="Files" Text="View" />
                                        <asp:BoundField DataField="EYear" HeaderText="Year" />
                                    </Columns>
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                </asp:GridView>


                            </div>
                        </asp:Panel>
                    </div>
                </div>

            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CS %>" SelectCommand="SELECT [Thesis_Type], [Department], [ThesisTitle], [StudentName], [First_Supervisor], [Second_Supervisor], [Ext_Supervisor], [Files], [EYear] FROM [All_Thesis_Data]"></asp:SqlDataSource>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-12" style="text-align: center">
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>
