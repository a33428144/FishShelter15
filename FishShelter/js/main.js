$(window).load(function () {
    $('.ma5slider').ma5slider();

    $("#tabs").tabs();
});

function trigger(category, action, label) {
    gtag('event', action, {
        'event_category': category,
        'event_label': label
    });
}