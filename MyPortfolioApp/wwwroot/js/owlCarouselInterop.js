window.initializeOwlCarousel = function (numberOfProjects) {
    $(".owl-carousel").owlCarousel({
        items: numberOfProjects >= 3 ? 3 : numberOfProjects,
        autoplay: numberOfProjects >= 3 ? true : false,
        margin: 10,
        loop: true,
        autoplayHoverPause: true,
        dots: true,
        //nav: true,
    });
};