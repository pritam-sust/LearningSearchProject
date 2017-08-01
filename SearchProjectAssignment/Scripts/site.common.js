/// <reference path="site.common.js" />


var SS_ServerYear = 'ServerYear';
var SS_ServerDate = 'ServerDate';
var SS_CompanyStructure = null;
var companyStructure = null;
function MakePagination(tableId) {
    $('#' + tableId).dataTable({
        "paging": true,
        "ordering": true,
        "info": true
    });

    //$('#' + tableId + '_filter').empty().append('<label><input type="search" placeholder="Search" class="form-control" aria-controls="' + tableId + '"></label>');
}


// this function skips the first column in search
function MakePaginationWithExport(tableId, column, title, message, orientation, fileName, pageLength, fixedColumn) {
    orientation = null ? "portrait" : orientation;
    pageLength = null ? "10" : pageLength;
    fixedColumn = null ? false : fixedColumn;
    $('#' + tableId).dataTable({
        "paging": true,
        "pageLength": pageLength,
        "ordering": true,
        "info": true,
        "responsive": true,
        "aoColumnDefs": [{ "bSearchable": false, "aTargets": [0] }],
        "columnDefs": [
        {
            "type": "html",
        }
        ],
        "dom": 'T<"clear">lfrtip',
        "tableTools": {
            "sSwfPath": "/Plugins/madmin/vendors/DataTables/extensions/TableTools/swf/copy_csv_xls_pdf.swf",
            "aButtons": [
                 {
                     "sExtends": "csv",
                     "sTitle": title,
                     "sFileName": fileName + '.csv',
                     "bHeader": true,
                     "mColumns": column,
                 },
                 {
                     "sExtends": "xls",
                     "sTitle": title,
                     "sFileName": fileName + '.xls',
                     "bHeader": true,
                     "mColumns": column,
                 },
                 {
                     "sExtends": "pdf",
                     "sPdfOrientation": orientation,
                     "sTitle": title,
                     "sPdfMessage": message,
                     "sFileName": fileName + '.pdf',
                     "bHeader": true,
                     "mColumns": column,
                 },
                {
                    "sExtends": "print",
                }
            ],
        },

    });

}

// this function skips search for the given columns in searchEscapeColumns
function MakePaginationWithExportEscapeSearchForGivenColumns(tableId, column, searchEscapeColumns, title, message, orientation, fileName) {
    orientation = null ? "portrait" : orientation;

    $('#' + tableId).dataTable({
        "paging": true,
        "ordering": true,
        "info": true,
        "aoColumnDefs": [{ "bSearchable": false, "aTargets": searchEscapeColumns }],
        "columnDefs": [
        {
            "type": "html",
        }
        ],
        "dom": 'T<"clear">lfrtip',
        "tableTools": {
            "sSwfPath": "/Plugins/madmin/vendors/DataTables/extensions/TableTools/swf/copy_csv_xls_pdf.swf",
            "aButtons": [
                 {
                     "sExtends": "csv",
                     "sTitle": title,
                     "sFileName": fileName + '.csv',
                     "bHeader": true,
                     "mColumns": column,
                 },
                 {
                     "sExtends": "xls",
                     "sTitle": title,
                     "sFileName": fileName + '.xls',
                     "bHeader": true,
                     "mColumns": column,
                 },
                 {
                     "sExtends": "pdf",
                     "sPdfOrientation": orientation,
                     "sTitle": title,
                     "sPdfMessage": message,
                     "sFileName": fileName + '.pdf',
                     "bHeader": true,
                     "mColumns": column,
                 },
                {
                    "sExtends": "print",
                }
            ],
        },

    });

}

function MakePaginationWithExportButton(tableId) {
    $('#' + tableId).dataTable({
        "paging": true,
        "ordering": true,
        "info": true,
        "dom": 'T<"clear">lfrtip',
        "tableTools": {
            "aButtons": [
                "copy",
                "csv",
                "xls",
                {
                    "sExtends": "pdf",
                    "sPdfOrientation": "landscape",
                    "sPdfMessage": "Test"
                },
                "print"
            ]
        }
    });
}

function ShowNotification(type, message) {

    if (type != '0') {
        if (type == '1' || type == 'success') {
            toastr.success(message);
        }
        else if (type == '2' || type == 'warning') {
            toastr.warning(message);
        }
        else if (type == '3' || type == 'error') {
            toastr.error(message);
        }
        else if (type == '4' || type == 'info') {
            toastr.info(message);
        }

    }
}

function showDialog(type, message) {
    $("#lblMessage").text(message);
    $("#dialog-message").dialog({
        modal: true,
        draggable: false,
        resizeable: false,
        position: ['center', 'middle'],
        //width: 400,
        buttons: {
            "Ok": function () {
                $(this).dialog("close");
            }
        }
    });
    //$(".ui-dialog-titlebar").hide();
}

function GetServerDateWithCallback(callback) {
    var date = "";
    var url = '/Common/GetServerDate';
    $.getJSON(url, {}, function (data) {
        date = data;
        callback(date);
    });
}

function GetServerDate() {

    var date = sessionStorage.getItem(SS_ServerDate);
    if (!date) {
        var url = '/Common/GetServerDate';
        $.ajax({
            url: url,
            method: 'get',
            dataType: 'json',
            async: false,
            data: {
            },
            success: function (data) {
                date = data;
                sessionStorage.setItem(SS_ServerDate, date);
            },
            error: function () {
            }
        });
    }
    return date;
}

function GetServerYear() {

    var year = sessionStorage.getItem(SS_ServerYear);

    if (!year) {
        year = "";
        var url = '/Common/GetServerYear';
        $.ajax({
            url: url,
            method: 'get',
            dataType: 'json',
            async: false,
            data: {
            },
            success: function (data) {
                year = data;
                sessionStorage.setItem(SS_ServerYear, year);
            },
            error: function () {
            }
        });
    }

    return year;
}

function GetServerDateTime() {
    var date = "";
    var url = '/Common/GetServerDateTime';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
        },
        success: function (data) {
            date = data;
        },
        error: function () {
        }
    });
    return date;
}

function GetFormatedEmployeeId(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetFormatedEmployeeId';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            if (data == null) {
                ShowNotification(2, "Invalid (" + employeeId + ") Employee ID.");
                employee = null;
                return;
            }
            employee = data;
        },
        error: function () {
        }
    });
    return employee;
}

function GetFormatedId(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetFormatedId';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;
}

function IsRosterEmployee(identityCode, employeeId, date) {
    var employee = false;
    var url = '/Common/IsRosterEmployee';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId,
            date: date
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;
}

function GetEligibleJobStatus(identityCode, operationName) {
    var jobStatus = "";
    var url = '/Common/GetEligibleJobStatus';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            operationName: operationName
        },
        success: function (data) {
            jobStatus = data;
        },
        error: function () {
        }
    });
    return jobStatus;
}

function GetFormatedEmployeeIdForStatus(identityCode, employeeId, isDetails) {
    var employee = "";
    var url = '/Common/GetFormatedEmployeeIdForStatus';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId,
            isDetails: isDetails
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;
}

function GetFormatedEmployeeIdForOperation(identityCode, employeeId, operationName) {
    var employee = null;
    var url = '/Common/GetFormatedEmployeeIdForOperation';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId,
            operationName: operationName
        },
        success: function (data) {
            employee = data;

            if (data == null) {
                ShowNotification(2, "Invalid (" + employeeId + ") Employee ID.");
                employee = null;
                return;
            }
            if (data == 1) {
                ShowNotification(2, "Process wise employee filtering is not yet set. Please set employee filtering policy.");
                employee = null;
                return;
            }

            if (data.EmployeeStatus == null) {
                ShowNotification(2, "Employee job related information not found. Please set employee job status information.");
                employee = null;
                return;
            }
            if (!data.IsEligibleJobStatus) {
                ShowNotification(2, "Employee job status(" + data.EmployeeStatus.JobStatusID + ") is not valid for this operation. To validate this status please add this status to process wise employee filtering or update employee filtering policy.");
                employee = null;
                return;
            }

            if (!data.IsEligibleJobBase) {
                ShowNotification(2, "Employee job base(" + data.EmployeeStatus.JobbaseID + ") is not valid for this operation. To validate this job base please add this job base to process wise employee filtering or update employee filtering policy.");
                employee = null;
                return;
            }
        },
        error: function () {
        }
    });
    return employee;
}

function GetAllLocationDivisionDepartmentWiseEmployeeForOperation(identityCode, employeeId, locationId, divisionId, departmentId, operationName) {
    var url = '/Common/GetAllLocationDivisionDepartmentWiseEmployeeForOperation';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId,
            locationId: locationId,
            divisionId: divisionId,
            departmentId: departmentId,
            operationName: operationName
        },
        success: function (data) {
            if (data == null) {
                ShowNotification(2, "No Employee Found.");
            }
            else {
                return data;
            }
        },
        error: function () {
        }
    });
}

function GetEmployeeInformation(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetEmployee';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;

}

function GetFormatedIdWithEmployee(identityCode, employeeId) {
    var employee = null;
    var url = '/Common/GetFormatedIdWithEmployee';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            if (data != null) {
                employee = data;
            } else {
                window.ShowNotification('4', 'Employee information not found.');
            }
        },
        error: function () {

        }
    });
    return employee;

}

function GetEmployeePersonalDetails(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetEmployeePersonalDetails';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;

}

function GetFormatedEmployeeIdWithCurrentDetails(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetFormatedEmployeeIdWithCurrentDetails';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            if (data == null) {
                ShowNotification(2, "Employee Job Related Information Not Found For Employee ID (" + employeeId + ")");
                employee = null;
                return;
            }
            employee = data;
        },
        error: function () {
        }
    });
    return employee;

}
function GetEmployeeCurrentDetailsWithStatusNotMandatory(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetEmployeeCurrentDetailsWithStatusNotMandatory';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            if (data == null) {
                ShowNotification(2, "Employee Job Related Information Not Found For Employee ID (" + employeeId + ")");
                employee = null;
                return;
            }
            employee = data;
        },
        error: function () {
        }
    });
    return employee;

}

function GetSelfServiceEmployee() {
    var employee = "";
    var url = '/Common/GetSelfServiceEmployee';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;

}

function IsAnyModuleSelected() {
    var returnvalue = "";
    var url = '/Common/IsAnyModuleSelected';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        success: function (data) {
            returnvalue = data;
        },
        error: function () {
        }
    });
    return returnvalue;
}

function ShowMessage(MsgType, Msg, LstErrors, Url) {

    if (MsgType != '0') {
        if (MsgType == '1' || MsgType == 'success') {
            toastr.success(Msg);
        }
        else if (MsgType == '2' || MsgType == 'warning') {
            toastr.warning(Msg);
        }
        else if (MsgType == '3' || MsgType == 'error') {
            toastr.error(Msg);
        }
        else if (MsgType == '4' || MsgType == 'info') {
            toastr.info(Msg);
        }

    }
}

function HideMsgDivs() {
    $('#ErrorsList').empty();
    $('#SuccessMsgDiv').css('display', 'none');
    $('#ErrorMsgDiv').css('display', 'none');
}

function GetFormatedDate(date) {

    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
    return day + '-' + month + '-' + year;

}

function GetFormatedDateWithMonthName(date) {

    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
    return day + '-' + GetMonthNameInShort(month) + '-' + year;

}

function FormatJsonDate(jsonDate) {

    var d = new Date(parseInt(jsonDate.slice(6, -2)));
    var date = d.getDate() + '-' + (1 + d.getMonth()) + '-' + d.getFullYear();
    return date;
}

function FormatJsonDateToStringDate(jsonDate) {
    if (jsonDate) {
        var d = new Date(parseInt(jsonDate.slice(6, -2)));
        var day = d.getDate().toString();
        if (day.length == 1) {
            day = "0" + day;
        }
        var date = day + '-' + GetMonthNameInShort(1 + d.getMonth()) + '-' + d.getFullYear();
        return date;
    }

    return null;

}

function FormatJsonMonthYear(jsonDate) {

    if (jsonDate != null) {
        var d = new Date(parseInt(jsonDate.slice(6, -2)));
        var month = GetMonthName(1 + d.getMonth());
        var year = d.getFullYear();
        var date = month + ', ' + year;
        return date;
    }
    return null;
}

function GetMonthNameInShort(monthNumber) {
    var months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
    return months[monthNumber - 1];
}

function ConvertStringToDate(stringDate) {
    var months = ["jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec"];
    var data = stringDate.split('-');
    var day = data[0];
    var month = months.indexOf(data[1].toLowerCase());
    var year = data[2];
    return new Date(year, month, day).getTime();
}

function CreateDate(year, intMonth) {
    return new Date(year, intMonth - 1, 01).getTime();
}

function GetMonthName(monthNumber) {
    var months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    return months[monthNumber - 1];
}

function GetMonthNumber(monthName) {
    var month1 = ["jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec"];
    var month2 = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    if (monthName.length >= 3) {
        return month1.indexOf(monthName.toLowerCase());
    } else {
        return month2.indexOf(monthName.toLowerCase());
    }

}

function ShowLoaderGlobal() {
    var width = window.outerWidth;
    var height = window.outerHeight;
    var w = (width / 2) - 450;
    var h = (height / 2) - 100;
    var div = '<div id="ICustomLoader" style="height:' + height + 'px; width:' + width + 'px;background-color:rgba(0,0,0,0.5);z-index:999999;top:0;bottom:0;right:0;left:0; position:fixed;">' +
        '<div style="margin-left:' + w + 'px; margin-top:' + h + 'px ; "><p style="color:lightgray; font-size:20px;text-align: center;line-height: 75px;"><img src="/Images/LoaderImages/loading1.gif"/></p></div>' +
        '</div>';
    $('body').append(div);

    $('#ICustomLoader').on("contextmenu", function (e) {
        e.preventDefault();
    });
}//rgba(0,0,0,.6)

function HideLoaderGlobal() {
    $('#ICustomLoader').remove();
}

function ShowLoader() {
}

function HideLoader() {
}

function SearchStaff(setControlName, nextCall) {
    window.open('../Home/SearchStaff?setControlName=' + setControlName + '&nexCall=' + nextCall, '', 'width = 350', 'height=200');

}

function decimal(e, ths) {
    var keynum;
    if (window.event) {
        keynum = e.keyCode;
    }
    else
        if (e.which) {
            keynum = e.which;
        }
    var tv = ths.value;
    if (tv == "" && e.which == 45) return true;
    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
        if (e.which != 46 && e.which != 190) {
            ShowNotification(2, 'Decimal value only.');
            return false;
        }
        var charExists = (tv.indexOf('.') >= 0) ? false : true;
        if (!charExists) return false;
    }
}

function integer(e, ths) {
    var keynum;
    if (window.event) {
        keynum = e.keyCode;
    }
    else
        if (e.which) {
            keynum = e.which;
        }
    var tv = ths.value;
    if (tv == "" && e.which == 45) return true;
    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
        if (e.which != 190) {
            ShowNotification(2, 'Integer value only.');
            return false;
        }
    }
}

$(document).on('keypress', '.decimal-only', function (e) {
    var keynum;
    if (window.event) {
        keynum = e.keyCode;
    }
    else
        if (e.which) {
            keynum = e.which;
        }
    var tv = $(this).value;
    if (tv == "" && e.which == 45) return true;
    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57) && e.which != 109) {
        if (e.which != 46 && e.which != 190 && e.which != 109) {
            ShowNotification(2, 'Decimal value only.');
            return false;
        }
        var charExists = (tv.indexOf('.') >= 0) ? false : true;
        if (!charExists) return false;

        var subExists = (tv.indexOf('-') >= 0) ? false : true;
        if (!subExists) return false;
    }

});

$(document).on('keypress', '.number-only', function (e) {

    var keynum;
    if (window.event) {
        keynum = e.keyCode;
    }
    else
        if (e.which) {
            keynum = e.which;
        }
    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
        if (e.which != 190) {
            ShowNotification(2, 'Integer value only.');
            return false;
        }
    }

});

function ValidateYearInfo(year) {
    var filter = new RegExp("([1-2][0-9][0-9][0-9])");
    if (filter.test(year)) {
        return true;
    } else {
        return false;
    }
}

function IsValidForm(formId) {

    $('#' + formId).data('bootstrapValidator').validate();
    return $('#' + formId).data('bootstrapValidator').isValid() ? true : false;
};

function GetFormData(className) {
    var data = {};
    $('.' + className).each(function () {
        var name = $(this).attr('name');
        if (name != 'undifined') {
            if ($(this).is('input[type="text"]') || $(this).is('input[type="hidden"]') || $(this).is('select') || $(this).is('textarea')) {
                console.log(name);
                if ($(this).val()) {
                    data[name] = $(this).val().trim();
                }

            }
            else if ($(this).is('input[type="checkbox"]')) {
                var id = $(this).attr('id');
                if (document.getElementById(id).checked) {
                    data[id] = true;
                } else {
                    data[id] = false;
                }
            } else if ($(this).is('input[type="radio"]')) {
                var id = $(this).attr('id');
                if (document.getElementById(id).checked) {
                    data[id] = true;
                } else {
                    data[id] = false;
                }
            }

        }
    });
    data["IdentityCode"] = $('#BaseIdentityCode').val();
    data["BaseIdentityCode"] = $('#BaseIdentityCode').val();
    return data;
};

function SetFormData(data, exclues) {
    if (exclues == null) {
        exclues = [];
    }
    for (var key in data) {
        if (exclues.indexOf(key) == -1) {
            if ($('#' + key).is('input[type="text"]') || $('#' + key).is('input[type="hidden"]') || $('#' + key).is('select') || $('#' + key).is('textarea')) {
                $('#' + key).val(data[key]);
            }
            else if ($('#' + key).is('input[type="checkbox"]')) {

                if (data[key] == "True" || data[key] == "False") {
                    $('#' + key).prop('checked', JSON.parse(data[key].toLowerCase()));
                } else {
                    $('#' + key).prop('checked', data[key]);
                }

            }
        }
    }
};

function ClearFormField(excludes) {
    if (excludes) {
        $('input[type=text],input[type=hidden],select,textarea').each(function () {

            var id = $(this).attr('id');
            if (id && excludes.indexOf(id) < 0) {
                if (!($(this).hasClass('non-cleared'))) {
                    $(this).val('');
                }
            }
            else {
                if (!($(this).hasClass('non-cleared'))) {
                    $(this).val('');
                }
            }
        });
    }
    else {
        $('input[type=text],input[type=hidden],select,textarea').each(function () {
            if (!($(this).hasClass('non-cleared'))) {
                $(this).val('');
            }
        });
        $('input[type=checkbox]').attr('checked', false);
    }
}

function AjaxRequest(url, type, data, async, cache, successCallBack) {
    ShowLoader();
    type == null ? 'post' : 'get',
    async == null ? true : false;
    cache == null ? false : true;
    $.ajax({
        url: url,
        type: type,
        data: data,
        async: async,
        cache: cache,
        success: successCallBack,
        error: function (xhr) {
        }
    });
    HideLoader();
};

function AjaxRequestWithList(url, type, data, successCallBack) {
    ShowLoader();
    type == null ? 'post' : 'get';
    var contentType = 'application/json;charset=utf-8';
    $.ajax({
        url: url,
        contentType: contentType,
        type: type,
        data: data,
        success: successCallBack,
        error: function (xhr) {
        }
    });
    HideLoader();
};

function ValidateYear(e) {

    e = '#' + e;
    var year = parseInt($(e).val());

    if (!isNaN(year)) {
        if (year < 99) {
            year = year >= 70 ? 1900 + year : 2000 + year;
        }
        else if (year <= 970) {
            year = 2000 + year;
        }
        else if (year <= 999) {
            year = 1000 + year;
        }
        else if (year <= 1970) {
            year = 0;
        }

    }
    else {
        year = 0;
    }

    $(e).val(year);
    if (year < 1970) {
        $(e).val('');
    }
    return year;
}

function SetEmployeeDetailsInformationGlobal(employee) {
    $('#EmployeeID').val('');
    $('#EmployeeName').val('');
    $('#EmployeeDesignation').val('');
    $('#EmployeeDivision').val('');
    $('#EmployeeLocation').val('');
    $('#EmployeeDepartment').val('');
    $("#EmployeeImage").attr('src', "data:image/jpg;base64," + '');
    if (employee != null) {
        $('#EmployeeID').val(employee.EmployeeID);
        $('#EmployeeName').val(employee.EmployeeFullName);
        if (employee.EmployeeDetailsInformation != null) {
            $('#EmployeeDesignation').val(employee.EmployeeDetailsInformation.DesignationName);
            $('#EmployeeDivision').val(employee.EmployeeDetailsInformation.DivisionName);
            $('#EmployeeLocation').val(employee.EmployeeDetailsInformation.AreaName);
            $('#EmployeeDepartment').val(employee.EmployeeDetailsInformation.ProjectName);
            $("#EmployeeImage").attr('src', "data:image/jpg;base64," + employee.EmployeeDetailsInformation.EmployeeImage);
        }
    }
    $('#EmployeeID').focus();
}

function getEmployeePfStatus(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetEmployeePfStatus';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;
}

function getPfWithdrawalPolicyInformation(identityCode, employeeId) {
    var employee = "";
    var url = '/Common/GetPfWithdrawalPolicy';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;
}

function getPfCalculationPolicy(identityCode) {
    var employee = "";
    var url = '/Common/GetPfCalculationPolicy';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode
        },
        success: function (data) {
            employee = data;
        },
        error: function () {
        }
    });
    return employee;
}

function GetTrialPeriodInformation(day) {
    var days = -1;
    var url = '/Common/GetTrialPeriodDate';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        global: false,
        async: false,
        data: {
            day: day
        },
        success: function (data) {
            days = data;
        },
        error: function () {
        }
    });
    return days;
}


function GetDaysInMonth() {

    var month = $('#Month').val();
    $.ajax({
        url: '/Salary_EmployeeWiseSalaryGeneration/GetDaysInMonth',
        type: 'get',
        async: false,
        data: {
            month: month
        },
        success: function (res) {
            var data = res;

            $("#DaysUpto").empty();
            $("#DaysUpto").get(0).options.length = 0;
            $("#DaysUpto").get(0).options[0] = new Option("-- Default --", "");
            if (data != null) {
                $.each(data, function (index, item) {
                    $("#DaysUpto").get(0).options[$("#DaysUpto").get(0).options.length] = new Option(item.Text, item.Value);
                });
            }
        },
        error: function () {
        }
    });
}

function GetWorkingDaysInformation() {

    var identityCode = $('#IdentityCode').val();
    var year = $('#Year').val();
    var month = $('#Month').val();
    var employeeId = $('#EmployeeID').val();

    if (identityCode != "" && employeeId != "" && year != "" && month != "0") {

        var url = '/Salary_EmployeeWiseSalaryGeneration/GetWorkingDays';

        $.ajax({
            url: url,
            method: 'get',
            data: {
                identityCode: identityCode,
                employeeId: employeeId,
                year: year,
                month: month
            },
            success: function (data) {
                if (data != null) {
                    $('#BaseWorkingDays').val(data.TotalWorkingDays);
                    $('#DaysUpto').val(data.EmployeeWorkingDays);
                }
            },
            error: function () {

            }
        });
    }

}

function GetApplicationTobeApproved() {
    var url = '/Dashboard/GetApplicationTobeApproved';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        global: false,
        data: {
        },
        success: function (data) {
            if (parseInt(data) > 0) {
                $("#badge_application_to_be_approvd").removeClass("collapse");
                $("#badge_application_to_be_approvd").text(data);
            } else {
                $("#badge_application_to_be_approvd").addClass("collapse");
            }

        },
        error: function () {
        }
    });
}

function GetEmployeeMinimumInTime(identityCode, employeeId, onDate) {
    var employeeInTime = null;
    var url = '/Common/GetEmployeeInTime';
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        global: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId,
            onDate: onDate
        },
        success: function (data) {
            employeeInTime = data;
        },
        error: function () {
        }
    });
    return employeeInTime;
}



function CheckForSelfServiceScreenAccess(identityCode, employeeId) {
    var url = '/Common/CheckSelfServiceScreenAccess';
    var canAccess;
    $.ajax({
        url: url,
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode,
            employeeId: employeeId
        },
        success: function (res) {
            canAccess = res;
            if (!canAccess) {
                ShowNotification(2, "Your are not authorized to view/update information for this employee.");
            }
        },
        error: function () {
        }

    });
    return canAccess;
}

function validateIndividualFieldManually(frmName, controlName, status) {
    if (!status) {
        $('#' + frmName).data('bootstrapValidator').updateStatus(controlName, 'NOT-VALIDATE').validateField(controlName);
    } else {
        $('#' + frmName).data('bootstrapValidator').updateStatus(controlName, 'VALID').validateField(controlName);
    }
};

function resetAllDropdown() {
    $('select').not('#IdentityCode', '#BaseIdentityCode').each(function () {
        this.selectedIndex = 0;
    });
}

function validateDatepickerFields(event) {
    var currentControlId = $(this).prop('id');
    if ($(this).closest('div').find('small').length > 0) {
        if ($('#' + $(this).closest('form').prop('id')).find('small').length === 0) {

        } else {
            //this is for textbox without calendar
            if ($('#' + $(this).closest('form').prop('id')).find('small').attr('data-bv-validator').length > 0) {
                var formId = $(this).closest('form').prop('id');
                $('#' + formId).bootstrapValidator('revalidateField', currentControlId);
            }
        }
    } else {
        if ($(this).parent('div').parent('div').find('small').length > 0) {
            if ($('#' + $(this).closest('form').prop('id')).find('small').length === 0) {

            }
            else {
                //this is for textbox with calendar
                if ($('#' + $(this).closest('form').prop('id')).find('small').attr('data-bv-validator').length > 0) {
                    $('#' + $('#' + (currentControlId)).closest('form').prop('id')).bootstrapValidator('revalidateField', currentControlId);
                }
            }
        }
    }
}


$('.datepicker-not-allow-futuredate,.datepicker-allow-futuredate,.datepicker').on("changeDate", validateDatepickerFields);

$('.datepicker-not-allow-futuredate,.datepicker-allow-futuredate,.datepicker').on('hide', function (e) {
    var stickyDate = $(this).data('stickyDate');

    if (!e.date && stickyDate) {
        $(this).datepicker('setDate', stickyDate);
        $(this).data('stickyDate', null);
    }
});


$('.datepicker-not-allow-futuredate,.datepicker-allow-futuredate,.datepicker').on('show', function (e) {
    if (e.date) {
        $(this).data('stickyDate', e.date);
    } else {
        $(this).data('stickyDate', null);
    }
});

function SetNextYearMonthFromMonthClosing(identityCode, yearControlId, monthControlId) {
    $.ajax({
        url: '/Pay/SalaryMonthClosing/GetLastMonthClosing',
        method: 'get',
        dataType: 'json',
        async: false,
        data: {
            identityCode: identityCode
        },
        success: function (res) {
            var clostingObject = {};

            if (!res) {
                var serverCurrentDate = GetServerDate();
                clostingObject.SalaryYear = serverCurrentDate.substring(7, 11);
                clostingObject.SalaryMonth = GetMonthNumber(serverCurrentDate.substring(3, 6));
            } else {
                clostingObject = res;
            }
            if (clostingObject.SalaryMonth == 12) {
                $('#' + yearControlId).val(clostingObject.SalaryYear + 1);
                $('#' + monthControlId).val("1");
            } else {
                $('#' + yearControlId).val(clostingObject.SalaryYear);
                $('#' + monthControlId).val(clostingObject.SalaryMonth + 1);
            }
        },
        error: function () {
        }

    });
}

function getCompanyStructure(identityCode) {
    var companyStructure = sessionStorage.getItem(SS_CompanyStructure);
    if (!companyStructure && identityCode) {
        $.ajax({
            url: '/Common/GetCompanyStructure',
            method: 'get',
            async: false,
            data: { companyId: identityCode },
            success: function (res) {
                sessionStorage.setItem(SS_CompanyStructure, res.CompanyStructure);
            },
            error: function () {
                ShowNotification(2, 'No Company Structure Found.');
            }
        });
    }
}

$('#AreaID').change(function () {
    if ($('#DivisionID').length > 0) {
        var companyCode = null;
        if ($('#BaseIdentityCode').length) {
            companyCode = $('#BaseIdentityCode').val();
        } else {
            companyCode = $('#IdentityCode').val();
        }
        getCompanyStructure(companyCode);
        var companyStructure = sessionStorage.getItem(SS_CompanyStructure);
        var indexOfLocation = companyStructure.toString().indexOf('1');
        var getNextString = companyStructure.toString().substring(indexOfLocation + 1, indexOfLocation + 2);
        if (getNextString == "2") {
            GetAreaWiseDivisions('DivisionID', companyCode, $(this).val(), true);
        }
        if (companyStructure.toString().indexOf('3') !== -1) {
            if ($('#ProjectID').length) {
                $('#ProjectID').empty();
                $("#ProjectID").get(0).options[0] = new Option("---- Select -----", "");
            }
        }
    }
});

$('#DivisionID').change(function () {
    if ($('#ProjectID').length > 0) {
        var companyCode = null;
        if ($('#BaseIdentityCode').length) {
            companyCode = $('#BaseIdentityCode').val();
        } else {
            companyCode = $('#IdentityCode').val();
        }
        getCompanyStructure(companyCode);
        var companyStructure = sessionStorage.getItem(SS_CompanyStructure);
        var indexOfLocation = companyStructure.toString().indexOf('2');
        var getNextString = companyStructure.toString().substring(indexOfLocation + 1, indexOfLocation + 2);
        if (getNextString == "3") {
            GetDivisionWiseProject('ProjectID', companyCode, $(this).val(), true);
        }
    }
});



