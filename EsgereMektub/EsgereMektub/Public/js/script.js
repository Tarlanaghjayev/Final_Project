$(".owl-carousel").owlCarousel({
    nav: true,
    // navText: ["<i class='fas fa-angle-left'></i>", "<i class='fas fa-angle-right'></i>"],
    margin: 15,
    loop: true,
    responsiveClass: true,
    autoplay: false,
    autoplaySpeed: 50000,
    autoplayTimeout: 500,
    // autoplayHoverPause: false,
    responsive: {
        0: {
            items: 1,
            nav: true
        },
        600: {
            items: 2,

            nav: false
        },
        1000: {
            items: 7,

            nav: true
        }
    }

});

jQuery(document).ready(function($) {
    $('.counter').counterUp({
        delay: 10,
        time: 2000
    });
});



// $(".owl-carousel_url").owlCarousel({
//     nav: true,
//     navText: ["<i class='fas fa-angle-left'></i>", "<i class='fas fa-angle-right'></i>"],
//     margin: 15,
//     loop: true,
//     responsiveClass: true,
//     autoplay: false,
//     // autoplaySpeed: 100,
//     // autoplayTimeout: 500,
//     // autoplayHoverPause: false,
//     responsive: {
//         0: {
//             items: 1,
//             nav: true
//         },
//         600: {
//             items: 2,

//             nav: false
//         },
//         1000: {
//             items: 6,

//             nav: true
//         }
//     }
// });

  /* Demo purposes only */
  $(".hover").mouseleave(
    function () {
      $(this).removeClass("hover");
    }
  );