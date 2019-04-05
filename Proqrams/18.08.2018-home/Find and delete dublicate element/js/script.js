var arr = [17, 15, 14, 17, 21, 14];
var a = 0;


document.write("[ ");
for (var i = 0; i < arr.length; i++) {
    a = arr[i];
    for (var j = i + 1; j < arr.length; j++) {
        if (arr[j] == a) {
            arr.splice(j, 1);
        }
    }
}

for (i = 0; i < arr.length; i++) {
    document.write(arr[i] + " ");
}
document.write("]");
