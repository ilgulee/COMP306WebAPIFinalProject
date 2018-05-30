$(document).ready(function() {
    console.log("ready: jQuery");

    var url = $(location).attr("href").replace("index.html", "api/");
    
    $("#url,#urlPost,#urlPut,#urlDelete").empty().text(url);

  
    chooseAnchor();

    //interactive_call();
   
});

function chooseAnchor() {
    $("a").click(function() {
        var url = $(this).attr("title");
        $("#interactive").val(url);
    });
}

function interactive_call() {
    var url = $("#interactive").val() ;
    $("#interactive_name").text(url);
    $.ajax({
        type: "GET",
        dataType: "json",
        url: "api/"+url,
        success: function (result) {
            var output = JSON.stringify(result,undefined,5);
            console.info(output);
            $("#interactive_output").text(output);

        }
    });
}

function interactive_post() {
    var testCourse = {
       
        "Code": "Test-001",
        "Title": "Test Programming",
        "Location": "Test Progress Campus",
        "Semester": 7,
        "IsOpen": false,
        "Description": "Keep the order like POST->PUT->DELETE",
        "LectureHours": 10,
        "LabHours": 10
    }
    $.ajax({
        type: "POST",
        dataType: "json",
        url: "api/Courses",
        data: testCourse,
        success: function (result) {
            console.info(result);
        }
    });
}

function interactive_put() {
    var path = $("#interactivePut").val();
    var changedCourse = {
        "Code": "Updated Test-001",
        "Title": "Updated Test Programming",
        "Location": "Updated Test Progress Campus",
        "Semester": 8,
        "IsOpen": true,
        "Description": "Updated Keep the order like POST->PUT->DELETE",
        "LectureHours": 11,
        "LabHours": 11
    }
    $.ajax({
        type: "PUT",
        dataType: "json",
        url: "api/" + path,
        data: changedCourse,
        success: function () {
           console.info("Updated successfully");
        },
        error: function (xhr, thrownError) {
            console.info(xhr.status + " " + thrownError);
        }
    });
}

function interactive_delete() {
    var path = $("#interactiveDelete").val();
    $.ajax({
        type: "DELETE",
        dataType: "json",
        url: "api/"+path,
        success: function (result) {
            console.info(result);
            console.info("Deleted.");
        }
    });
}