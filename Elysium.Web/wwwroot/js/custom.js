$(document).ready(function() {
    // HelpDropDown Stay Open
    $('.dropdown-menu').on('click', function(event){
        // The event won't be propagated up to the document NODE and
        // therefore delegated events won't be fired
        event.stopPropagation();
    });
});

// Mobile Menu Code.
var IsChildMenu = false;
function ResetChildMenu() {
    $("#MenuForMobile").find(".SubMenuDropdown").attr("style", "display: none;");
    $("#MenuForMobile").find("a.nav-link-child").removeClass("d-none");
}

$("#MenuForMobile .nav-item-ForCommonHeader").on("click", "a.ChildMenu", function () {
    $(".backToHome").html('<i class="icon-arrow-back TextGradient me-1"></i> Back to ' + $(this).text());
    IsChildMenu = true;
    $(this).parent().parent().find('a.nav-link-child').addClass("d-none"); //.each(function (context) { $(context).addClass("d-none"); });
    $(this).parent().find(".SubMenuDropdown:eq(0)").toggle();
});
$("#MenuForMobile").on("click", ".DropDownItems", function () {
    $("#MenuForMobile .nav-link").addClass("d-none");
    $(".MenuCLass").addClass("d-none");
    $(".backToHome").removeClass("d-none");
    $(this).parent().find(".dropdown-menu:eq(0)").addClass("d-block");

});
$(".backToHome").click(function () {
    if (IsChildMenu) {
        ResetChildMenu();
        IsChildMenu = false;
        $(".backToHome").html('<i class="icon-arrow-back TextGradient me-1"></i> Back to Main Menu');
    } else {
        $("#MenuForMobile .nav-link").removeClass("d-none");
        $(".MenuCLass").removeClass("d-none");
        $(".backToHome").addClass("d-none");
        $("#MenuForMobile ul.dropdown-menu.SubMenuDropdown ").removeClass("d-block");
    }
});

$(".navbar-toggler").click(function () {
    ResetChildMenu();
    $("body").toggleClass("overflow-hidden");
});

$('.dropdown-menu a.dropdown-toggle').on('click', function (e) {
    if (!$(this).next().hasClass('show')) {
        $(this).parents('.dropdown-menu').first().find('.show').removeClass("show");
    }
    var $subMenu = $(this).next(".dropdown-menu");
    $subMenu.toggleClass('show');
    $(this).parents('.nav-item-ForCommonHeader').on('hidden.bs.dropdown', function (e) {
        $('.dropdown-submenu .show').removeClass("show");
    });
    return false;
});

// Enable Tooltips
var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl)
});
