/* DatePicker - Default settings */
$.fn.datepicker.defaults.language = "cs";
$.fn.datepicker.defaults.templates = {
    leftArrow: '<i class="fa fa-chevron-left"></i>',
    rightArrow: '<i class="fa fa-chevron-right"></i>'
};

$('.input-group.date').datepicker({    
    orientation: 'bottom',
    clearBtn: true,    
});

$('.input-daterange').datepicker({
    orientation: 'bottom',
    autoclose: true,
    todayHighlight: true,
});

$('div #datepicker').datepicker({    
    orientation: 'bottom',
    title: 'Kalendář',
});