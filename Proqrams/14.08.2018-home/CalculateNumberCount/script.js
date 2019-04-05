var a = Number(prompt("Enter number please! "));
var count = 1;

if (a >= 0) {
    while (a > 9) {
        a = a / 10 - (a / 10 % 10);
        count++;
    }
}
else {
    while (a < -9) {
        a = a / 10 - (a / 10 % 10);
        count++;
    }
}

if (typeof a == 'number') {
    console.log("Your number consists " + count + " digits!");
} else console.log("Enter again NUMBER please! "); 