CREATE TABLE [dbo].[Reservation] (
    [ReservationId]     INT             NOT NULL,
    [DateCreated]       DATE            NOT NULL,
    [ReservationCode]   NCHAR (20)      NULL,
    [ExternalCode]      NCHAR (20)      NULL,
    [ReservationStatus] VARCHAR (50)    NOT NULL,
    [MemberName]        VARCHAR (50)    NULL,
    [VehicalId]         NCHAR (20)      NULL,
    [Category]          VARCHAR(50)      NULL,
    [VehicalInfo]       VARCHAR (50)    NULL,
    [OwnerName]         VARCHAR (50)    NULL,
    [StartDate]         DATE            NULL,
    [StartTime]         DATETIME        NULL,
    [EndDate]           DATE            NULL,
    [EndTime]           DATETIME        NULL,
    [PickupLocation]    VARCHAR (50)    NULL,
    [TotalAmount]       DECIMAL (18, 2) NULL,
    [Balance]           DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([ReservationId] ASC)
	
	
	var SearchDataObj = [];
var SearchDataList = [];
var SS_ServerYear = 'ServerYear';
var SS_ServerDate = 'ServerDate';
var SS_CompanyStructure = null;
var companyStructure = null;

$(document).ready(function () {    
    //LoadLeaveApplication();

    $('#BtnSearch').click(function () {
        var title = "Data List";
        var fileName = "Data List";
        var column = [0, 1, 2, 3, 4, 5];
        var message = "Data List";
        var orientation = "portrait";
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

            "columns": [
                { "data": "ReservationId", "autowidth": true },
                { "data": "ReservationCode", "autowidth": true },
                { "data": "ExternalCode", "autowidth": true },
                { "data": "ReservationStatus", "autowidth": true },
                { "data": "MemberName", "autowidth": true },
                { "data": "VehicalId", "autowidth": true },
                { "data": "Category", "autowidth": true }

            ],
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
    });
   
});// end of document ready

function LoadApplicationGrid(data) {    
    
    //var columnsToBeExported = [1, 6, 7, 8, 9, 10, 11, 12];
    //MakePaginationWithExportEscapeSearchForGivenColumns('DataListTable', columnsToBeExported, [0, 1, 2, 3, 4, 5], "Leave Applications", "", "portrait", "SearchDataList");
    MakePagination('DataListTable')
}

function LoadApplication() {
   
    var result;
    $.ajax({
        url: '/Search/LoadData',
        method: 'get',
         
        success: function (data) {
            result = data;
            SearchDataList = [];            
            if (result != null) {
                if (result.length > 0) {
                    for (var i = 0; i < result.length; i++) {
                        var object = new Object();
                        object.ReservationId = result[i].ReservationId;
                        object.DateCreated = result[i].DateCreated;
                        object.ReservationCode = result[i].ReservationCode;
                        object.ExternalCode = result[i].ExternalCode;
                        object.ReservationStatus = result[i].ReservationStatus;
                        object.MemberName = result[i].MemberName;
                        object.VehicalId = result[i].VehicalId;
                        object.Category = result[i].Category;
                        object.VehicalInfo = result[i].VehicalInfo;
                        object.OwnerName = result[i].OwnerName;
                        object.StartDate = result[i].StartDate;
                        object.StartTime = result[i].StartTime;
                        object.EndDate = result[i].EndDate;
                        object.EndTime = result[i].EndTime;
                        object.PickupLocation = result[i].PickupLocation;
                        object.TotalAmount = result[i].TotalAmount;
                        object.Balance = result[i].Balance
                        SearchDataList.push(object);
                        LoadApplicationGrid(SearchDataList);
                        
                    };                    

                }
            }
            else {
                SearchDataList = [];
                LoadApplicationGrid(SearchDataList);
            }

        },
        error: function () {

        }
    });
}


//function MakePagination(tableId) {
//    alert('call1');
//    $('#' + tableId).dataTable({
//        "paging": true,
//        "ordering": true,
//        "info": true
//    });

//    //$('#' + tableId + '_filter').empty().append('<label><input type="search" placeholder="Search" class="form-control" aria-controls="' + tableId + '"></label>');
//}

function MakePaginationWithExport(tableId, column, title, message, orientation, fileName, pageLength, fixedColumn) {
    orientation = null ? "portrait" : orientation;
    pageLength = null ? "10" : pageLength;
    fixedColumn = null ? false : fixedColumn;
    $('#' + tableId).DataTable({
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



);

