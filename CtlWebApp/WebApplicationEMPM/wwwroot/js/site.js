$(document).ready(function () {
    var i = 1;
    $('#add').click(function () {
        i++;
        $('#dynamic_field').append('<tr id="row' + i + '"><td><input type="text" class="form-control name_list" /></td><td><input type="text" class="form-control name_list" /></td><td><input type="text" class="form-control name_list" /></td><td><input type="text" class="form-control name_list" /></td><td><input type="text" class="form-control name_list" /></td><td><select class="form-control form-control-sm" asp-for="Education" asp-items="Html.GetEnumSelectList<CtlWebApp.Contract.Educatuions>()"></select></td></tr>');
                         
    });
});

$(document).ready(function () {
    $(".example1").pDatepicker({
        initialValueType: "gregorian",
        format: "YYYY/MM/DD",
        onSelect: "year"
    });
});
