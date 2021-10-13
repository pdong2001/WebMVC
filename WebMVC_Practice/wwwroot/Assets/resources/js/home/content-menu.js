$(document).ready(function() {
    const contentMenuItemTemplate = $('.content-menu-item').clone();
    const contentMenu = $('.content-menu.slider');
    $('.row-ID').each(function(index) {
        var temp = contentMenuItemTemplate.clone();
        temp.find('a').attr('href', '#' + $(this).attr('id'))
        temp.removeClass('content-menu-item-template');
        temp.find('a').append($(this).find('.title:first-of-type h2').children().clone()[0]);
        var p = document.createElement('p');
        $(p).html($(this).find('.title:first-of-type h2').text());
        $(p).appendTo(temp.find('a'));
        temp.appendTo(contentMenu);
    });
    $('.content-menu-item').click(function() {
        $('.content-menu-item.active').removeClass("active");
        $(this).addClass('active');
    });
    $(".content-menu.slider").slick({
        dots: false,
        infinite: true,
        slidesToShow: 5,
        slidesToScroll: 2,
        arrows: false,
        autoplay: false,
        responsive: [{
            breakpoint: 1024,
            settings: {
                slidesToShow: 4,
                slidesToScroll: 1,
            },
            breakpoint: 800,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1,
            },
            breakpoint: 400,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 1,
            }
        }]
    });
});