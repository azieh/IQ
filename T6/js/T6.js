
function jsExample() {
    $("#jsExample").text('The fantastic javascript example');
}
function alertMe(i) {
    if (i == 5) {
        alert('five');
    } else {
        alert(i);
    } 
}

function loadList() {
    $(".theList").empty();
    for (i = 0; i < 10; i++) {
        newElem = $("<li><a href='#'>" + i + "</a></li>");
        newElem.click(function (x) {
            x = x.delegateTarget.childNodes[0].innerText;
            alertMe(x);
        });
        $(".theList").append(newElem);
    }
}

function setCloakTime() {
    var time = new Date();
    time = time.toLocaleDateString("en-US") + time.toLocaleTimeString("en-US");
    $("#clock").text(time);
}


function tooLong() {
    alert('you have now been on the page for half a minute');
}

jsExample();
setCloakTime();
setInterval(setCloakTime, 1000);
window.setTimeout(tooLong, 30000);