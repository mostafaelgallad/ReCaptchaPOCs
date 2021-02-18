// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
async function onSubmit(token) {
    debugger

    $.post('https://localhost:44313/Home/VerifyRecaptcha?token=' + token, function () {
         alert("success");
     })
        .done(function (data) {

            if (data.success && data.score >= 0.5) {
                debugger
                console.log(data.success)
            }
         })
         .fail(function () {
             alert("error");
         })
         .always(function () {
             alert("finished");
         });
}




// Write your JavaScript code.
