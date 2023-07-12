

(function () {


    document.getElementById("SubmitButton").addEventListener("click", function() {

        modalM();

    });
    //-----------------------------------------
    document.getElementById("InputText").addEventListener("keydown", function (e) {
        if (event.keyCode == 13) {
            modalM();
        }
    });

    function modalM() {
        var myModal = new bootstrap.Modal(document.getElementById('exampleModal'));
        myModal.show();

        var today = new Date();
        var time = today.getHours() + ':' + today.getMinutes() + ':' + today.getSeconds();

        let inputValue = document.getElementById("InputText").value;
        var MessageModal = document.getElementById("MessageModalContent");
        MessageModal.innerHTML = "Salida registrada por el miembro " + inputValue + " " + time + "";

        function CloseModal() {
            myModal.hide();
        }

        setTimeout(CloseModal, 3000);
    }

}());