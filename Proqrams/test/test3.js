var n=Number(prompt("eded daxil edin: "));
var min=0;

    if(n%5==0){
        if(n>100){
            n=n%100;
            min=min+(n/100-(n%100)/100);
            n=n%50;
            min=min+(n/50-(n%50)/50);
            n=n%20;
            min=min+(n/20-(n%20)/20);
            n=n%10;
            min=min+(n/10-(n%10)/10);
            n=n%5;
            min=min+(n/5-(n%5)/5);
        }
    
    
            console.log("Lazim olan min say: " + min );
    
    }else{
        console.log("-1");
    }