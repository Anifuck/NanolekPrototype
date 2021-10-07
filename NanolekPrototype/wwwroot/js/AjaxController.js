function PostApi(url, controllerName, element, id) {
        $.post("/Form" + controllerName + "s/" + url + "/", { id: id })
            .done(function (data) {
                console.log(data);
                if (data["status"] == 1) {
                    $("#" + controllerName).text(data["protocolState"]);
                    while (element.firstChild) {
                        element.removeChild(element.firstChild);
                    };
                }
                else
                    alert("ошибка");
            }
            );
}


function PostApi2(url, controllerName, elementId, id) {
    var element = $("#" + elementId).parent();
    $.post("/Form" + controllerName + "s/" + url + "/", { id: id })
        .done(function (data) {
                console.log(data);
            if (data["status"] == 1) {
                PopUpHide();
                $("#" + controllerName).text(data["protocolState"]);
                for (var i = 0; i <= element.children().length; i++)
                    element.children()[0].remove();
            }
                else
                    alert("ошибка");
            }
        );
}


function SendOnControl(formId, controllerName, elementId) {
    PopUpShow("SendOnControlForm",formId, controllerName, elementId);
}

function SendOnApprove(formId, controllerName, elementId) {
    PopUpShow("ApproveForm", formId, controllerName, elementId);
}

function SendOnRevision() {
    alert("SendOnRevisionForm отработал");
    /*PopUpShow("SendOnRevisionForm", formId, controllerName, elementId);*/
}

function CheckPassword() {
    if ($("#passwordText").val() == "1") {
        var formId = $("#formId").val();
        var controllerName = $("#controllerName").val();
        var elementId = $("#elementId").val();
        var url = $("#url").val();
        PostApi2(url, controllerName, elementId, formId);
        $("#layoutBackground").css("pointer-events", "auto");
    } else {
        alert("Пароль неверный, попробуйте еще раз")
    }
}



//Функция отображения PopUp
function PopUpShow(url, formId, controllerName, elementId) {
    $(".popup-fade").css("display", "block");
    $("#popup").show();
    $("#formId").val(formId);
    $("#controllerName").val(controllerName);
    $("#elementId").val(elementId);
    $("#url").val(url);
    $("#layoutBackground").css("pointer-events", "none");
}

//Функция скрытия PopUp
    function PopUpHide() {
        $("#popup").hide();
        $("#formId").val("");
        $("#controllerName").val("");
        $("#elementId").val("");
        $("#url").val("");
        $("#passwordText").val("");
        $("#cause").val("");
        $("#layoutBackground").css("pointer-events", "auto");
        $(".popup-fade").css("display", "none");
    }
