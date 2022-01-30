var UserName = Document.getElementById("LogInId");
var Password = Document.getElementById("Password");

var jsFunctions = {};
jsFunctions.UserNameOrEmail = function (UserName, Password) {
    DotNet.invokeMethodAsync("LotusTransformation", "UserNameOrEmail", (UserName, Password))
        .then(result => {
            if ("string-result") {
                Document.getElementById("LogInLabel").innerHTML("asp-for ='Email'");
                Document.getElementById("LogInId").innerHTML("asp-for = 'Email'");
                Document.getElementById("LogInValidation").innerHTML("asp-for = 'Email'")
            } else {
                Document.getElementById("LogInLabel").innerHTML("asp-for ='UserName'");
                Document.getElementById("LogInId").innerHTML("asp-for = 'UserName'");
                Document.getElementById("LogInValidation").innerHTML("asp-for = 'UserName'")
            }
            el.innerHTML = result;
        });
}