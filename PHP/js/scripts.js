
// jQuery Validation Scripts

$(document).ready(function() {

	// Init

    let testInputs = new Array();
    testInputs[0] = $('#name');
    testInputs[1] = $('#phone');
    testInputs[2] = $('#email');
    testInputs[3] = $('#confemail');
    testInputs[4] = $('#addy');
    testInputs[5] = $('#city');
    testInputs[6] = $('#state');
    testInputs[7] = $('#zip');
    testInputs[8] = $('#startDate');
    testInputs[9] = $('#endDate');

	// Set up DatePicker items

    $( function() {
        $( "#startDate" ).datepicker();
    } );

    $( function () {
        $( "#endDate" ).datepicker();
    })

    // Inputs can't be blank

    $.each(testInputs, function(index, value) {
        value.on('input', function() {
            var input=$(this);
            var is_filled=input.val();

            //if(is_filled && input != testInputs[1])
            if(is_filled) {
                input.removeClass("invalid").addClass("valid");
            } else {
            	input.removeClass("valid").addClass("invalid");
            }
        });
    });

    $('#startDate').datepicker().on("input change", function (e) {
            $(".startDate").removeClass("invalid").addClass("valid");
        });

    $('#endDate').datepicker().on("input change", function (e) {
            $(".endDate").removeClass("invalid").addClass("valid");
        });


    // Submit Validation

    $("#submit").click(function(event){

    	$.each(testInputs, function(index, value) {
            validateItems(value);
		});


    	function validateItems(item) {
        	inputName = item.val();

            var regex = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/

       	 	if (item == testInputs[6] && inputName == null){
            	item.addClass("invalid");
        	}

        	if(inputName){
            	if (item == testInputs[1] && !$.isNumeric(testInputs[1].val())){
            		item.removeClass("valid")
             	   	item.addClass("invalid");
                	item.addClass('invalidText');
                	item.focus();
                	$('#phone').val('');
                	item.attr("placeholder", "Please enter a numeric only number");
            	} else if(item == testInputs[3] && testInputs[3].val() != testInputs[2].val()){
                    item.removeClass("valid")
                    item.addClass("invalid");
                    item.addClass('invalidText');
                    item.focus();
                    item.val('');
                    item.attr("placeholder", "Emails do not match");
                } else if(item == testInputs[2] && !item.val().match(regex)){
                    item.removeClass("valid")
                    item.addClass("invalid");
                    item.addClass('invalidText');
                    item.focus();
                    item.val('');
                    item.attr("placeholder", "Please enter a valid email");
                } else if(item == testInputs[3] && !item.val().match(regex)){
                    item.removeClass("valid")
                    item.addClass("invalid");
                    item.addClass('invalidText');
                    item.focus();
                    item.val('');
                    item.attr("placeholder", "Please enter a valid email");
                } else {
                	item.addClass("valid");
				}
        	} else {
            	item.addClass("invalid");
            	item.addClass('invalidText');
                //item.focus();
            	item.attr("placeholder", "Item cannot be empty");
        	}
    	}

    	var error_free = true;
        $.each(testInputs, function(index, value) {
           if(!value.hasClass("valid")){
		    	error_free = false;
		   }
        });

        if (error_free){
        	alert('No errors. Your submission will be sent.')
		}


    });
});




