<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebAPI.index" %>


<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8" />
    <title>test</title>
    <meta name="author" content="xiewg@cebserv.com" />
    <meta name="copyright" content="www.doyoe.com" />

    <script src="https://cdn.staticfile.org/vue/2.4.2/vue.min.js"></script>
    <script src="https://cdn.staticfile.org/vue-resource/1.5.1/vue-resource.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
    <style>
        p ~ p {
            color: #f00;
        }
    </style>
    <script>
        function add() {
            $.ajax({
                url: "/api/Test/",
                type: "POST",
                data: { "Id": 4, "name": "zhangsan" },

                success: function (data) { alert(JSON.stringify(data)); }
            });
        }
    </script>
</head>
<body>
     <a href="javascript:add()">添加(post)</a>
  
</body>

</html>
