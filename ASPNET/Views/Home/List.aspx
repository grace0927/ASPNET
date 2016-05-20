<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title></title>
</head>
<body>
	<div>
	<ul>
	<% foreach(var food in ViewBag.ListFoods) {%>
		<li><%: food %></li>
	<% } %>
	</ul>
	</div>
</body>
