// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
async function submit_default(oFormElement, complementoMensagem, metodo, mdShow, tela, url, idTable, camposTabela) {
    var formData = new FormData(oFormElement);
    try {
        var cook = getCookie('RequestVerificationToken');
        const response = await fetch(oFormElement.action, {
            method: metodo,
            headers: {
                'RequestVerificationToken': cook
            },
            body: formData
        }).then((e) => {
            if (e.ok) {
                swal(`${tela} ${complementoMensagem} Com Sucesso!`, {
                    icon: "success"
                });
                loadgrid_padrao(url, idTable, camposTabela);
                $("#" + mdShow).modal('hide');
            } else {
                swal(`${tela} Não ${complementoMensagem}!`, {
                    icon: "warning"
                });
            }

        });
    } catch (error) {
        swal(`${tela} Não ${complementoMensagem}!`, {
            icon: "error"
        });
    }
}

function montandoColuna(objeto) {
    var montaObjeto = "";
    for (var i = 0; i < objeto.length; i++) {
        if (i + 1 == objeto.length) {
            montaObjeto += `{ data : "${objeto[i]}" }"`;
        } else {
            montaObjeto += `{ data : "${objeto[i]}" },"`;
        }
    }
    return montaObjeto;
}

function montaColumnsDef() {

    var objeto = [
        { "width": "20%", "targets": 0 }
    ];
    return objeto;
}

function loadgrid_padrao_site(url, idTable, camposTabela) {
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

function language_padrao() {
    return {
        "decimal": ",",
        "thousands": ".",
        "emptyTable": "Nenhum registro encontrado",
        "info": "Mostrando  _PAGE_  de _PAGES_ registros",
        "infoEmpty": "Mostrando 0 até 0 de 0 registros",
        "infoFiltered": "(Filtrados de MAX registros)",
        "infoPostFix": "",
        "infoThousands": ".",
        "lengthMenu": "_MENU_<br/></br><b></b>",
        "loadingRecords": "Carregando...",
        "processing": "",
        "zeroRecords": "Nenhum registro encontrado",
        "search": "",
        "paginate": {
            "next": "Próximo",
            "previous": "Anterior",
            "first": "Primeiro",
            "last": "Último"
        },
        "aria": {
            "sSortAscending": ": Ordenar colunas de forma ascendente",
            "sSortDescending": ": Ordenar colunas de forma descendente"
        }
    }
}

function getCookie(name) {
    var value = "; " + document.cookie;
    var parts = value.split("; " + name + "=");
    if (parts.length == 2) return parts.pop().split(";").shift();
}

function deletar_padrao(id, url, tituloModal, urlDois, idTable, camposTabela) {
    swal({
        title: "Você tem certeza?",
        text: `Você irá remover esse ${tituloModal}!`,
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                url: url,
                type: "DELETE",
                data: { id: id },
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    if (data.erro) {
                        swal(`${tituloModal} não removido!`, {
                            icon: "error"
                        });
                    } else {
                        loadgrid_padrao(urlDois, idTable, camposTabela);
                        swal({
                            title: data.titulo,
                            text: data.msg,
                            icon: "success"
                        });
                    }
                },
                error: function (retorno) {
                    swal(`${tituloModal} não removido!`, {
                        icon: "error"
                    });
                }
            });
        } else {
            swal(`${tituloModal} não removido!`, { icon: "error" });
        }
    });
}