var saveRegistration = function () {
    var name = $("#txtName").val();
    var address = $("#txtAddress").val();
    var city = $("#ddlCity").val();
    var mobileNo = $("#txtMobileNo").val();
    var emailid = $("#txtEmailId").val();

    var model = { Name: name, Address: address, City: city, MobileNo: mobileNo, EmailId: emailid };
    //model-array
    $.ajax({
        url: "/Registration/SaveRegistration",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (response) {
            alert(response.Message);

        }
    });

}