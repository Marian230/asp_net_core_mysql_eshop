function DifferentBillingAddress() {
    var selectEl = document.getElementById('different-billing-address');
    var form = document.getElementsByClassName('different-billing-address');

    if (selectEl.value == 1) {
        form[0].style.display = 'block';
    }
    else if (selectEl.value == 0) {
        form[0].style.display = 'none';
    }
}