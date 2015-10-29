$(function () {
    var $sidebar = $("#contactUs"),
        $window = $(window),
        offset = $sidebar.offset(),
        topPadding = 200;

    $window.scroll(function () {
        if ($window.scrollTop() > offset.top - topPadding) {
            $sidebar.stop().animate({
                marginTop: $window.scrollTop() - offset.top + topPadding,
                duration: 500
            })
        } else {
            $sidebar.stop().animate({
                marginTop: 0
            });
        }
    });
});