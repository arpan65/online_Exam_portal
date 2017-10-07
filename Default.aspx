<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"  MasterPageFile="~/Master1.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

    <title></title>
    
        .<body><div style="width:100%; height:36px;background-color:#180000; text-align: center; font-family: 'Courier New', Courier, monospace; font-size: xx-large; font-style: italic; font-weight: 700; color: #0099FF;">

        WELCOME TO ONLINE TEST PORTAL

    </div>
    <hr style="color:Blue"/>
    <div style="width:98%; height:355px ;background-color:#99CCFF;border:3px #FFFFFF">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <table class="style1">
            <tr>
                <td class="style7">
        &nbsp;&nbsp;
        <asp:ImageButton ID="signup_img_btn" runat="server" Height="201px" 
            Width="237px" ImageUrl="~/images/signup.jpg" onclick="signup_img_btn_Click" />
            
    
                </td>
                <td class="style4">
                    &nbsp;&nbsp;&nbsp;<asp:Label ID="err_lbl1" runat="server" Width="200px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Panel ID="Panel1" runat="server" BackColor="#B0B0B0" Height="237px" 
                        BorderColor="#505050" BorderStyle="Dashed" BorderWidth="3px" 
                        style="margin-left: 201px" Visible="False" 
                        Width="85%" >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <table class="style8">
                            <tr>
                                <td class="style11">
                                    &nbsp;&nbsp;
                                    <asp:Label ID="uid_label" runat="server" ForeColor="White" 
                                        style="font-weight: 700; font-style: italic; font-family: 'Agency FB'" 
                                        Text="UID :"></asp:Label>
                                </td>
                                <td class="style10">
                                    <asp:TextBox ID="uid_tb" runat="server" MaxLength="50"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    &nbsp;&nbsp;
                                    <asp:Label ID="name_label" runat="server" ForeColor="White" 
                                        style="font-weight: 700; font-style: italic; font-family: 'Agency FB'" 
                                        Text="Name :"></asp:Label>
                                </td>
                                <td class="style10">
                                    <asp:TextBox ID="name_tb" runat="server" MaxLength="50"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="pwd_label" runat="server" ForeColor="White" 
                                        style="font-family: 'Agency FB'; font-weight: 700; font-style: italic" 
                                        Text="Password :"></asp:Label>
                                </td>
                                <td class="style16">
                                    <asp:TextBox ID="pwd_tb" runat="server" MaxLength="50" 
                                       TextMode="Password" style="margin-left: 4px" Width="128px" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="cnfpwd_label" runat="server" ForeColor="White" 
                                        style="font-weight: 700; font-style: italic; font-family: 'Agency FB'" 
                                        Text="Re-enter password :"></asp:Label>
                                </td>
                                <td class="style10">
                                    <asp:TextBox ID="cnfpwd_tb" runat="server" ForeColor="Black" 
                                        TextMode="Password" BackColor="White"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    &nbsp;&nbsp;
                                    <asp:Label ID="email_label" runat="server" ForeColor="White" 
                                        style="font-family: 'Agency FB'; font-weight: 700; font-style: italic" 
                                        Text="E-mail :"></asp:Label>
                                </td>
                                


                                <td class="style10">
                                    <asp:TextBox ID="email_tb" runat="server" MaxLength="50"   Font-Italic="True"  >example@sample.com</asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email_tb" ErrorMessage="not in correct format" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    &nbsp;&nbsp;
                                    <asp:Label ID="mb_label" runat="server" ForeColor="White" 
                                        style="font-weight: 700; font-style: italic; font-family: 'Agency FB'" 
                                        Text="Mobile :"></asp:Label>
                                </td>
                                <td class="style10">
                                    <asp:TextBox ID="mb_tb" runat="server" MaxLength="10" Width="128px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    &nbsp;</td>
                                <td class="style10">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    <asp:Button ID="admin_btn" runat="server" BackColor="#B0B0B0" ForeColor="White" OnClick="admin_btn_Click" style="font-style: italic" Text="Admin" />
                                </td>
                                <td class="style10">
                                    <asp:Button ID="signup_btn" runat="server" BackColor="#000033" 
                                        BorderColor="Black" BorderStyle="Dashed" ForeColor="White" 
                                        onclick="signup_btn_Click" style="font-weight: 700; margin-left: 110px;" 
                                        Text="Sign  Up" Width="69px" />
                                </td>
                            </tr>
                        </table>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
        </table>
            
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
    
    </div>
    <div style="width:98%; height:355px;background-color:#B0B0B0;border:3px #FFFFFF; margin-right: 0px;">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <table class="style1">
            <tr>
                <td class="style6">
    
        &nbsp;&nbsp;
    
        <asp:ImageButton ID="signin_img_btn" runat="server" Height="201px" 
            Width="237px" BackColor="#B0B0B0" ImageUrl="~/images/signin.jpg" 
                        onclick="signin_img_btn_Click"  />
    
                </td>
                <td class="style5">
                    <asp:Panel ID="Panel2" runat="server" BackColor="#99CCFF" Height="210px" 
                        BorderColor="White" BorderStyle="Dashed" BorderWidth="3px" 
                        Direction="LeftToRight" style="margin-left: 61px" Visible="False" 
                        Width="98%" >
                        &nbsp;<br />
                        <table class="style8">
                            <tr>
                                <td class="style12">
                                    <asp:Label ID="uid_label2" runat="server" ForeColor="#000033" 
                                        style="font-family: 'Agency FB'; font-size: large; font-weight: 700; font-style: italic" 
                                        Text="UID :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="uid_tb2" runat="server" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uid_tb2" ErrorMessage="mendetory field" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    <asp:Label ID="pwd_label2" runat="server" ForeColor="#000033" 
                                        style="font-weight: 700; font-style: italic; font-family: 'Agency FB'; font-size: large" 
                                        Text="Password :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="pwd_tb2" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pwd_tb2" ErrorMessage="mendetory field" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    &nbsp;</td>
                                <td>
                                    <asp:LinkButton ID="frgtpwd_btn" runat="server" ForeColor="Black" Text-Decoration="none"
                                        style="font-weight: 700" onclick="frgtpwd_btn_Click">Forgot Password </asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td class="style13">
                                    <asp:Label ID="err_lbl2" runat="server"></asp:Label>
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <asp:Button ID="admin_btn2" runat="server" BackColor="#484848" OnClick="admin_btn2_Click" style="font-style: italic" Text="Admin" />
                                </td>
                                <td class="style14">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <br />
                                    <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="signin_btn" runat="server" BackColor="#484848" 
                                        ForeColor="White" onclick="signin_btn_Click" style="font-weight: 700" 
                                        Text="Sign  In" />
                                </td>
                            </tr>
                        </table>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </asp:Panel>
                </td>
            </tr>
        </table>
    
    </div>
   
</body>
</html>
    </asp:content>
