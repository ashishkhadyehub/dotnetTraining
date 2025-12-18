$(document).ready(function () {
    $('#tableEmployees').DataTable({
        dom: 'lBfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print', 'colvis'
        ],
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": true
    });
});

//$(document).ready(function () {
//    $('#tableJobs,#tableApplications,#tableEnquiryData').DataTable({
//        dom: 'lBfrtip',
//        buttons: [
//            'copy', 'csv', 'excel', 'pdf', 'print', 'colvis'
//        ],
//        "scrollY": "450px",
//        "scrollCollapse": true,
//        "paging": true
//    });

//    $('#tableProjects').DataTable({

//        "scrollY": "450px",
//        "scrollCollapse": true,
//        "paging": true
//    });
//});
