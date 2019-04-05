var n=Number(prompt("eded daxil edin: "));
var i=Number,min=0,a=[5,10,20,50,100];

    if(n%5==0){
    
        if(n>=100){
            i=5;
             while(i>=1){
            n%=a[i];
            n=n%100;
            min=min+(n/a[i]-(n%a[i])/a[i]);
                
                i--;
             } 
        }
         if(n>=50 && n<100){
           i=4;
            while(i>=1){
                n%=a[i];
                min=min+(n/a[i]-(n%a[i])/a[i]);
                
                i--;
            }
        }
         if(n>=20 && n<50){
            i=3;
            while(i>=1){
                n%=a[i]; 
                min=min+(n/a[i]-(n%a[i])/a[i]);
                
                i--;
            }
        }
        if(n>=10 && n<20){
            i=2;
            while(i>=1){
            n%=a[i];         
            min=min+(n/a[i]-(n%a[i])/a[i]);
            
            i--;
            }
        }
        if(n>=5 && n<10){
            i=1;
            n%=a[i]; 
            min=min+(n/a[i]-(n%a[i])/a[i]);
            
        }
    
    
            console.log("Lazim olan min say: " + min );
    
    }else{
        console.log("-1");
    }