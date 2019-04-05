//Cash machine program

var n=Number(prompt("Meblegi daxil edin: "));
var m=0,i=0, a=[5,10,20,50,100];

if(n%5==0){
    for(i=4;i>=0;i--){
        m+=(n-n%a[i])/a[i];
        n-=n-n%a[i];
    } console.log("Min say: " + m)

}else console.log(-1); 