// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function Spinner(enabled, message) {
    if (enabled) {
        $("#loader").attr("data-text", message);
        $("#loader").addClass("is-active");
    } else {
        $("#loader").removeClass("is-active");
    }
}

function JSonMessage(json) {
    var pre = document.createElement("pre");
    pre.innerHTML = JSON.stringify(json, null, 2);
    $("#messageDiv").append(pre);
}
