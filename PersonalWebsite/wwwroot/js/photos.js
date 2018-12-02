function highlightImage(image) {
  $('.carousel-item').removeClass('active');

  var carouselImages = document.getElementsByClassName('carousel-image');
  for (var i = 0; i < carouselImages.length; i++) {
    if (carouselImages[i].src === image.src) {
      carouselImages[i].parentElement.classList.add('active');
    }
  }

  document.getElementsByClassName('carousel')[0].scrollIntoView(false);
}
