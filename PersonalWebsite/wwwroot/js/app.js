window.onload = function () {
    var path = window.location.pathname;
    var links = document.getElementsByClassName('dropdown-item');
    var dropdowns = document.getElementsByClassName('dropdown-toggle');

    switch (path) {
        case '/resume':
            setActiveByHREF(links, path);
            setActiveByInnerHTML(dropdowns, 'BUSINESS');
            break;
        case '/calendar':
            setActiveByHREF(links, path);
            setActiveByInnerHTML(dropdowns, 'LEISURE');
            break;
        case '/books':
            setActiveByHREF(links, path);
            setActiveByInnerHTML(dropdowns, 'LEISURE');
            break;
        case '/photos':
            setActiveByHREF(links, path);
            setActiveByInnerHTML(dropdowns, 'LEISURE');
            break;
        default:
            break;
    }
    document.getElementsByClassName('');
};

function setActiveByHREF(elements, path) {
    for (var i = 0; i < elements.length; i++) {
        if (elements[i].pathname === path) {
            elements[i].classList.add('active');
        }
    }
}

function setActiveByInnerHTML(elements, innerHTML) {
    for (var i = 0; i < elements.length; i++) {
        if (elements[i].innerHTML === innerHTML) {
            elements[i].classList.add('active');
        }
    }
}