var n=Number(prompt("Enter number of cells"));
var m=Number(prompt("Enter number of rabbits"));
var max=1,i=0,j=0,a=[n];
if(m>n){
    for(i=m;i>n;i-=n){
        for(j=n;j>0;j--){
            a[j]=max;
        }
        max++;
    }
console.log(max);
}else console.log(0);
