﻿function onButtonClick(evt) {
    ////////
    var b = evt.currentTarget;

    var buttonName = b.getAttribute("name");

    var classes = b.classList;

    var isGreen = false;

    for (var i = 0; i < classes.length; i++) {
        var c = classes[i];

        if (c == "greenButton") {
            isGreen = true;
            break;
        }
      
    }

    if (isGreen) {
        b.className = "btn redButton";
    } else {
        b.className = "btn greenButton"
    }

    var t = document.getElementById("sampleTable");

    var currentHtml = t.innerHTML;

    t.innerHTML += "<tr><td>" + b.getAttribute("name") + "</td><td>" + new Date() + "</td></tr>";
    //////////
}


//var button = document.getElementsByTagName("button")[0];
var buttons = document.getElementsByTagName("button");

for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);;
}

//debugger;

//buttons.addEventListener("click", onButtonClick);
