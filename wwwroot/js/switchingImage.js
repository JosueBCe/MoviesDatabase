function changeImage() {
    var images = ["/Assets/book_of_mormon.png",
        "/Assets/scripture_1.jpg",
        "/Assets/scripture_2.jpg"];
    // Array of image URLs 
    var currentIndex = 0; var imgElement = document.getElementById("myImage");
    setInterval(function () {
        imgElement.src = images[currentIndex];

       currentIndex = (currentIndex + 1) % images.length;
    }, 3000);
}

window.onload = changeImage(); 