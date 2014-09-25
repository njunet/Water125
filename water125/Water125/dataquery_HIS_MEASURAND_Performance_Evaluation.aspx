<%@ Page Title="" Language="C#" MasterPageFile="~/IndexWaterInfo.Master" AutoEventWireup="true" CodeBehind="dataquery_HIS_MEASURAND_Performance_Evaluation.aspx.cs" Inherits="Water125.dataquery_HIS_MEASURAND_Performance_Evaluation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <%-- <table cellspacing="0" cellpadding="5" width="1200" border="0">
                <tr>
                    <td height="40" align="left">
                        &nbsp;&nbsp;&nbsp; 快速查询：
                        站点名称：
                        <asp:DropDownList ID="ddlStationName" runat="server" Width="10%" ToolTip="关键字" OnSelectedIndexChanged="ddlOnSelectedIndexChanged"></asp:DropDownList>&nbsp;

                        <asp:ImageButton ID="btn_Search" runat="server" ImageUrl="Admin/images/button_search.GIF"
                            ToolTip="快速检索" OnClick="btn_Search_Click"></asp:ImageButton>
                    </td>
                </tr>
            </table>--%>
            
            <table cellspacing="0" cellpadding="5" width="100%" border="0">                
                <tr>
                <td align="left">○页次：<asp:Label ID="lblCurrentPage" runat="server" ForeColor="#e78a29"></asp:Label>页/<asp:Label ID="lblPageCount"
                        runat="server"></asp:Label>页，共<asp:Label ID="lblRowsCount" runat="server" ForeColor="#e78a29"></asp:Label>条记录
                        </td>
                <td align="right">
                [<asp:linkbutton id="btnFirst" runat="server" OnCommand="NavigateToPage" CommandArgument="First"
								CommandName="Pager" Text="首 页">首 页</asp:linkbutton>]
				[<asp:linkbutton id="btnPrev" runat="server" OnCommand="NavigateToPage" CommandArgument="Prev"
								CommandName="Pager" Text="上一页">上一页</asp:linkbutton>]
				[<asp:linkbutton id="btnNext" runat="server" OnCommand="NavigateToPage" CommandArgument="Next"
								CommandName="Pager" Text="下一页">下一页</asp:linkbutton>]
				[<asp:linkbutton id="btnLast" runat="server" OnCommand="NavigateToPage" CommandArgument="Last"
								CommandName="Pager" Text="尾 页">尾 页</asp:linkbutton>]
                </td>
                </tr>
            </table>
            <table cellspacing="0" cellpadding="5" width="100%" border="0">                
                <tr>
                    <td bgcolor='<%=Application[Session["Style"].ToString()+"xtable_bgcolor"]%>'>
                        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" Width="100%"
                            AllowPaging="false" AllowSorting="True" OnRowCreated="gridView_RowCreated" OnPageIndexChanging="gridView_PageIndexChanging"
                            OnRowDataBound="gridView_RowDataBound" CellPadding="5" BorderWidth="1px" PageSize="30" OnSorting="gridView_Sorting"
                            >
                            <Columns> 
                                <asp:BoundField DataField="Indicators" HeaderText="指标" SortExpression="Indicators" /> 
                                <asp:BoundField DataField="Unit" HeaderText="单位" SortExpression="Unit" /> 
                                <asp:BoundField DataField="Y2005" HeaderText="2005年" SortExpression="Y2005" />        
                                <asp:BoundField DataField="Y2006" HeaderText="2006年" SortExpression="Y2006" />
                                <asp:BoundField DataField="Y2007" HeaderText="2007年" SortExpression="Y2007" />
                                <asp:BoundField DataField="Y2008" HeaderText="2008年" SortExpression="Y2008" />
                                <asp:BoundField DataField="Y2009" HeaderText="2009年" SortExpression="Y2009" />
                                <asp:BoundField DataField="Y2010" HeaderText="2010年" SortExpression="Y2010" />
                                <asp:BoundField DataField="Y2011" HeaderText="2011年" SortExpression="Y2011" />
                                <asp:BoundField DataField="Y2012" HeaderText="2012年" SortExpression="Y2012" />
        
                               

                                <asp:HyperLinkField HeaderText="修改" DataNavigateUrlFields="Indicators" DataNavigateUrlFormatString="modify.aspx?id={0}"
                                    Text="修改" Visible="True" />
                                <asp:TemplateField HeaderText="删除" ShowHeader="False" Visible="True">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                            OnClientClick='return confirm("您真的要删除这条记录吗？")' Text="删除"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <PagerSettings Mode="NumericFirstLast" />
                            <PagerStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                        </asp:GridView>
                        <asp:Label ID="Label1" runat="server" Visible="False" ForeColor="Red">没有数据！！</asp:Label>
                    </td>
                </tr>
            </table>           
</asp:Content>
