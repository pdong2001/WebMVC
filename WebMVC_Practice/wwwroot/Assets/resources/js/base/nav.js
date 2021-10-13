$(document).ready(function() {
    $('.dropdown-menu input').focus(function(e) {
        var parent = $(this).parent();
        while (!parent.hasClass('dropdown-content')) {
            parent = parent.parent();
        }
        parent.addClass('visible');
    });
    $('.dropdown-menu input').focusout(function(e) {
        var parent = $(this).parent();
        while (!parent.hasClass('dropdown-content')) {
            parent = parent.parent();
        }
        parent.removeClass('visible');
    });
    $('.root button').click(function() {
        const content = $(this).parent().parent().find('ul');
        if (content.hasClass('visible')) {
            content.removeClass('visible');
        } else {
            content.addClass('visible');
        }
    });
    $('header .search-bar #search-title-input').css('width', $('header .search-bar .time div').width() + 'px');
    const menuBar = $('.menubar');
    var menuBarOffsetTop = menuBar.offset().top;
    $(window).scroll(function() {
        var h = 0;
        var fixedItems = $('.fixed')
        fixedItems.each(function(index) {
            if (index < fixedItems.length - 1) {
                h += $(this).height();
            }
        });
        h = menuBarOffsetTop - h;
        var scrollTop = $(window).scrollTop();
        if (scrollTop >= h) {
            menuBar.find('.temp').addClass('fixed');
        } else {
            menuBar.find('.temp').removeClass('fixed');
        }
    });
});