var arr = [17, 15, 14, 17, 21, 14];
var a = 0;

document.write("[ ");
    for (var i = 0; i < arr.length; i++) {
        a = arr[i];
        for (var j = i + 1; j < arr.length; j++) {
            if (arr[j] == a) {
                document.write(a + " ");
                for (var k = j + 1; k < arr.length; k++) {
                    if (arr[k] == a) {
                        arr.splice(k, 1);
                    }
                }
            }
        }
    }
}

document.write("]");