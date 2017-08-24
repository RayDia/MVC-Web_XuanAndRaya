$('#data tbody tr:even').addClass("white");
$('#data tbody tr:even').mouseover(function () {
    $(this).addClass('dataHover');
});
$('#data tbody tr:even').mouseout(function () {
    $(this).removeClass('dataHover');
});
$('#data tbody tr:odd').mouseover(function () {
    $(this).addClass('dataHoverodd');
});
$('#data tbody tr:odd').mouseout(function () {
    $(this).removeClass('dataHoverodd');
});

