$('.nav-element').removeClass('active');
var path = window.location.href;
$('.nav-element').each(function () {
    if (this.href == path) {
        $(this).addClass('active');
    }
});