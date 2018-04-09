function createPhotoModal(photo) {
    var imageSource = photo.getElementsByTagName('img')[0].src;
    $('#photo-modal').find('img').attr('src', imageSource);
    $('#photo-modal').modal('show');
}
