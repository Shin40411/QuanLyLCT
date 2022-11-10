<%@ Control AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Containers.Container" %>
<%@ Register TagPrefix="dnn" TagName="TITLE" Src="~/Admin/Containers/Title.ascx" %>
<div class="panel panel-default yellow-container-panel">
    <div class="panel-heading panel_head_yellow_custom">
        <h3 class="panel-title"><dnn:TITLE CssClass="font Head" runat="server" id="dnnTITLE" /></h3>
    </div>
    <div class="panel-body bcd"  id="ContentPane" runat="server">
    </div>
</div>


<style>
.bcd div .row .container .Seoul-itaewon{
	display:none;
}
.bcd div .row .container .col-md-6{
	width: 100%;
}
</style>

