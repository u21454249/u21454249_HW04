$(document).ready(function () {
    $(".Ado").show();
    $(".Mom").hide();
    $(".bplan").hide();
    
    $("#bookingType").on("change", function () {
        var val = $(this).val();
        if (val == "1") {
            $(".Ado").show();
            $(".Mom").hide();
            $(".bplan").hide();
        }
        if (val == "2") {
            $(".Mom").show();
            $(".Ado").hide();
            $(".bplan").hide();

        }
        if (val == "3") {
            $(".bplan").show();
            $(".Ado").hide();
            $(".Mom").hide();
        }
    });
})