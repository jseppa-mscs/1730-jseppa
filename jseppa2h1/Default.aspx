<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="jseppa2h1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6">
            <h2>DateTime Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="1) DateTime.Now: "></asp:Label>
                <asp:TextBox ID="TextBox1aResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox1bResult" runat="server" Enabled="False"></asp:TextBox>
            
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="2) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox2aResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox2bResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="3) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox3aResult" runat="server" Enabled="False" Width="50px"></asp:TextBox>
                <asp:TextBox ID="TextBox3bResult" runat="server" Enabled="False" Width="50px"></asp:TextBox>
                <asp:TextBox ID="TextBox3cResult" runat="server" Enabled="False" Width="50px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="4) DateTime.AddDays(90): "></asp:Label>
                <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="5) DateTime.AddMonths(3): "></asp:Label>
                <asp:TextBox ID="TextBox5Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="6) DateTime(y, m, d): "></asp:Label>
                <asp:TextBox ID="TextBox6aInput" runat="server" Enabled="True" Width="50px"></asp:TextBox>
                <asp:TextBox ID="TextBox6bInput" runat="server" Enabled="True" Width="50px"></asp:TextBox>
                <asp:TextBox ID="TextBox6cInput" runat="server" Enabled="True" Width="50px"></asp:TextBox>
                <asp:TextBox ID="TextBox6Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="7) DateTime.Parse(): "></asp:Label>
                <asp:TextBox ID="TextBox7Input" runat="server" Enabled="True"></asp:TextBox>
                <asp:TextBox ID="TextBox7Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="8) DateTime.TryParse(): "></asp:Label>
                <asp:TextBox ID="TextBox8Input" runat="server" Enabled="True"></asp:TextBox>
                <asp:TextBox ID="TextBox8Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="9) DateA - DateB: "></asp:Label>
                <asp:TextBox ID="TextBox9aInput" runat="server" Enabled="True" Width="100px"></asp:TextBox>
                <asp:TextBox ID="TextBox9bInput" runat="server" Enabled="True" Width="100px"></asp:TextBox>
                <asp:TextBox ID="TextBox9Result" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="10) DateA &gt; DateB: "></asp:Label>
                <asp:TextBox ID="TextBox10aInput" runat="server" Enabled="True" Width="100px"></asp:TextBox>
                <asp:TextBox ID="TextBox10bInput" runat="server" Enabled="True" Width="100px"></asp:TextBox>
                <asp:TextBox ID="TextBox10Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="DateCalculationButton" runat="server" Text="Date Calculations" OnClick="DateCalculationButton_Click" />
            </div>
        </div>
        
        
        <div class="col-md-6">
            <h2>String Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="1) Remove/Insert: "></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server">late</asp:TextBox>
                <asp:TextBox ID="TextBox11Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="2) Remove/Insert: "></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server">crater</asp:TextBox>
                <asp:TextBox ID="TextBox12Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label13" runat="server" Text="3) Substring/ToUpper: "></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server">ABBlue22</asp:TextBox>
                <asp:TextBox ID="TextBox13Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label14" runat="server" Text="4) Padleft: "></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server">123.45</asp:TextBox>
                <asp:TextBox ID="TextBox14Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label15" runat="server" Text="5) Replace: "></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox15Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label16" runat="server" Text="6) Replace/Length/Insert: "></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox16Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label17" runat="server" Text="7) ToLower/Contains: "></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server">308 Pioneer Road</asp:TextBox>
                <asp:TextBox ID="TextBox17Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label18" runat="server" Text="8) IndexOf/Substring: "></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server" Width="175px">1250 Homer Road, Winona</asp:TextBox>
                <asp:TextBox ID="TextBox18Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label19" runat="server" Text="9) LastIndexOf/Substring:  "></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server" Width="225px">111 1st St, Lake City, MN 55041</asp:TextBox>
                <asp:TextBox ID="TextBox19Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label20" runat="server" Text="10) StringBuilder.Append: "></asp:Label>
                <asp:Label ID="Label20Result" runat="server" Text="Label20Result"></asp:Label>
                </div>
                    <asp:Button ID="StringCalcButton" runat="server" Text="String Calculations" OnClick="StringCalcButton_Click" />
                </div>
    </div>

</asp:Content>
