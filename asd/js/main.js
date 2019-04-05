$(document).ready(function(){

        //sticky menu top
        var stiky = $('#navigation');
                
        $(window).on('scroll', function(){
            if($(window).scrollTop()>121){
                 stiky.addClass('sticky');}
            else {stiky.removeClass('sticky');}
        });


    //mobile menu
    $('#simple-menu').sidr();
 
    $(".mob-menu-li").click(function (e) {
        e.preventDefault();
       // $("ul ul").slideUp();
        $(this).find("ul").slideToggle();
      

         if($(this).find("span i").hasClass("fa-angle-down")){
             $(this).find("span i").removeClass("fa-angle-down");
             $(this).find("span i").addClass("fa-angle-up");
        }
        else{
            $(this).find("span i").removeClass("fa-angle-up");
            $(this).find("span i").addClass("fa-angle-down");
        }

    });
   
   
     
       

//carousel
    $("#team-car-slide").owlCarousel({
        nav:true,
        navText: ["<i class='fas fa-angle-left'></i>","<i class='fas fa-angle-right'></i>"],
        margin:15,
        loop:true,
        responsiveClass:true,
        responsive:{
            0:{
                items:1,
                nav:true
            },
            600:{
                items:2,
                nav:false
            },
            1000:{
                items:3,
                nav:true,
               
            }
        }
    });
    
    //event carousel
    $("#owl").owlCarousel({
        nav:true,
        navText: ["<i class='fas fa-angle-left'></i>","<i class='fas fa-angle-right'></i>"],
        margin:15,
        loop:true,
        responsiveClass:true,
        responsive:{
            0:{
                items:1,
                nav:true
            },
            600:{
                items:1,
                nav:true
            },
            1000:{
                items:2,
                nav:true,
               
            }
        }
    });
    

    AOS.init();


    //counter
    var a = 0;
    $(window).on('scroll',function() {
        var Top = $('#counter').offset().top - window.innerHeight;
        
        if (a == 0 && $(window).scrollTop() > Top) {
            $('.count-val').each(function() {
                var $this = $(this),
                    countTo = $this.attr('data-count');
                $({
                    countNum: $this.text()
                }).animate({
                        countNum: countTo
                    },
                    {
                        duration: 2000,
                        easing: 'swing',
                        step: function() {
                            $this.text(Math.floor(this.countNum));
                        },
                        complete: function() {
                            $this.text(this.countNum);
                            
                        }
    
                    });
            });
            a = 1;
        }
    });

//skill-bar
    $('.skillbar-1').each(function(){
        $(this).find('.skillbar-2').animate({
            width:$(this).attr('data-percent')
        },3000);
    });

//contact form
    var form =$("#contactform");
    var requireds = document.querySelectorAll("#contactform .required");
    form.on('submit',function(e){
        e.preventDefault();  
        for(var i =0; i<requireds.length;i++){
            if (requireds[i].value=="") {
                if(requireds[i].nextElementSibling==null){
                    requireds[i].parentNode.append(errorMessage(requireds[i].getAttribute("data-msg")));
                } 
            }
        }
    });
    function errorMessage(err_msg){
        var smal = document.createElement("small");
        smal.innerText=err_msg;
        smal.classList.add("form-text");
        smal.classList.add("text-danger");
        return smal;
    }



    //isotop 
    //isotop plugins tab menu

$(window).on('load', function() {
    var $container = $('.work-filter');
    var $filter = $('#menu-filter');
    
	$container.isotope({
		filter: '*',
		layoutMode: 'masonry',
		animationOptions: {
			duration: 750,
			easing: 'linear'
		}
	});
    $filter.find('a').on("click", function() {
		var selector = $(this).attr('data-filter');
		
        $filter.find('a').removeClass('active');
        $(this).addClass('active');
        $container.isotope({
            filter: selector,
			animationOptions: {
				duration: 750,
				easing: 'linear'
			}
		});
		
        return false;
	});
	
});

//photo gallery
$('.mag-pop').magnificPopup({
	type: 'image',
	gallery:{
		enabled:true
      }  
		
  });


  window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    if (document.body.scrollTop > 121 || document.documentElement.scrollTop > 121) {
        $('#to-top').css("display","block");
    } else {
        $("#to-top").css("display","none");
    }
}


    $("#to-top").on('click', function(){
        $( 'html, body' ).animate( { scrollTop: 0 }, 1000 );
        return false;
    });


    $(".search").on("click",function(e){
        e.preventDefault();
        $(".search-box").slideToggle();
    });


   
       $(window).on("scroll",function(){
        if ($(window).scrollTop() > 120 ) {
            $('.search-box').css("top","60px");
        } else {
            $(".search-box").css("top","180px");
        }
    });


});


  


   



    
