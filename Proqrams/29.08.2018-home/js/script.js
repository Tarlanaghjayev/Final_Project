var massive = document.querySelector("#massive");
var result = document.querySelector("#result");

massive.addEventListener("submit", function (event) {
    event.preventDefault();

    var data = {
        row: Number(document.querySelector("#row").value),
        column: Number(document.querySelector("#column").value),
    };

        var div = document.createElement("div");
        result.children[0].appendChild(div);
    for (var i = 0; i < row; i++) {

        var col= document.createElement("col-xl-12");
        result.children[0].children[0].appendChild(col);
        for( var j=0; j<column;j++){
        col.innerHTML = `<div class="card">
                            <div class="card-body">
                                <h5 class="card-title">Sutun sayi: ${i+1} </h5>
                                <h5 class="card-title">Setir sayi: ${j+1} </h5>
                            </div>
                        </div>`;
        result.appendChild(div);
    }
}




})

