//Onload => Get the number of categories to show in cart icon
window.addEventListener("load", refreshNumInCart());

function addToCart(id_khachhang, id_hanghoa) {
    var documentRoot = document.getElementById("documentRoot").innerHTML;
    if (id_khachhang == 0) {
        launch_toast("Hãy đăng nhập!");
        return;
    }
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            // document.getElementById("demo").innerHTML = this.responseText;
            // console.log(this.responseText);

            var response = JSON.parse(this.response);

            if (response.isSuccess == true) {
                document.getElementById("cartAmountId").innerText = response.amount;
                launch_toast("Đã thêm vào giỏ hàng!");
            } else {
                launch_toast("Thêm vào giỏ hàng thất bại!");
            }
        }
    };
    xhttp.open(
        "GET",
        `${documentRoot}/cart/addtocart?id_khachhang=${id_khachhang}&id_hanghoa=${id_hanghoa}`,
        true
    );
    xhttp.send();
}

function launch_toast(message) {
    var x = document.getElementById("toast");
    document.getElementById("desc").innerText = message;
    x.className = "show";
    setTimeout(function() {
        x.className = x.className.replace("show", "");
    }, 5000);
}

//Update the number of categories in cart icon
function refreshNumInCart() {
    var documentRoot = document.getElementById("documentRoot").innerText;
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            //Get result = result of function amountIncart() in CartController
            if (this.responseText)
                document.getElementById("cartAmountId").innerText = this.responseText;
            else document.getElementById("cartAmountId").innerText = 0;
        }
    };
    //Call function amountInCart() in CartController
    xhttp.open("GET", `${documentRoot}/cart/amountInCart`, true);
    xhttp.send();
}