window.initializeTyped = function (elementId) {
    var typed = new Typed('#' + elementId, {
        strings: ['Backend Developer', 'Frontend Developer', 'FullStack Developer'],
        typeSpeed: 100,
    });
};