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

function VendorButtons(index) {
    var vendorDiv = document.getElementById('vendor_select_box');
    for (var i = 0; i < index; i++) {
        vendorDiv.children[i].style.color = 'black';
    }
    vendorDiv.children[index].style.color = 'red';
}