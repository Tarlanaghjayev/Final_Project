var btn = document.querySelector(".btn-primary");
var pass = document.querySelector("#pass_control");
var pass2 = document.querySelector("#pass_control_2")
var inputs = document.querySelectorAll("input")

btn.addEventListener("click", function (event) {
    event.preventDefault();

    if (pass.value != pass2.value) {
        if (pass2.nextElementSibling == null) { //eyni neticeni bir nece defe cixarmasin deye
            var er = document.createElement("er");
            er.innerText = "Passwords are not same";
            er.classList.add("text-danger");
            pass2.parentNode.appendChild(er);
        }
    }

    if (pass.value.length < 6) {
        if (pass.nextElementSibling == null) {
            var er = document.createElement("er");
            er.innerText = "Your password should be at least 6 digits";
            er.classList.add("text-danger");
            pass.parentNode.appendChild(er);
        }
    }
    else if (pass.nextElementSibling != null) {
        pass.nextElementSibling.remove();
    }


    else if (pass.nextElementSibling != null) {
        pass.nextElementSibling.remove();
    }


    //Netice dogrudursa eger

    if (document.querySelector("er") == null) {
        this.parentNode.parentNode.nextElementSibling.children[0].children[0].classList.remove("d-none");
        this.parentNode.parentNode.remove();
    }

});

document.querySelector("#Reset").addEventListener("click",function(){
    register.reset();
});

