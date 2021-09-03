function loadgrid_materia() {
    let url = ""
    let idTable =""
    let camposTabela [];
    console.log(camposTabela);
    var campos = montandoColuna(camposTabela);
    var columnsDef = montaColumnsDef();
    $(`#${idTable}`).DataTable({
        processing: true,
        ajax: url,
        columns: camposTabela,
        language: language_padrao(),
        // columnDefs: columnsDef,
        ordering: true,
        destroy: true,
        stateSave: true,
        scrollCollapse: true,
        paging: true
    });
    $(`#${idTable}_filter input`).attr("placeholder", "Pesquisa");
    $(`#${idTable}_filter`).addClass("d-flex justify-content-end");
    $(`#${idTable}`).css("width", "100%");
    $(`#${idTable}_paginate`).addClass("d-flex justify-content-end");
    $("th").removeClass("sorting_asc");
    $("th").addClass("text-center");
    $("tbody").addClass("text-center");
    $("button").removeClass('dt-button');
}
