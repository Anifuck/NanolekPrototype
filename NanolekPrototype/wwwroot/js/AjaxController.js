    function PostApi(url, idButton, controllerName, element, id) {
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


    function SendOnControl(id, controllerName,element) {
        PostApi("SendOnControlForm", "onControlButton", controllerName, element, id);
    }

    function SendOnApprove(id, controllerName, element) {
        PostApi("ApproveForm", "ApproveAndOnRevision", controllerName, element, id);
    }

