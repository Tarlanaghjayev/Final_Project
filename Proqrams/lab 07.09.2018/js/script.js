

$(document).ready(function(){

    $("button").hover(function(){
        if($(this).attr("data-toggle")=="tooltip"){
        if($(this).attr("data-placement")=="top"){
            var span=$("<span></span>");
            $(this).append(span);
            var title=$(this).attr("title");
            span.text(`${title}`);
            span.addClass("on_top");
        }
        if($(this).attr("data-placement")=="bottom"){
            var span=$("<span></span>");
            $(this).append(span);
            var title=$(this).attr("title");
            span.text(`${title}`);
            span.addClass("on_bottom");
        }
        if($(this).attr("data-placement")=="left"){
            var span=$("<span></span>");
            $(this).append(span);
            var title=$(this).attr("title");
            span.text(`${title}`);
            span.addClass("on_left");
        }
        if($(this).attr("data-placement")=="right"){
            var span=$("<span></span>");
            $(this).append(span);
            var title=$(this).attr("title");
            span.text(`${title}`);
            span.addClass("on_right");
        }}
    }, function(){
        $(this).children().eq(0).remove();

    });







});