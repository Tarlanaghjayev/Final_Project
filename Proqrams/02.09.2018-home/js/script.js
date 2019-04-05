var right = document.querySelector(".fa-angle-double-right");
var left = document.querySelector(".fa-angle-double-left");
var sliders = document.querySelector(".sliders");
var image = document.querySelectorAll(".img");
var i = 0;


// With Icons 


right.addEventListener("click", function () {
    document.querySelector(".active").classList.remove("active");

    if (i + 1 == 4) {
        i = -1;
    }

    this.parentNode.previousElementSibling.children[i + 1].classList.add("active");
    i++;
});

left.addEventListener("click", function () {
    document.querySelector(".active").classList.remove("active");

    if (i == 0) {
        i = 3;
    }

    this.parentNode.previousElementSibling.children[i].classList.add("active");
    i--;
});


//With Keydown


document.addEventListener("keydown", function (event) {
    document.querySelector(".active").classList.remove("active");
    if (event.which == 37) {
        if (i == 0) {
            i = 3;
        }
        sliders.children[i].classList.add("active");
        i--;
    }
    if (event.which == 38) {
        if (i == 3) {
            i = 0;
        }
        sliders.children[i + 1].classList.add("active");
        i++;
    }
    if (event.which == 39) {
        if (i == 3) {
            i = 0;
        }
        sliders.children[i + 1].classList.add("active");
        i++;
    }
    if (event.which == 40) {
        if (i == 0) {
            i = 3;
        }
        sliders.children[i].classList.add("active");
        i--;
    }
})

//With Scroll


