var today = new Date().toISOString().split('T')[0];
document.getElementsByName("DateTB")[0].setAttribute('min', today);
if (getCookie("Role") == "Администратор" || getCookie("Check") == "true") {
    document.getElementById("BookButton").innerHTML = "View";
}
function СlickTable(innerHTML) {
    document.getElementById("BookButton").style.visibility = "visible";
    document.getElementById('LabelSelect').innerHTML = "You have chosen a table:" + innerHTML;
    document.getElementById('TableSelect').value = innerHTML;
}
function getCookie(name) {
    let matches = document.cookie.match(new RegExp(
        "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"
    ));
    return matches ? decodeURIComponent(matches[1]) : undefined;
}
function EditClick() {
    var checkedBoxes = document.querySelectorAll('input[name=a]:checked');
    var id = "";
    for (var i = 0; i < checkedBoxes.length; i++)
        id += checkedBoxes[i].id + ",";
    id = id.substring(0, id.length - 1);
    if (id != "") {
        $.ajax({
            type: "POST",
            url: "Main/Main",
            data: {
                ItemList: id,
                TableSelect: document.getElementById('TableSelect').value,
                DateTB: document.getElementById('DateTB').value
            }
        });
        alert("Devices updated successfully ");
    }
}
