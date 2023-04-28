(function () {
    var myArray = [
        { "Name": "Sofia","LastName": "Carrillo","Date": "01/01/2023"},
        {"Name": "Adrian","LastName": "Munoz","Date": "02/01/2023"},
        { "Name": "Manuel", "LastName": "Castillo", "Date": "03/01/2023"},
        { "Name": "Marcela", "LastName": "Dominguez", "Date": "04/01/2023" },
        { "Name": "Miguel", "LastName": "Balam", "Date": "05/01/2023"},
        { "Name": "Miguel", "LastName": "Albornoz", "Date": "06/01/2023"  },
        { "Name": "Dennis", "LastName": "Yam", "Date": "07/01/2023"  },
        { "Name": "Ariatne", "LastName": "Moo", "Date": "08/01/2023" },
        { "Name": "Fanny", "LastName": "May", "Date": "09/01/2023" },
        { "Name": "Yessel", "LastName": "Pech", "Date": "10/01/2023" }
    ]
     var t = document.getElementById("list");

    var currentHtml = t.innerHTML;
    for (var i = 0; i < myArray.length; i++) {
        t.innerHTML += '<li>' + '<b>Name:</b>' + myArray[i].Name +
            '<b>Last name:</b>' + myArray[i].LastName +
            '<b>Date:</b>' + myArray[i].Date + '</li>';
    }

}());


