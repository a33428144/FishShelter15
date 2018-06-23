$(function () {
    var isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent);
    var area1 = $("#room-area1");
    var area2 = $("#room-area2");

    if (isMobile || $(window).width() < 480) {
        area2.after(area1);
    }

    $(window).resize(function () {

        if ($(window).width() < 480) {
            area2.after(area1);
        } else {
            area1.after(area2);
        }
    });

});