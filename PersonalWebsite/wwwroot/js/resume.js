$(document).ready(function() {
  $(window).scroll(function () {

    var headerHeight = document.getElementsByTagName('header')[0].clientHeight
    var mainHeight = document.getElementsByTagName('main')[0].clientHeight
    var sideProfileHeight = document.getElementsByClassName("side-profile-container")[0].clientHeight

    if ($(window).scrollTop() > headerHeight) {
      $('.side-profile').addClass('affix');
    }

    if (($(window).scrollTop() < headerHeight + 1) || ($(window).scrollTop() > (headerHeight+mainHeight-sideProfileHeight))) {
      $('.side-profile').removeClass('affix');
    }
  });
});
