var n=Number(prompt("eded daxil edin: "));
var min=0,i=1,netice=Number;
function a1(){
    if(n==10){
        min==i;
    }if(n==20){
        min==i;
    }if(n==30){
        min=i+1;
    }if(n==40){
        min=i+1;
    }if(n==50){
        min=i;
    }if(n==60){
        min=i+1;
    }if(n==70){
        min=i+1;
    }if(n==80){
        min=i+2;
    }if(n==90){
        min=i+2;
    }return min;}
    if(n>=10 && n<100){
        if(n%10==0){
            netice=a1(n);
        }else {n=n-5;
            netice=a1(n)+1;}
    }
    if(n>=100){
        if(n%100==0){
            netice=n/100;
        }
        if(n%10==0){
            n=n-n%100;
            netice=a1(n)+1;
        }else{  
            netice=a1(n)+2;}

        
    }
console.log("Sizin neticeniz: " + netice);
