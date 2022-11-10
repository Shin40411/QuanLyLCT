<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Home.ascx.cs" Inherits="LIINK.Modules.LTD.LTD.Home" %>
<%@ Register TagPrefix="dnn" TagName="LANGUAGE" Src="~/Admin/Skins/Language.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LOGO" Src="~/Admin/Skins/Logo.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SEARCH" Src="~/Admin/Skins/Search.ascx" %>
<%@ Register TagPrefix="dnn" TagName="USER" Src="~/Admin/Skins/User.ascx" %>
<%@ Register TagPrefix="dnn" TagName="LOGIN" Src="~/Admin/Skins/Login.ascx" %>
<%@ Register TagPrefix="dnn" TagName="PRIVACY" Src="~/Admin/Skins/Privacy.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TERMS" Src="~/Admin/Skins/Terms.ascx" %>
<%@ Register TagPrefix="dnn" TagName="COPYRIGHT" Src="~/Admin/Skins/Copyright.ascx" %>
<%@ Register TagPrefix="dnn" TagName="JQUERY" Src="~/Admin/Skins/jQuery.ascx" %>
<%@ Register TagPrefix="dnn" TagName="META" Src="~/Admin/Skins/Meta.ascx" %>
<%@ Register TagPrefix="dnn" TagName="MENU" Src="~/DesktopModules/DDRMenu/Menu.ascx" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>
<%@ Register TagPrefix="dnn" TagName="CURRENtdATE" Src="~/Admin/Skins/Currentdate.ascx" %>
<dnn:META ID="mobileScale" runat="server" Name="viewport" Content="width=device-width,initial-scale=1.0" />
<!--
<link id="themeeditor_css" rel="stylesheet" href="/DesktopModules/DnnThemeEditor/theme.ashx?t=<%= PortalSettings.Current.ActiveTab.TabID.ToString() %>" />
-->


<!--[if lt IE 9]>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.2/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
<![endif]-->


<style>
    #mask {
        position: absolute;
        left: 0;
        top: 0;
        z-index: 9000;
        background-color: #000;
        display: none;
    }
</style>
<div id="siteHeadouter">
    <div class="header_top">
        <div class="container_lg">
<div class="header_element social-top ">
                                <span id="currentDateTime"></span>
            </div>
            <div class="header_element Logins font">
                  <div class="icon glyphicon glyphicon-user visible-xs">
                </div>
                <div class="element_box Login">
                    <dnn:USER ID="USER1" runat="server" LegacyMode="false" ShowAvatar="false" ShowUnreadMessages="false" />
                    <dnn:LOGIN ID="LOGIN1" CssClass="LoginLink" runat="server" LegacyMode="false" />
                </div>
            </div>

        </div>
    </div>
    <div class="giangggg">
        <div class="row">
            <div class="dnn_banner bannerg">
                <a href='#'>
                    <img id="dnn_banner" src="<%=PortalSettings.HomeDirectory %>banner.png" class="visible-md visible-lg" title="LỊCH CÔNG TÁC TỈNH VĨNH LONG" alt="LỊCH CÔNG TÁC TỈNH VĨNH LONG" />
                    <img id="dnn_banner_sm" src="<%=PortalSettings.HomeDirectory %>Banner_1300.png" class="visible-sm" title="LỊCH CÔNG TÁC TỈNH VĨNH LONG" alt="LỊCH CÔNG TÁC TỈNH VĨNH LONG" />
                    <img id="dnn_banner_xs" src="<%=PortalSettings.HomeDirectory %>Banner_768.png" class="visible-xs" title="LỊCH CÔNG TÁC TỈNH VĨNH LONG" alt="LỊCH CÔNG TÁC TỈNH VĨNH LONG" />
                </a>
            </div>
        </div>
        <div class="container_lg">
        </div>
    </div>
</div>
<% if (Request.IsAuthenticated){ %>
<div id="dnn_headbox" class="headboxg">
    <div class="js-clingify-placeholder">
        <div class="js-clingify-wrapper">
            <div class="top_nav_portal">
            </div>
            <div id="roll_nav" class="container_lg flexg">
                <div class="clearfix midg">
                    <div id="top_menu" class="top_menu hidden-xs">
                        <dnn:MENU ID="MENU3" MenuStyle="BootstrapMenu" runat="server"></dnn:MENU>
                    </div>
                    <div class="mobile_icons visible-xs">
                        <%--                        <button type="button" class="navbar-toggle collapsed searchit hi">
                            <img style="padding: 5px; width: 75%;" src="<%=SkinPath%>/Images/se_icon.png" />
                        </button>--%>
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-9" aria-expanded="false">
                            <img src="<%=SkinPath%>/Images/menu_icon.png" />
                        </button>
                        <nav class="navbar navbar-inverse">
                        </nav>
                    </div>

                </div>
                <div class="menu_phone visible-xs">
                    <div class="navbar-collapse collapse" id="bs-example-navbar-collapse-9" aria-expanded="false" style="">
                        <dnn:MENU ID="MENU4" MenuStyle="BootstrapMenu" runat="server"></dnn:MENU>
                    </div>
                </div>
            </div>
            <div class="header_shadow hidden-xs "></div>
        </div>
    </div>
</div>
<%} %>
<div id="siteWrapper" class="box-container ">
    <!--/Logo-->
    <div class="container_full" id="ContentPaneFull" runat="server">
    </div>
    <div class="container containo">
        <div id="Content" class="row">
            <div id="ContentPane" runat="server" class="col-md-12 col-md-offset-2 pd-0" />
        </div>
        <div id="TopContent" class="row">
            <div id="TopPane" runat="server" class="col-md-12 pd-0" />
        </div>


        <div id="MidContent" class="row">
            <div id="ThirdRowLeft" runat="server" class="col-md-4 pd-right" />
            <div id="ThirdRowMiddle" runat="server" class="col-md-4 pd-right pd-xx-0" />
            <div id="ThirdRowRight" runat="server" class="col-md-4 pd-0" />
        </div>
        <div id="ContentLeftCol" class="row">
            <div id="LeftPane" runat="server" class="col-md-3 pd-left-0 pd-xx-right" />
            <div id="ContentPaneRight" runat="server" class="col-md-9 pd-0" />
        </div>

        <%--<div id="UserProfile" class="row">
        <div id="UserProfileLeft" runat="server" class="col-md-2" />
        <div id="UserProfileContent" runat="server" class="col-md-10" />
    </div>--%>

        <div id="NearBootContent" class="row">
            <div id="ThirdRowLeft_2" runat="server" class="col-md-4 pd-right " />
            <div id="ThirdRowMiddle_2" runat="server" class="col-md-4 pd-right pd-xx-0" />
            <div id="ThirdRowRight_2" runat="server" class="col-md-4 pd-0">
                <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
                <script>
                    (adsbygoogle = window.adsbygoogle || []).push({
                        google_ad_client: "ca-pub-7980742121111685",
                        enable_page_level_ads: true
                    });
                </script>
            </div>
        </div>
        <div id="BottomContent" class="row">
            <div id="BottomPane" runat="server" class="col-md-12 pd-0" />
        </div>
    </div>
</div>

<footer class="ContentFooter">
    <div class="row">
        <div class="col-lg-12 pd-0">
            <div class="row">
                <div id="TopFooter" runat="server" class="col-md-12 pd-0 footer_link" />
            </div>
            <div class="row">
                <div id="Fotter_Center" class="col-lg-12  text-center pd-8">

                    <div class="row">
                        <div id="Div1" class="container  text-center boxfooter">
                            <%--                            <div id="Col_Left" runat="server" class="text-center col-lg-3 col-md-3 col-sm-12 col-xs-12 pd-0">
                            </div>--%>
                            <div id="Col_Center" runat="server" class="footer_box_right text-center col-lg-6 col-md-6 col-sm-12 col-xs-12 col-lg-offset-3 col-md-offset-3 pd-0">
                            </div>
                            <div id="Col_Right" runat="server" class="text-center col-lg-3 col-md-3 col-sm-12 col-xs-12 pd-0">
                                <div class="tt_footer">
                                    <div id="goTop">
                                        <span class="glyphicon glyphicon-chevron-up" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</footer>

<script>




    setInterval(function () {
        var currentdate = new Date();


        let options = { weekday: 'long', year: 'numeric', month: 'numeric', day: 'numeric', hour: 'numeric', minute: 'numeric', second: 'numeric' };

        $('#currentDateTime').html(currentdate.toLocaleString('vi-VN', options));


    }, 1000);

</script>

<%-- CSS & JS includes --%>
<!--#include file="LTD_V1/Common/AddFiles.ascx"-->
<%--<script>
    jQuery(document).ready(function ($) {
        jQuery('.header_element').click(function () {
            var e = $(this);
            if (!e.hasClass("Open")) {
                e.addClass("Open").siblings(".header_element").removeClass("Open");
            }
            else {
                e.removeClass("Open");
            }
            var interval;
            e.mouseover(function () {
                clearTimeout(interval);
            })
            e.mouseout(function () {
                interval = setInterval(function () { e.removeClass("Open"); clearTimeout(interval); }, 500);
            })
        })
    })
    </script>--%>
<script>
    (function ($) {
        // console.log(navigator.userAgent);
        /* Adjustments for Safari on Mac */
        if (navigator.userAgent.indexOf('Safari') != -1 && navigator.userAgent.indexOf('Mac') != -1 && navigator.userAgent.indexOf('Chrome') == -1) {
            // console.log('Safari on Mac detected, applying class...');
            $('html').addClass('safari-mac'); // provide a class for the safari-mac specific css to filter with
        }
    })(jQuery);
    $(function () {
        $(window).scroll(function () {
            if ($(this).scrollTop() > 100) $('#goTop').fadeIn();
            else $('#goTop').fadeOut();
        });
        $('#goTop').click(function () {
            $('body,html').animate({ scrollTop: 0 }, 'slow');
        });
    });

    //$('#jPopup > div > div').click(function () {
    //    window.open($(this).parent().children('iframe').attr("src"));
    //});


</script>
<script>
    if ($(window).width() <= 991) {
        $(".dropdown-toggle").removeAttr('data-toggle');
        $(".dropdown-toggle").attr('data-toggle', 'dropdown');
    }
    else {
        $(".dropdown-toggle").removeAttr('data-toggle');
        $(".dropdown-toggle").attr('data-toggle', 'dropdown disable');
    }
    $(window).resize(function () {

        if ($(window).width() <= 991) {
            $(".dropdown-toggle").removeAttr('data-toggle');
            $(".dropdown-toggle").attr('data-toggle', 'dropdown');
        }
        else {
            $(".dropdown-toggle").removeAttr('data-toggle');
            $(".dropdown-toggle").attr('data-toggle', 'dropdown disable');
        }
    });

    if ($(window).width() >= 991) {
        jQuery('div.top_menu ul.nav li.dropdown').hover(function () {
            jQuery(this).find('.dropdown-menu.level1').stop(true, true).delay(200).fadeIn();
        }, function () {
            jQuery(this).find('.dropdown-menu.level1').stop(true, true).delay(200).fadeOut();
        });
    }


    //jQuery(document).ready(function ($) {
    //    $('#jPopup div iframe')[0].contentWindow.postMessage('{"event":"command","func":"playVideo","args":""}', '*');
    //});

</script>
<script type="text/javascript">
    jQuery(document).ready(function () {
        jQuery("#featured1").tabs({
            event: 'click',
            fx: {
                opacity: 'toggle',
                duration: 'slow'
            }
        }).tabs('rotate', 999999999, true);

        //(a[href = "javascript:void(0);"]).addClass(hide);

        //Kiem tra an noi dung right khi xem trang khong phai la trang chu
        if ($(window).width() <= 991) {
            var tabID = 55;
            if (tabID != 55) {
                $("#left_contain").hide();
            } else {
                $("#left_contain").show();
            }
        }
    });



</script>


<!--fix menu level 3 tren mobile-->
<script>

    jQuery(document).ready(function ($) {
        if (navigator.userAgent.indexOf('Safari') != -1 && navigator.userAgent.indexOf('Mac') != -1 && navigator.userAgent.indexOf('Chrome') == -1) {
            // console.log('Safari on Mac detected, applying class...');
            $('html').addClass('safari-mac'); // provide a class for the safari-mac specific css to filter with
        }
    })

    $(document).ready(function () {
        resizeScreen();
        $(window).resize(function () {
            resizeScreen();
        });
        function resizeScreen() {
            if ($(this).width() < 769) {
                $('ul.dropdown-menu [data-toggle=dropdown]').on('click', function (event) {
                    event.preventDefault();
                    event.stopPropagation();
                    //$('ul.dropdown-menu [data-toggle=dropdown]').parent().removeClass('open');
                    $(this).parent().addClass('open');
                });
            }
        }
    });

</script>
