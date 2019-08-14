(function () {
    $(document).ready(function () {
        $('#table').DataTable({
            "pagingType": "full_numbers"
        });
    });

    $("#cpf").inputmask("mask", {
        "mask": "999.999.999-99"
    }, {
            reverse: true
        });

    $("#birthdate").inputmask("mask", {
        "mask": "99/99/9999"
    }, {
            reverse: true
        });

    $('#comZip').inputmask('99999-999');
    $('#resZip').inputmask('99999-999');

    $('#resDDD').inputmask('(99)');
    $('#comDDD').inputmask('(99)');
    $('#celDDD').inputmask('(99)');

    $('#resPhone').inputmask('(9999-9999)');
    $('#comPhone').inputmask('(9999-9999)');
    $('#celPhone').inputmask('(99999-9999)');


})();