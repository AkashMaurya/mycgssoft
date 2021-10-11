<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="View_Data.aspx.cs" Inherits="CGSSOFT.Admin.View_Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


    <div class="container">
        <h2 class="display-4" style="text-align: center;">Add Data to CGS Soft </h2>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>




                <!-- Ques 3 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        <h3>Search Data </h3>
                    </div>
                    <div class="col-md-6">

                        <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Search Data" OnTextChanged="TextBox1_TextChanged"> </asp:TextBox>
                    </div>
                </div>

                <!-- Ques 3 -->
                <div class="row mt-4">
                    <div class="col-md-6">
                        <!-- Put Lable Here  -->
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </div>

                </div>

                <!-- Ques 3 -->
                <div class="row mt-4">
                    <div class="col-md-12">
                        <!-- Put GridView Here  -->
                    

                            <asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal">
                                <asp:GridView ID="GridView1" runat="server" CellPadding="4" CssClass="table table-bordered table-hover table-responsive" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" Style="margin-bottom: 0px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting"  OnPageIndexChanging="GridView1_PageIndexChanging">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="ID">
                                            <EditItemTemplate>
                                                <asp:Label ID="Label11" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Thesis Type">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("Thesis_Type") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Thesis_Type") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Department">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("Department") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("Department") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Thesis Title">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("ThesisTitle") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("ThesisTitle") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Student Name">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("StudentName") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("StudentName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>


                                        <asp:TemplateField HeaderText="First Supervisor">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox6" runat="server" Text='<%# Eval("First_Supervisor") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("First_Supervisor") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Second Supervisor">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox7" runat="server" Text='<%# Eval("Second_Supervisor") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label8" runat="server" Text='<%# Eval("Second_Supervisor") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Ext Supervisor">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox8" runat="server" Text='<%# Eval("Ext_Supervisor") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label9" runat="server" Text='<%# Eval("Ext_Supervisor") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="View Files">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox9" runat="server" Text='<%# Eval("Files") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label12" runat="server" Text='<%# Eval("Files") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Year">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox10" runat="server" Text='<%# Eval("EYear") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label10" runat="server" Text='<%# Eval("EYear") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Download File">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox11" runat="server" Text='<%# Eval("DFILE") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                                            </FooterTemplate>
                                            <ItemTemplate>

                                                <asp:Label ID="Label14" runat="server" Text='<%# Eval("DFILE") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>



                                        <asp:TemplateField HeaderText="Operation">
                                            <EditItemTemplate>
                                                <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Update">Update</asp:LinkButton>
                                                &nbsp;&nbsp;
                                                <asp:LinkButton ID="LinkButton4" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Insert</asp:LinkButton>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                                                &nbsp;&nbsp;
                                                <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>


                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerSettings Mode="NumericFirstLast" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                </asp:GridView>
                            </asp:Panel>

                        
                    </div>
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>

        <br>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CS %>" DeleteCommand="DELETE FROM [All_Thesis_Data] WHERE [Id] = @original_Id" InsertCommand="INSERT INTO [All_Thesis_Data] ([Thesis_Type], [Department], [ThesisTitle], [StudentName], [First_Supervisor], [Second_Supervisor], [Ext_Supervisor], [Files], [EYear], [DFILE]) VALUES (@Thesis_Type, @Department, @ThesisTitle, @StudentName, @First_Supervisor, @Second_Supervisor, @Ext_Supervisor, @Files, @EYear, @DFILE)" SelectCommand="SELECT * FROM [All_Thesis_Data]" UpdateCommand="UPDATE [All_Thesis_Data] SET [Thesis_Type] = @Thesis_Type, [Department] = @Department, [ThesisTitle] = @ThesisTitle, [StudentName] = @StudentName, [First_Supervisor] = @First_Supervisor, [Second_Supervisor] = @Second_Supervisor, [Ext_Supervisor] = @Ext_Supervisor, [Files] = @Files, [EYear] = @EYear, [DFILE] = @DFILE WHERE [Id] = @original_Id" OldValuesParameterFormatString="original_{0}">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Thesis_Type" Type="String" />
                <asp:Parameter Name="Department" Type="String" />
                <asp:Parameter Name="ThesisTitle" Type="String" />
                <asp:Parameter Name="StudentName" Type="String" />
                <asp:Parameter Name="First_Supervisor" Type="String" />
                <asp:Parameter Name="Second_Supervisor" Type="String" />
                <asp:Parameter Name="Ext_Supervisor" Type="String" />
                <asp:Parameter Name="Files" Type="String" />
                <asp:Parameter Name="EYear" Type="String" />
                <asp:Parameter Name="DFILE" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Thesis_Type" Type="String" />
                <asp:Parameter Name="Department" Type="String" />
                <asp:Parameter Name="ThesisTitle" Type="String" />
                <asp:Parameter Name="StudentName" Type="String" />
                <asp:Parameter Name="First_Supervisor" Type="String" />
                <asp:Parameter Name="Second_Supervisor" Type="String" />
                <asp:Parameter Name="Ext_Supervisor" Type="String" />
                <asp:Parameter Name="Files" Type="String" />
                <asp:Parameter Name="EYear" Type="String" />
                <asp:Parameter Name="DFILE" Type="String" />
                <asp:Parameter Name="original_Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br>
        <div class="text-center">

            <!--  <asp:Button ID="Button1" runat="server" Text="Print in Excel " OnClick="Button1_Click" Style="height: 29px" CssClass="btn btn-warning" /> -->
        </div>
        <br>
        <br>
    </div>


</asp:Content>
