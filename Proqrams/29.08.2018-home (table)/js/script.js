var btn = document.querySelector(".btn");


btn.addEventListener("click", function (event) {
    event.preventDefault();

    var row = document.querySelector("#row").value;
    var column = document.querySelector("#column").value;
    var table = document.querySelector(".table");

    for (var i = 0; i < row; i++) {
        var tr = document.createElement("tr");
        table.children[0].appendChild(tr);
        // console.log(this.parentNode);
        for (var j = 0; j < column; j++) {
            var td = document.createElement("td");
            td.innerHTML = `Row: ${i + 1} <br> Column: ${j + 1}`;
            table.children[0].children[i].appendChild(td);

        }
    }


})