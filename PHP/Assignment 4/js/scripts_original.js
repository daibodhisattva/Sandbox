function emailValid() {
	var email = document.getElementById("email").value;
	var confEmail = document.getElementById("confemail").value;
	var phoneNum = document.getElementById("phone").value;
	var validEmail = false

	var regex = /\w*@\w*\.\w*/g;
	if(!(regex.test(email) || regex.test(confEmail))) {
		alert("Please enter a valid email address");
		validEmail = false;
	} else {
        if(email == confEmail) {
            if(phoneNum.match(/^\d+/))
            {
                validEmail = true;
            } else {
            	alert("Please use only numbers for your phone number entry!");
            	validEmail = false;
			}
        } else {
            alert("Please make sure both emails match!");
            validEmail = false;
        }
	}

    if(validEmail) {
		return true;
	} else {
		return false;
	}
}

function validate() {

	if(emailValid()) {
        alert("Your information is valid, and the form will be submitted.")
	}
}
