window.initializeTyped = function (elementId) {
    var typed = new Typed('#' + elementId, {
        strings: ['.Net Developer', 'Frontend Developer', 'DevOps Software Engineer'],
        typeSpeed: 100,
        loop: true
    });
};