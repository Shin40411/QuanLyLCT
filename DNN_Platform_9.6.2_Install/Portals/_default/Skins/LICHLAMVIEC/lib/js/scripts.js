//function buttonUp() {
//    var e = $(".search .searchInputContainer input").val();
//    e = $.trim(e).length, 0 !== e ?
//        (
//            $(".search").css("overflow", "visible")
//        )
//        :
//        (
//            $(".search .searchInputContainer input").val(""),
//            $(".search-toggle-icon").css("display", "block"),
//            $(".search").css("overflow", "hidden")
//        ),
//        $(".search .searchInputContainer a.dnnSearchBoxClearText").click(function () {
//            $(".search .searchInputContainer a.dnnSearchBoxClearText").hasClass("dnnShow")
//                ?
//                $(this).css("overflow", "visible")
//                :
//                $(".search").css("overflow", "hidden")
//        });
//}
//$(document).ready(function () {
//    $(".navbar-nav.sm-collapsible .caret").click(function (e) {
//        e.preventDefault()
//    }), 
//    $('[data-toggle="tooltip"]').length && 
//    $('[data-toggle="tooltip"]').tooltip(), 
//    $('<span class="search-toggle-icon"></span>').insertAfter(".search a.SearchButton");
//    var searchBox = $(".search"),
//        searchToggleIcon = $(".search-toggle-icon"),
//        clearSearchBox = $(".search .searchInputContainer a.dnnSearchBoxClearText"),
//        searchInput = $(".search .searchInputContainer input"),
//        searchActive = false;
//    searchToggleIcon.click(function (event) {
//        event.stopPropagation();
//        !searchActive
//            ?
//            (
//                searchBox.addClass("search-open"),
//                searchInput.focus(),
//                searchActive = true
//            )
//            :
//            (
//                searchBox.removeClass("search-open"),
//                searchInput.focusout(),
//                searchInput.val(""),
//                clearSearchBox.removeClass("dnnShow"),
//                $(".search").css({ "overflow": "hidden" }),
//                searchActive = false
//            )
//    }),
//        searchBox.mouseup(function () {
//            return false
//        }),
//        searchToggleIcon.mouseup(function () {
//            return false
//        }), $(document).click(function (event) {
//            if (!($(event.target).parents(".search").length)) {
//                searchActive == true && (searchToggleIcon.click())
//            }
//        }), searchInput.keyup(buttonUp), $("a#search-action").click(function () {
//            $("#search-top").toggleClass("active")
//        })
        
//});
//For Menu Lavalamp:

jQuery(document).ready(function ($) {
    jQuery('.header_element .icon').click(function () {
        var e = $(this).parent();
        if (!e.hasClass("Open")) {
            e.addClass("Open").siblings(".header_element").removeClass("Open");
        }
        else {
            e.removeClass("Open");
        }
        var interval;
        //e.mouseover(function () {
        //    clearTimeout(interval);
        //})
        //e.mouseout(function () {
        //    interval = setInterval(function () { e.removeClass("Open"); clearTimeout(interval); }, 500);
        //})
    })
    $(document).ready(function (e) {
        $('.bxslider').bxSlider({
            mode: 'fade',//'fade',//'horizontal',//'vertical',
            pager: false,
            controls: false,
            auto: true,
            pause: 5000,
            maxSlides: 1,
            minSlides: 1,
            moveSlides: 1,
            autoHover: true
        });

        function maxHeight() {
            var r = new Array();
            $(".newslist").each(function () {
                var h = $(this).height();
                r.unshift(h);
            });
            Array.prototype.max = function () {
                return Math.max.apply(Math, this);
            };
            var mh = r.max();
            $(".newslist").css("height", mh);
        }
        maxHeight();
        function maxHeight1() {
            var r = new Array();
            $(".centerbottom>div").each(function () {
                var h = $(this).height();
                r.unshift(h);
            });
            Array.prototype.max = function () {
                return Math.max.apply(Math, this);
            };
            var mh = r.max();
            $(".centerbottom>div").css("height", mh);
        }
        maxHeight1();
        function maxHeight2() {
            var r = new Array();
            $(".news-list").each(function () {
                var h = $(this).height();
                r.unshift(h);
            });
            Array.prototype.max = function () {
                return Math.max.apply(Math, this);
            };
            var mh = r.max();
            $(".news-list").css("height", mh);
        }
        maxHeight2();
    });
    $(window).load(function () {
        $("#content_1").mCustomScrollbar({
        });
    });
})
    //(function ($) {
     
    //})(jQuery);
   
