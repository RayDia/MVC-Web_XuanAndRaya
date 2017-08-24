$(function () {
    $('#birthday').datepicker({
        dateFormat: "MM-dd-yy",
        changeMonth: true,
        changeYear: true,
        yearRange: "-60:+0"
    });
    $('select').addClass("form-control");
    $('label').addClass("control-label col-md-4")
});