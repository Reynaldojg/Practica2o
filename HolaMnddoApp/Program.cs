var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(@"
<!DOCTYPE html>
<html lang='es'>
<head>
<meta charset='UTF-8'>
<title>Hola Mundo C# + Docker</title>
<style>
    body {
        background: #121212;
        color: #fff;
        font-family: Arial, sans-serif;
        text-align: center;
        padding-top: 100px;
    }
    h1 {
        color: #4FC3F7;
        font-size: 48px;
    }
    p {
        font-size: 20px;
        color: #B0BEC5;
    }
</style>
</head>
<body>
    <h1>🚀 Hola Mundo desde C# y Docker</h1>
    <p>Tu primera app en contenedor está funcionando correctamente.</p>
</body>
</html>
", "text/html"));

app.Run();
