var InventoryArea = "/Inventory";
var FamArea = "/FAM";
var AttendanceArea = "/Attendance";
var EmployeeInfoArea = "/EmployeeInfo";
var LeaveArea = "/Leave";
var LoanArea = "/Loan";
var PayArea = "/Pay";
var PFArea = "/PF";
var Security = "/Security";
var TaxModule = "/Tax";
var Training = "/Training";

$(document)
    .ajaxStart(function () { ShowLoaderGlobal(); })
    .ajaxStop(function () { HideLoaderGlobal(); });
//(start) updated user activity time to get number of online user
//function updateUserActiviyWhenIdle() {
//    $.ajax({
//        url: '/Login/UpdateUserActivityTime',
//        timeout: 2500,
//        method: 'post',
//        global: false,
//        success: function () {
//            setTimeout(updateUserActiviyWhenIdle, 60000);

//        }
//    });
//}

//setTimeout(updateUserActiviyWhenIdle, 60000);
//end updating user activity

$('.decimal').on('keyup', function (e) {
    var ex = /^[0-9]+\.?[0-9]*$/;
    if (ex.test(this.value) == false) {
        this.value = this.value.substring(0, this.value.length - 1);
    }

});
$('.number').on('keyup', function (e) {
    var ex = /^[0-9]*$/;
    if (ex.test(this.value) == false) {
        this.value = this.value.substring(0, this.value.length - 1);
    }
});

$('.datepicker-not-allow-futuredate').prop('readonly', true);
$('.datepicker-not-allow-futuredate').datepicker({
    format: 'dd-M-yyyy',
    autoclose: true,
    todayBtn: 'linked',
    todayHightlight: true,
    endDate: "current"
});

$('.datepicker-allow-futuredate').prop('readonly', true);
$('.datepicker-allow-futuredate').datepicker({
    format: 'dd-M-yyyy',
    autoclose: true,
    todayBtn: 'linked',
    todayHightlight: true
});

$('.readonly-input').prop('readonly', true);
$('.disabled-input').prop('disabled', true);

$(function () {
    $('.datepicker').prop("readonly", true);
    $('.datepicker').datepicker({
        format: 'dd-M-yyyy',
        autoclose: true,
        todayBtn: 'linked',
        todayHightlight: true
    });
    var today = new Date();
    today.setDate(today.getDate());
});

function SearchStaff(controlId, nextCallFunction) {
    $('#SearchEmployeeModal2').modal('show');
    LoadSearchStaff(controlId, nextCallFunction);
}
function SearchEmployee(identityCode, controlId, nextCallFunction) {
    $('#SearchEmployeeModal2').modal('show');
    LoadSearchEmployee(identityCode, controlId, nextCallFunction);
}
function LoadSearchEmployee(identityCode, controlId, nextCallFunction) {
    var url = '/Common/LoadSearchEmployee';
    $('#Div-EmployeeList2').empty();
    $('#Div-EmployeeList2').load(url);
    $('#identityCode').val(identityCode);
    $('#nextId').val(controlId);
    $('#nextMethod').val(nextCallFunction);
}

function LoadSearchStaff(controlId, nextCallFunction) {
    var url = '/Home/LoadSearchEmployee';
    $('#Div-EmployeeList2').empty();
    $('#Div-EmployeeList2').load(url);
    $('#nextId').val(controlId);
    $('#nextMethod').val(nextCallFunction);

}

function SearchAsset(controlId, identitycode, nextCallFunction, searchType) {
    $('#SearchAssetName').modal('show');
    LoadSearchAsset(controlId, identitycode, nextCallFunction, searchType);
}

function LoadSearchAsset(controlId, identitycode, nextCallFunction, searchType) {
    var url = '/CommonAssetSearch/LoadSearchAsset';
    $('#Div-AssetList').empty().load(url);
    $('#SearchAssetName #nextId').val(controlId);
    $('#SearchAssetName #identityCode').val(identityCode);
    $('#SearchAssetName #nextMethod').val(nextCallFunction);
    $('#SearchAssetName #searchType').val(searchType);
}

//added by sohel ---start
function searchArea(controlId, identityCode, nextCallFunction) {
    $('#SearchAreaName').modal("show");
    loadSearchArea(controlId, identityCode, nextCallFunction);
}

function loadSearchArea(controlId, identityCode, nextCallFunction) {
    var url = '/Common/LoadSearchArea';
    $('#Div-AreaList').empty().load(url);
    $('#SearchAreaName #nextId').val(controlId);
    $('#SearchAreaName #identityCode').val(identityCode);
    $('#SearchAreaName #nextMethod').val(nextCallFunction);
}

function searchSupervivorForAppraisal(controlId, identityCode, nextCallFunction) {
    $('#SearchSupervisorName').modal("show");
    loadSupervivorForAppraisal(controlId, identityCode, nextCallFunction);
}

function loadSupervivorForAppraisal(controlId, identityCode, nextCallFunction) {
    var url = '/Common/LoadSupervivorForAppraisal';
    $('#Div-SupervisorList').empty().load(url);
    $('#SearchSupervisorName #nextId').val(controlId);
    $('#SearchSupervisorName #identityCode').val(identityCode);
    $('#SearchSupervisorName #nextMethod').val(nextCallFunction);
}


function SearchAccessory(controlId, identitycode, nextCallFunction) {
    $('#SearchAssetName').modal('show');
    LoadSearchAccessory(controlId, identitycode, nextCallFunction);
}

function LoadSearchAccessory(controlId, identitycode, nextCallFunction) {
    var url = '/CommonAssetSearch/LoadSearchAccessory';
    $('#Div-AssetList').empty().load(url);
    $('#SearchAssetName #nextId').val(controlId);
    $('#SearchAssetName #identityCode').val(identityCode);
    $('#SearchAssetName #nextMethod').val(nextCallFunction);
}

function SearchSupplier(controlId, identitycode, nextCallFunction) {
    $('#SearchSupplierName').modal('show');
    LoadSearchSupplier(controlId, identitycode, nextCallFunction);
}

function LoadSearchSupplier(controlId, identitycode, nextCallFunction) {
    var url = '/Common/LoadSearchSupplier';
    $('#Div-SupplierList').empty().load(url);
    $('#SearchSupplierName #nextId').val(controlId);
    $('#SearchSupplierName #identityCode').val(identityCode);
    $('#SearchSupplierName #nextMethod').val(nextCallFunction);
}

function SearchLease(controlId, identitycode, nextCallFunction) {
    $('#SearchLeaseModal').modal('show');
    LoadLeaseSupplier(controlId, identitycode, nextCallFunction);
}

function LoadLeaseSupplier(controlId, identitycode, nextCallFunction) {
    var url = '/Common/LoadLeaseSearch';
    $('#Div-LeaseList').empty().load(url);
    $('#SearchLeaseModal #nextId').val(controlId);
    $('#SearchLeaseModal #identityCode').val(identityCode);
    $('#SearchLeaseModal #nextMethod').val(nextCallFunction);
}

function SearchWorkOrder(controlId, identitycode, nextCallFunction) {
    $('#SearchWorkOrderName').modal('show');
    LoadSearchWorkOrder(controlId, identitycode, nextCallFunction);
}

function LoadSearchWorkOrder(controlId, identitycode, nextCallFunction) {
    var url = '/Common/LoadSearchWorkOrder';
    $('#Div-WorkOrderList').empty().load(url);
    $('#SearchWorkOrderName #nextId').val(controlId);
    $('#SearchWorkOrderName #identityCode').val(identityCode);
    $('#SearchWorkOrderName #nextMethod').val(nextCallFunction);
}
function InsuranceSearch(controlId, identitycode, nextCallFunction) {
    $('#SearchInsuranceModal').modal('show');
    LoadInsuranceSearch(controlId, identitycode, nextCallFunction);
}

function LoadInsuranceSearch(controlId, identitycode, nextCallFunction) {
    var url = '/Common/LoadInsuranceSearch';
    $('#Div-InsuranceList').empty();
    $('#Div-InsuranceList').load(url);
    $('#SearchInsuranceModal #nextId').val(controlId);
    $('#SearchInsuranceModal #identityCode').val(identityCode);
    $('#SearchInsuranceModal #nextMethod').val(nextCallFunction);
}

function searchEmployeeForAppraisal(controlId, identityCode, employeeType, appraisalPeriodId, nextCallFunction) {
    $('#SearchEmployeeNameForAppraisal').modal("show");
    loadSearchEmployeeForAppraisal(controlId, identityCode, employeeType, appraisalPeriodId, nextCallFunction);
}

function loadSearchEmployeeForAppraisal(controlId, identityCode, employeeType, appraisalPeriodId, nextCallFunction) {
    var url = '/Common/LoadSearchEmployeeForAppraisal';
    $('#Div-EmployeeListForAppraisal').empty().load(url);
    $('#SearchEmployeeNameForAppraisal #nextId').val(controlId);
    $('#SearchEmployeeNameForAppraisal #identityCode').val(identityCode);
    $('#SearchEmployeeNameForAppraisal #appraisalPeriodId').val(appraisalPeriodId);
    $('#SearchEmployeeNameForAppraisal #modalEmployeeType').val(employeeType);
    $('#SearchEmployeeNameForAppraisal #nextMethod').val(nextCallFunction);
}

function searchEmployee(controlId, identityCode, areaId, nextCallFunction) {
    $('#SearchEmployeeName').modal("show");
    loadSearchEmployeeWithArea(controlId, identityCode, areaId, nextCallFunction);
}

function loadSearchEmployeeWithArea(controlId, identityCode, areaId, nextCallFunction) {
    var url = '/Common/LoadSearchEmployeeWithArea';
    $('#Div-EmployeeList').empty().load(url);
    $('#SearchEmployeeName #nextId').val(controlId);
    $('#SearchEmployeeName #identityCode').val(identityCode);
    $('#SearchEmployeeName #modalAreaId').val(areaId);
    $('#SearchEmployeeName #nextMethod').val(nextCallFunction);
}

//end
function SearchProduct(controlId, identitycode, nextCallFunction) {
    $('#SearchProductName').modal('show');
    LoadSearchProduct(controlId, identitycode, nextCallFunction);
}

function LoadSearchProduct(controlId, identitycode, nextCallFunction) {

    var url = '/CommonProductSearch/LoadSearchProduct';
    $('#Div-ProductList').empty();
    $('#Div-ProductList').load(url);
    $('#SearchProductName #nextId').val(controlId);
    $('#SearchProductName #identityCode').val(identityCode);
    $('#SearchProductName #nextMethod').val(nextCallFunction);
}

function SearchProductForFixedAssetManagement(controlId, identitycode, isAccessory, isAsset, nextCallFunction) {
    $('#SearchAssetName').modal('show');
    LoadSearchProductForFixedAssetManagement(controlId, identitycode, isAccessory, isAsset, nextCallFunction);
}

function LoadSearchProductForFixedAssetManagement(controlId, identitycode, isAccessory,isAsset, nextCallFunction) {

    var url = '/CommonAssetSearch/ProductForFixedAssetManagement';
    $('#Div-AssetList').empty();
    $('#Div-AssetList').load(url);
    $('#SearchAssetName #nextId').val(controlId);
    $('#SearchAssetName #identityCode').val(identityCode);
    $('#SearchAssetName #isAccessory').val(isAccessory);
    $('#SearchAssetName #isAsset').val(isAsset);
    $('#SearchAssetName #nextMethod').val(nextCallFunction);
}




function SearchRoster(identityCode, controlId, nextCallFunction) {
    $('#SearchRosterModal').modal('show');
    LoadSearchRoster(identityCode, controlId, nextCallFunction);
}
function LoadSearchRoster(identityCode, controlId, nextCallFunction) {
    var url = '/Common/LoadSearchRoster';
    $('#Div-RosterList').empty();
    $('#Div-RosterList').load(url);
    $('#identityCode').val(identityCode);
    $('#nextId').val(controlId);
    $('#nextMethod').val(nextCallFunction);
}

function SearchAccountNumber(identityCode, controlId, nextCallFunction) {
    $('#SearchAccountNumber').modal('show');
    LoadSearchAccountNumber(identityCode, controlId, nextCallFunction);
}
function LoadSearchAccountNumber(identityCode, controlId, nextCallFunction) {
    var url = '/CommonAccountSearch/LoadSearchAccount';
    $('#Div-AccountList').empty();
    $('#Div-AccountList').load(url);
    $('#nextId').val(controlId);
    $('#nextMethod').val(nextCallFunction);
    $('#identityCode').val(identityCode);
}

function SearchLocation(controlId, identitycode, nextCallFunction) {
    $('#LocationModal').modal('show');
    LoadSearchLocation(identityCode, controlId, nextCallFunction);
}

function LoadSearchLocation(identityCode, controlId, nextCallFunction) {
    var url = '/CommonAssetSearch/LoadLocation';
    $('#modalLocations').empty();
    $('#modalLocations').load(url);
    $('#LocationModal #nextId').val(controlId);
    $('#LocationModal #identityCode').val(identityCode);
    $('#LocationModal #nextMethod').val(nextCallFunction);
}


