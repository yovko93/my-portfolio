window.initializeTyped = function (elementId) {
    var typed = new Typed('#' + elementId, {
        strings: ['Web Developer', 'FrontEnd Developer', 'DevOps Software Engineer'],
        typeSpeed: 100,
        loop: true
    });
};