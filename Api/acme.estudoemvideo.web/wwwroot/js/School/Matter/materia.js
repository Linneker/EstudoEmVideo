function loadgrid_materia_23() {
    let url = "/Materia/GetDadosTable";
    let idTable = "tabela_materia";
    var columnsDef = montaColumnsDef();
    $(`#${idTable}`).DataTable({
        processing: true,
        ajax: url,
        columns: [
            { data: 'nome' },
            { data: 'dataCriacao' },
            {
                data: 'status',
                render: function (data, type) {
                    if (data === 0) { return 'Ativo'; }
                    if (data === 1) { return 'Inativo'; }
                }
            },
            {
                data: 'botaoEditarDeletarVisualizar'
            }],
        language: language_padrao(),
        columnDefs: columnsDef,
        ordering: true,
        destroy: false,
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
