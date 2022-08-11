var deleteURL;
$(document).ready(function () {
    $(".deleteButton").click(function () {
        deleteURL = $(this).attr("silmeAction");
        $("#deleteModal").modal('show')
    });
});

function deleteRecord() {
    location.href = deleteURL;
}