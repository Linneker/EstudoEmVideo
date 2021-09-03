function open_modal(url,type,titulo,md,dv_modal) {
    $.ajax({
        url: url,
        type: type,
        dataType: 'html',
        success: function (h) {
            console.log(h);
            var elemento = '<div class="modal-header">'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_estudo_em_video">' + titulo+'</h4>'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_estudo_em_video" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            // abre_moda(elemento, 'md_show_upd_menu', 'dv_modal_show_upd_menu');
            $("#md_default").modal("show");
            $("#dv_modal_show_default").html(elemento);
        }
    });

}

function open_modal_xg(url, type, titulo, md, dv_modal) {
    $.ajax({
        url: url,
        type: type,
        dataType: 'html',
        success: function (h) {
            console.log(h);
            var elemento = '<div class="modal-header">'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_estudo_em_video">' + titulo + '</h4>'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_estudo_em_video" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            // abre_moda(elemento, 'md_show_upd_menu', 'dv_modal_show_upd_menu');
            $("#" + md).modal("show");
            $("#" + dv_modal).html(elemento);
        }
    });

}
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

function estudo_em_video_montandoColuna(objeto) {
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

function loadgrid_padrao(url, idTable, camposTabela) {
    console.log(camposTabela);
    var campos = estudo_em_video_montandoColuna(camposTabela);
    var columnsDef = montaColumnsDef();
    $(`#${idTable}`).DataTable({
        processing: true,
        ajax: url,
        columns: camposTabela,
        language: language_padrao(),
        //columnDefs: columnsDef,
        ordering: true,
        destroy: true,
        stateSave: true,
        scrollCollapse: true,
        paging: true
    });
    //$(`#${idTable}_filter input`).attr("placeholder", "Pesquisa");
    //$(`#${idTable}`).css("width", "100%");
    //$("th").removeClass("sorting_asc");
    //$("th").addClass("text-center");
    //$("tbody").addClass("text-center");
    //$("button").removeClass('dt-button');

    $(`#${idTable}_filter input`).attr("placeholder", "Pesquisa");
    $(`#${idTable}_filter`).addClass("d-flex justify-content-end");
    $(`#${idTable}`).css("width", "100%");
    $(`#${idTable}_paginate`).addClass("d-flex justify-content-end");
    $("th").removeClass("sorting_asc");
    $("th").addClass("text-center");
    $("tbody").addClass("text-center");
    $("button").removeClass('dt-button');
}

function open_modal_padrao(url, dvModalOpen, mdShow, complementoModalId, tituloModal) {

    $.get(url, function (h) {
        var elemento = '<div class="modal-header">'
            + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
            + '\n' + '        <span aria-hidden="true">x</span>'
            + '\n' + '    </button>'
            + '\n' + '    <h4 class="modal-title" id="titulo_modal_' + complementoModalId + '">' + tituloModal + '</h4>'
            + '\n' + '</div>'
            + '\n' + '<div id="body_modal_' + complementoModalId + '" class="modal-body">'
            + '\n' + '' + h + ''
            + '\n' + '</div>';
        $("#" + dvModalOpen).html(elemento);
        $("#" + mdShow).modal('show');
    });

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
                    if (data.codigo!=200) {
                        swal(`${tituloModal} não removido!`, {
                            icon: "error"
                        });
                    } else {
                        loadgrid_padrao(urlDois, idTable, camposTabela);
                        swal({
                            title: data.status,
                            text: data.mensagem,
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

function getDataAtual() {
    // Obtém a data/hora atual
    var data = new Date();

    // Guarda cada pedaço em uma variável
    var dia = data.getDate();           // 1-31
    var dia_sem = data.getDay();            // 0-6 (zero=domingo)
    var mes = data.getMonth();          // 0-11 (zero=janeiro)
    var ano2 = data.getYear();           // 2 dígitos
    var ano4 = data.getFullYear();       // 4 dígitos
    var hora = data.getHours();          // 0-23
    var min = data.getMinutes();        // 0-59
    var seg = data.getSeconds();        // 0-59
    var mseg = data.getMilliseconds();   // 0-999
    var tz = data.getTimezoneOffset(); // em minutos

    // Formata a data e a hora (note o mês + 1)
    var str_data = ano4 + '-' + (mes + 1) + '-' + dia;
    return str_data;
}