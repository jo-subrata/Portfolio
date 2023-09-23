const form = document.getElementById('form');
form.addEventListener('submit', function(e) {
    e.preventDefault();

    const name = document.getElementById('name').value;
    const phone = document.getElementById('phone').value;
    const product = document.getElementById('product').value;
    const qty = document.getElementById('qty').value;
    const address = document.getElementById('address').value;

    if(!validateName(name)){
        return;
    }
    if(!validatePhone(phone)){
        return;
    }
    if(!validateProduct(product)){
        return;
    }
    if(!validateQty(qty)){
        return;
    }
    if(!validateAddress(address)){
        return;
    }

    alert("You have successfully purchased! We will deliver to you as soon as possible!")
    const user = {
        name: name,
        phone: phone,
        qty: qty,
        address: address,
        product: product
    }
    console.log(user);
    form.reset();
})

function validateName(name){
    if(name == ""){
        alert("You must enter your name!");
        return false;
    }
    if(name.length < 5){
        alert("Name length must be at least 5 characters");
        return false;
    }
    return true;
}

function validatePhone(phone){
    if(phone == ""){
        alert("You must enter your phone number!");
        return false;
    }

    if(isNaN(phone)){
        alert("Phone number must be inputted using numbers")
        return false;
    }

    if(phone.length < 10){
        alert("Phone number must have at least 10 digits");
        return false;
    }
    return true;
}

function validateProduct(product){
    if(product == ""){
        alert("You must enter a product name!");
        return false;
    }
    return true;
}

function validateQty(qty){
    if(qty == ""){
        alert("How many chocolates do you wanna buy?");
        return false;
    }
    if(qty <= 0){
        alert("Quantity cannot be negative or 0");
        return false;
    }
    return true;
}

function validateAddress(address){
    if(address == ""){
        alert("Address cannot be empty");
        return false;
    }

    if(address.indexOf("Street") == -1){
        alert("Address must contain \"Street\" [Example: Sunib Street 123, Jakarta]");
        return false;
    }
    return true;
}