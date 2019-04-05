var text = prompt("Enter text please!");
var count = Number(prompt("Enter count please!"));

function texco(text, count) {
    var total = "";
    for (var i = 0; i < count; i++) {

        total=total+text+" ";
    }
    return (total);
}

if (typeof count == 'number') {
    console.log(texco(text, count));
} else console.log("Enter again NUMBER please! ");
