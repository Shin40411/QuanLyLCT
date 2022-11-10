<%@ Control AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Containers.Container" %>
<%@ Register TagPrefix="dnn" TagName="TITLE" Src="~/Admin/Containers/Title.ascx" %>
<div class="panel panel-default cmtt-container-panel">
    <div class="panel-heading panel_head_blue_custom">
        <h3 class="panel-title"><dnn:TITLE CssClass="font Head" runat="server" id="dnnTITLE" /></h3>
    </div>
    <div class="panel-body"  id="ContentPane" runat="server">
    </div>
</div>


<style>
   .cmtt-container-panel > .panel-heading{
        display:none;
    }

  div.cmtt-container-panel div.panel-body div.tinnoibat div.title p span{
        background-image: linear-gradient(to bottom, #189bf7 0, #189bf7 100%) !important;
        padding: 6px 15px 7px 15px;
        border-radius: 2px;
        /* box-shadow: 0 10px 30px -12px rgba(146, 0, 0, 0.42), 0 4px 25px 0px rgba(146, 0, 0, 0.12), 0 8px 10px -5px rgba(146, 0, 0, 0.2) !important; */
        box-shadow: -2px 2px 4px #c5b5b5;
        margin-top: 10px;
       text-transform: uppercase;
       color:white;
    }
 div.cmtt-container-panel div.panel-body div.tinnoibat div.title p {
       border-bottom:unset;
       padding-left:0px;
 }
  div.cmtt-container-panel div.panel-body div.tinnoibat div.title {
     margin-bottom:30px;
       
 }
</style>