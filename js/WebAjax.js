/*function GetUrlString() {
    var location = window.location.href;
    var urlParams = new URLSearchParams(window.location.search);
    alert(urlParams);
}*/

function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}
function SetCookies(id, value) {
    //SetCookies(int CookiesType, string value)
    $.ajax({
        type: "POST",
        url: "WebCache.asmx/SetCookies",
        data: "{'CookiesType':" + id + ",'value':'" + value + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
        },
        failure: function (msg) {
            alert('Error while loading categories.');
        }
    });

}

function GetCategories(value, CatName) {
    $.ajax({
        type: "POST",
        url: "WebCache.asmx/GetCategoryList",
        data: "{'LiesIn':" + value + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var Categories = response.d;
            debugger;
            if (value == 0) {
                $(".CatInfo").empty();
                $(".CatInfo").append("<li class='dropdown-header'>Categories</li> <li class='divider'></li>");
                for (var i = 0; i < Categories.length; i++) {
                    $(".CatInfo").append("<li><a href='#' onclick='GetCategories(" + Categories[i].catid + ",\"" + Categories[i].CategoryName + "\")'>" + Categories[i].CategoryName + "</a></li>")
                }
            }
            else {
                $('.CatData').empty();
                var table = "";
                table += "<table class='table table-striped table-hover table-condensed table-bordered'><tbody>";
                for (var i = 0; i < Categories.length; i++) {
                    table += "<tr><td><a href='#' onclick='GetCategories(" + Categories[i].id + ")'>" + Categories[i].CategoryName + "</a></td></tr>";
                }
                table += "</tbody></table>";
                $('.CatData').append(table);
                $('.catname').html(CatName);
                SetCookies(1, value);
            }
            //$('#output').empty();
            //$.each(cars, function(index, Categories) {
            //$('#output').append('<p><strong>' + Categories.catid + ' ' +
            //                    car.CategoryName + '</strong><br /> Year: ' +
            //                  car.LiesIn);
            //});

        },
        failure: function (msg) {
            alert('Error while loading categories.');
        }
    });
}

function GetSubCiti(value, CitiName) {
    $.ajax({
        type: "POST",
        url: "WebCache.asmx/GetCities",
        data: "{'LiesINValue':" + value + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            $('.citivalue').html(CitiName);

            SetCookies(2, value);
            /*var Cities = response.d;
            $(".Citilites").empty();
            $(".Citilites").append("<li class='dropdown-header'>Cities</li> <li class='divider'></li>");
            for (var i = 0; i < Cities.length; i++) {
            $(".Citilites").append("<li><a href='#' onclick='GetSubCiti(" + Cities[i].AreaID + ")'>" + Cities[i].AreaName + "</a></li>")
            }*/
        },
        failure: function (msg) {
            alert('Error while loading categories.');
        }
    });

}
function GetCities(value) {
    $.ajax({
        type: "POST",
        url: "WebCache.asmx/GetCities",
        data: "{'LiesINValue':" + value + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var Cities = response.d;
            $(".Citilites").empty();
            $(".Citilites").append("<li class='dropdown-header'>Cities</li> <li class='divider'></li>");
            for (var i = 0; i < Cities.length; i++) {
                $(".Citilites").append("<li><a href='#' onclick='GetSubCiti(" + Cities[i].AreaID + ",\"" + Cities[i].AreaName + "\")'>" + Cities[i].AreaName + "</a></li>")
            }
        },
        failure: function (msg) {
            alert('Error while loading categories.');
        }
    });
}

$(function () {
    $("body").niceScroll({ cursorborder: "", cursorcolor: "#737373", boxzoom: true, touchbehavior: true });
    $(".phone").mask("999-999-9999");
});

function ShowModalContent(PageURl, Header, Width, Height) {
    var ht = Height - 80;
    $('.modal-title').text(Header);
    $('.content').html('<object data="' + PageURl + '" width="100%" height="' + ht + '">');
    $('#myModal').modal('show');
    $('.modal-content').animate({ 'height': Height }, 1000);
    $('.modal-dialog').animate({ width: Width }, 1000);
    $('.content').css('overflow-x', 'auto');

}
function AlertMessage(Message, AlertMode) {
    if (AlertMode == 1) {
        $('#Message').removeClass().addClass("alert alert-danger");
        $('.Message').html("" + Message + "");
        $('#Message').css("display", "block");

    }
    else if (AlertMode == 2) {
        $('#Message').removeClass().addClass("alert alert-success");
        $('.Message').html("" + Message + "");
        $('#Message').css("display", "block");

    }

}

