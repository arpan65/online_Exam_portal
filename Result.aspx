<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #6666FF;
        }
        .auto-style2 {
            font-size: xx-large;
            text-align: center;
            color: #000066;
            text-decoration: underline;
        }
        .auto-style3 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            color: #99CCFF;
        }
        .auto-style4 {
            font-family: VERdana, Geneva, Tahoma, sans-serif;
            color: #006600;
        }
        .auto-style5 {
            font-family: VERdana, Geneva, Tahoma, sans-serif;
            color: #CC0000;
        }
        .auto-style6 {
            font-family: VERdana, Geneva, Tahoma, sans-serif;
            color: #808080;
        }
        .auto-style7 {
            color: #CC9900;
            font-weight: 700;
            font-family: VERdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style8 {
            width: 100%;
            background-color: #99FFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <table class="auto-style8">
            <tr>
                <td>Welcome </td>
                <td>
                    <asp:Label ID="nm_lbl" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="4"><strong><em>ONLINE EXAMINATION RESULTS</em></strong></td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>TOTAL QUESTIONS :</strong></td>
                <td>
                    <asp:Label ID="tq_lbl" runat="server"></asp:Label>
                </td>
                <td class="auto-style6"><strong style="color: #333333">SKIPPED :</strong></td>
                <td>
                    <asp:Label ID="skpd_lbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><strong>CORRECT :</strong></td>
                <td>
                    <asp:Label ID="crct_lbl" runat="server"></asp:Label>
                </td>
                <td class="auto-style7" style="font-weight: 700; font-family: Verdana, Geneva, Tahoma, sans-serif">TIME TAKEN :</td>
                <td>
                    <asp:Label ID="tt_lbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>WRONG :</strong></td>
                <td>
                    <asp:Label ID="wrng_lbl" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">MARKS OBTAINED :</td>
                <td>
                    <asp:Label ID="mo_lbl" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
