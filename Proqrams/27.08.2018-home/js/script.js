var list = document.querySelectorAll(".container ul .section ");
for (var i = 0; i < list.length; i++) {
    list[i].addEventListener("click", function () {

        //document.querySelector(".active").classList.remove("active");
        //document.querySelector(".fa-minus").classList.replace("fa-minus", "fa-plus");
        var text = this.nextElementSibling;
        text.classList.toggle("active");
        
        var plus = this.children[0];
        if (plus.classList.contains("fa-plus")) {
            plus.classList.replace("fa-plus", "fa-minus");
        }
        else {
            plus.classList.replace("fa-minus", "fa-plus");
        }


    });
}
