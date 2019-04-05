var button=document.querySelector(".btn");
button.addEventListener("click",function(){

    var bar=document.querySelector(".bar");
    if (!bar.classList.contains("hdn")) {
    bar.classList.add("hdn");
    }
    else {
        bar.classList.remove("hdn");
    }
})