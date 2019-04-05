
var n= Number(prompt("Eded daxil edin: "));
var i=1,c,min1=0,a=[5,10,20,50,100];

function min(number){
    min1+=(n/a[i]);
    n%=a[i];
    return min1;
}

if(n%5==0){

    if(n>=100){
         for(i=5;i>=1;i--){
             min(i);
         } 
    }
    if(n>=50 && n<100){
        for(i=4;i>=1;i--){
           min(i); 
        }
    }
    if(n>=20 && n<50){
        for(i=3;i>=1;i--){
           min(i); 
        }
    }
    if(n>=10 && n<20){
        //for(i=2;i>=1;i--){
           c=min(2);
           d=min(1);
           tot=c+d;
        //}
    }
    if(n>=5 && n<10){
           tot=min(1); 
    }


        console.log("Lazim olan min say: " + min(i) );

}else{
    console.log("-1");
}

