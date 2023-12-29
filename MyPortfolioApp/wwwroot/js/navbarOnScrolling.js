window.navbarOnScrolling = function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 50) {
            $('.navbar').fadeIn('slow').css('display', 'flex');
        } else {
            $('.navbar').fadeOut('slow').css('display', 'none');
        }
    });
};