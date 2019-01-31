$(".owl-carousel").owlCarousel({
    nav: true,
    navText: ["<i class='fas fa-angle-left'></i>", "<i class='fas fa-angle-right'></i>"],
    margin: 15,
    loop: true,
    responsiveClass: true,
    autoplay: true,
    autoplaySpeed: 100,
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
            items: 3,

            nav: true
        }
    }
});
