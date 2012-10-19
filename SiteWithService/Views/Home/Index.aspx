<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<div>
		<%= Html.Encode(ViewData["Message"]) %>
	</div>
	<form action="servicestack/xml/syncreply/Hello" method="post">
	    <label>Name:</label>
	    <input type="text" name="Name" value="World!" />
	    <input type="submit" />
	</form>	
	<hr />
	<form action="servicestack/html/syncreply/AddRequest" method="post">
	    <label>Name:</label>
	    <input type="text" name="Addend1" value="1" />
	    <input type="text" name="Addend2" value="2" />
	    <input type="submit" />
	</form>		
</body>

