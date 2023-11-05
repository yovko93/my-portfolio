window.smoothScroll = {
    initialize: function () {
        document.querySelectorAll('a').forEach(anchor => {
            anchor.addEventListener('click', function (e) {
                if (this.hash !== "") {
                    e.preventDefault();

                    var hash = this.hash;

                    var target = document.querySelector(hash);
                    var targetPosition = target.offsetTop;
                    var startPosition = window.pageYOffset;
                    var distance = targetPosition - startPosition;
                    var startTime = null;
                    var duration = 800;

                    function animation(currentTime) {
                        if (startTime === null) startTime = currentTime;
                        var timeElapsed = currentTime - startTime;
                        var run = ease(timeElapsed, startPosition, distance, duration);
                        window.scrollTo(0, run);
                        if (timeElapsed < duration) requestAnimationFrame(animation);
                    }

                    // Easing function
                    function ease(t, b, c, d) {
                        t /= d / 2;
                        if (t < 1) return c / 2 * t * t + b;
                        t--;
                        return -c / 2 * (t * (t - 2) - 1) + b;
                    }

                    requestAnimationFrame(animation);
                }
            });
        });
    }
};

