$(document).ready(function () {

    var alert = $(".alert-primary");
   
    $(alert).click(function () { 
        var span = $("<span></span>");
        if ($(document).hasClass("ramka")==true) {
            span.remove();
           
        } else {
            $(".ramka_esas").append(span);
            span.addClass("ramka");
            span.css("border-color", "#cce5ff");
        }

    });



});