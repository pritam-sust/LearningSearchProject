
$(document).ready(function () {
    $('#btnReserve').click(function () {
        $('#reserveModal').modal('show');
    });


    $('.datepicker').datepicker();

    $('.tpicker').timepicker();

    $('.bas').show();
    $('.adv').hide();

    $('#DataListTable').DataTable({
        "ajax": {
            "url": "/search/LoadData",
            "type": "GET",
            "datatype": "json"
        },

        "info": true,
        "responsive": true,
        "paging": true,
        "pageLength": 10,
        "ordering": true,
        "dom": 'T<"clear">lfrtip',

        "pagingType": "full_numbers",
        "language": {
            "lengthMenu": "Display _MENU_ Per Page",
            "info": "Displaying _START_ - _END_ of _TOTAL_",
            "paginate": {
                "first": '<i class="fa fa-angle-double-left" ></i> First',
                "previous": '<i class="fa fa-angle-double-left" ></i> Previous',
                "next": 'Next <i class="fa fa-angle-double-right" ></i>',
                "last": 'Last <i class="fa fa-angle-double-right" ></i>'
            },

        },
        "dom": "<'row'<'col-sm-4'i><'col-sm-4'p><'col-sm-4'l>>" + "<'row'<'col-sm-12'tr>>",
        "scrollX": true,
        "lengthMenu": [
             [5, 10, 15, 20, -1],
             [5, 10, 15, 20, "All"] // change per page values here
        ],
        "buttons": [
            'csv', 'excel', 'pdf'
        ],
        //tableTools: {
        //    "sSwfPath": "Content/images/copy_csv_xls_pdf.swf"
        //},
        "columns": [
            { "data": null, "autowidth": false },
            {
                "data": "DateCreated", "type": "date", "render": function (value) {
                    if (value === null) return "";

                    var pattern = /Date\(([^)]+)\)/;
                    var results = pattern.exec(value);
                    var dt = new Date(parseInt(results[1]));
                    var mon = parseInt(dt.getMonth()) + 1;

                    return (mon + "/" + (dt.getDate()) + "/" + dt.getFullYear());
                }
            },
            { "data": "ReservationCode", "autowidth": true },
            { "data": "ExternalCode", "autowidth": true },
            { "data": "ReservationStatus", "autowidth": true },
            { "data": "MemberName", "autowidth": true },
            { "data": "VehicalId", "autowidth": true },
            { "data": "Category", "autowidth": true },
            { "data": "VehicalInfo", "autowidth": true },
            { "data": "OwnerName", "autowidth": true },
            {
                "data": "StartDate", "type": "date", "render": function (value) {
                    if (value === null) return "";

                    var pattern = /Date\(([^)]+)\)/;
                    var results = pattern.exec(value);
                    var dt = new Date(parseFloat(results[1]));

                    var mon = parseInt(dt.getMonth()) + 1;

                    return (mon + "/" + (dt.getDate()) + "/" + dt.getFullYear());
                }
            },
                {
                    "data": "StartTime", "type": "date", "render": function (value) {
                        if (value === null) return "";

                        var pattern = /Date\(([^)]+)\)/;
                        var results = pattern.exec(value);
                        var dt = new Date(parseFloat(results[1]));

                        return (dt.getHours() + ':' + dt.getMinutes());
                    }
                },
                {
                    "data": "EndDate", "type": "date", "render": function (value) {
                        if (value === null) return "";

                        var pattern = /Date\(([^)]+)\)/;
                        var results = pattern.exec(value);
                        var dt = new Date(parseFloat(results[1]));

                        var mon = parseInt(dt.getMonth()) + 1;

                        return (mon + "/" + (dt.getDate()) + "/" + dt.getFullYear());
                    }
                },
                {
                    "data": "EndTime", "type": "date", "render": function (value) {
                        if (value === null) return "";

                        var pattern = /Date\(([^)]+)\)/;
                        var results = pattern.exec(value);
                        var dt = new Date(parseFloat(results[1]));

                        return (dt.getHours() + ':' + dt.getMinutes());
                    }
                },
                { "data": "PickupLocation", "autowidth": true },
                {
                    "data": "TotalAmount", "render": function (data) {
                        return '$' + data;
                    }
                },
                {
                    "data": "Balance", "render": function (data) {
                        return '$' + data;
                    }
                }

        ],
        "columnDefs": [
            {
                targets: [0],
                render: function (data, type, row) {
                    if (row.ReservationStatus.trim().toLowerCase() == 'complete') {
                        return '<i class="fa fa-square" aria-hidden="true" style="margin-right:4px; color:green"></i><i class="fa fa-plus-square" aria-hidden="true" style="margin-right:4px; color:green"></i><i class="fa fa-edit" aria-hidden="true" style="color:green"></i>';
                    }

                    else {
                        return '<i class="fa fa-square" aria-hidden="true" style="margin-right:4px; color:orange"></i><i class="fa fa-edit" aria-hidden="true"  style="color:red"></i>';
                    }
                }
            },
            {
                targets: [4],
                render: function (data, type, row) {
                    if (row.ReservationStatus.trim().toLowerCase() == 'complete') {
                        return '<section style="color:green">COMPLETE</section>';
                    }
                    else if (row.ReservationStatus.trim().toLowerCase() == 'incomplete') {
                        return '<section style="color:orange">INCOMPLETE</section>';
                    }
                    else {
                        return '<section style="color:red">CANCEL</section>';
                    }
                }
            },
            {
                targets: [3, 6, 8, 11, 13, 14, 15],
                sortable: false
            }
        ]

    });

    $('#chkReqPending').change(function () {
        if (this.checked) {
            $(".checkControl").prop("checked", true);
        } else {
            $(".checkControl").prop("checked", false);
        }
    });

    $('#btnSelect').click(function () {
        $(".checkControl").prop("checked", true);
    });

    $('#btnReset').click(function () {
        $(".checkControl").prop("checked", false);
    });

    $('#BtnResetForm').click(function () {
        $('#frmSearchDashBoard').trigger("reset");
    });

    $('#BtnSearchForm').click(function () {
        $('#frmSearchDashBoard').trigger("reset");
    });

    $("#btnAdv").click(function () {
        var btnVal = $('#btnAdv').val();
        if (btnVal == 1) {
            $('.bas').show();
            $('.adv').show();
            $('#btnAdv').val(0);
            $('#btnAdv').html('<i class="fa fa-search-minus"></i> Basic')
        }
        else {
            $('.bas').show();
            $('.adv').hide();
            $('#btnAdv').val(1);
            $('#btnAdv').html('<i class="fa fa-search-plus"></i> Advance');
        }
    });
});// end of document ready
