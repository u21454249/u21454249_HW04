$(function () {

        // ------------------------------------------------------
        // Add values

        $('#btnAdd').on('click', function () {
            var id;
            id = $("#txtText").val();
            var edit = "<a class='edit' href='JavaScript:void(0);' ><button type='button' id='btnAdd' class='button'>Edit</button> </a>";
            var del = "<a class='delete' href='JavaScript:void(0);'><button type='button' id='btnAdd' class='button'>Delete</button> </a>";
            var table = "<tr><td class='tdTxt'>"
                + id + "</td><td class='tdSpecial'>"
                + edit + "</td><td class='tdSpecial'>"
                + del + "</td></tr>";

            $("#tblTable").append(table);
            id = $("#txtText").val("");
        });

    // ------------------------------------------------------
    // Edit  values

    $("#tblTable").on("click", ".edit", function () {
            var row = $(this).closest('tr');
    var td = $(row).find("td");
    $('#hfRowIndex').val($(row).index());
    $('#txtText').val($(td).eq(0).html());
    $('#btnAdd').hide();
    $('#btnUpdate').show();
        });
    });
    // ------------------------------------------------------
    // Update values

    $('#btnUpdate').on('click', function () {
        var name, country, id;
    id = $("#txtText").val();
    $('#tblTable tbody tr').eq($('#hfRowIndex').val()).find('td').eq(0).html(id);
    $('#btnAdd').show();
    $('#btnUpdate').hide();

    });

    // ------------------------------------------------------
    // Delete values
    $("#tblTable").on("click", ".delete", function (e) {
        $(this).closest('tr').remove();
    });
    $('#btnClear').on('click', function () {
        Clear();
    });

    // ------------------------------------------------------
    // Clear page on refresh
    function Clear() {
        $("#txtText").val("");
    $("#hfRowIndex").val("");
    }

