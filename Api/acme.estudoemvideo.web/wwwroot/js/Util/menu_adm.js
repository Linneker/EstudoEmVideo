loadGrid();
function loadGrid() {
    $(document).ready(function () {
        $('#tbl_menus').DataTable({
            processing: true,
            language:
            {
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
            },
            columnDefs: [
                { "width": "5%", "targets": 0 },
                { "width": "5%", "targets": 1 },
                { "width": "7%", "targets": 2 },
                { "width": "18%", "targets": 3 },
                { "width": "20%", "targets": 4 },
                { "width": "5%", "targets": 5 },
                { "width": "5%", "targets": 6 },
                { "width": "5%", "targets": 7 },
                { "width": "25%", "targets": 8 }
            ],
            ordering: true,
            destroy: true,
            stateSave: true,
            scrollCollapse: true,
            paging: true
        });
        $('#tbl_menus_filter input').attr("placeholder", "Pesquisa");
        $('#tbl_menus').css("width", "100%");
        $("th").addClass("text-center");
        $("tbody").addClass("text-center");
        $("button").removeClass('dt-button');
    });
}

function open_modal_cadastro_menu(mdShow, dvModal) {
    $.ajax({
        url: "/Menu/Modal/ModalCadastroMenu",
        type: 'GET',
        dataType: 'html',
        success: function (h) {
            var elemento = '<div class="modal-header">'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_cadastro_menu">Cadastro de Menu</h4>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_cadastro_menu" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            abre_moda(elemento, dvModal, mdShow);

        }
    });
}

function add_menu() {

    var json = monta_json("INSERT", 'AE21B5AD-2124-4307-A44D-FB126C7046FB');
    var pms = document.getElementById("permissao_menu").getElementsByTagName("option");
    var tamanhoVetor = 0;
    var i;
    for (i = 0; i < pms.length; i++) {
        if (pms[i].selected === true) {
            tamanhoVetor++;
        }
    }
    var perms = [tamanhoVetor];
    var j = 0;
    for (i = 0; i < pms.length; i++) {
        if (pms[i].selected === true) {
            perms[j] = pms[i].value;
            j++;
        }
    }

    $.ajax({
        url: '/Menu/AddMenu',
        type: 'POST',
        data: {
            menuJson: json,
            listaPermissao: perms
        },
        dataType: 'html',
        success: function (h) {
            var objeto = JSON.parse(h);
            $("#md_mensagem_menu").modal("hide"); 
            console.log(json);
            if (objeto.erro) {
                swal(objeto.mensagem, {
                    icon: "error"
                });
            } else {
                swal(objeto.mensagem, {
                    icon: "success"
                }).then(_ => {
                    location.reload(); 
                });
            }
            
        },
        error: function (e) {
            $("#dv_mensagem_menu").html(e);
            $("#exibicao_mensagem").removeClass("alert-sucess");
            $("#exibicao_mensagem").addClass("alert-danger");
        }
    });
}

function monta_json(cadastro, id) {
    var json = "{";
    if (cadastro === "INSERT") {
        json += '"Nome": "' + $("#Nome").val() + '",'
            + '\n' + '"Caminho": "' + $("#Caminho").val() + '",'
            + '\n' + '"Descricao": "' + $("#Descricao").val() + '",'
            + '\n' + '"Icone": "' + $("#Icone").val() + '",'
            + '\n' + '"Posicao": ' + $("#Posicao").val() + ','
            + '\n' + '"MenuIdPai": "' + $("#MenuIdPai").val() + '"';
    } else if (cadastro === "ATUALIZAR") {
        json += '"Id": "' + id + '",'
            + "\n" + '"Nome": "' + $("#Nome").val() + '",'
            + '\n' + '"Caminho": "' + $("#Caminho").val() + '",'
            + '\n' + '"Descricao": "' + $("#Descricao").val() + '",'
            + '\n' + '"Icone": "' + $("#Icone").val() + '",'
            + '\n' + '"Posicao": ' + $("#Posicao").val() + ','
            + '\n' + '"MenuIdPai": "' + $("#MenuIdPai").val() + '",'
            + '\n' + '"Status": ' + $("#Status").val() + '';
    }

    json += "}";
    return json;
}

function open_modal_editar_menu(id) {
    $.ajax({
        url: "/Menu/Modal/ModalEditarMenu?id=" + id,
        type: 'GET',
        dataType: 'html',
        success: function (h) {
            console.log(h);
            var elemento = '<div class="modal-header">'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_edita_menu">Atualiza dados Menu</h4>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_cadastro_menu" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            // abre_moda(elemento, 'md_show_upd_menu', 'dv_modal_show_upd_menu');
            $("#md_show_upd_menu").modal("show");
            $("#dv_modal_show_upd_menu").html(elemento);
        }
    });
}

function open_modal_delete_menu(id) {
    $.ajax({
        url: "/Menu/Modal/ModalDeleteMenu?id=" + id,
        type: 'GET',
        dataType: 'html',
        success: function (h) {
            console.log(h);
            var elemento = '<div class="modal-header">'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_deletar_menu">Remove Menu</h4>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_delete_menu" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            // abre_moda(elemento, 'md_show_upd_menu', 'dv_modal_show_upd_menu');
            $("#md_show_delete_menu").modal("show");
            $("#dv_modal_show_delete_menu").html(elemento);
        }
    });
}

function remove_menu(id) {
    $.ajax({
        url: '/Menu/Delete?id=' + id,
        type: 'Delete',
        dataType: 'html',
        success: function (h) {
            var objeto = JSON.parse(h);
            console.log(objeto);
            console.log(objeto.mensagem);
            console.log(objeto["mensagem"]);
            $("#dv_mensagem_menu").html(objeto.mensagem);
            if (objeto.ret === 0) {
                $("#exibicao_mensagem_menu").removeClass("alert-sucess");
                $("#exibicao_mensagem_menu").addClass("alert-danger");
            } else {
                $("#exibicao_mensagem_menu").removeClass("alert-danger");
                $("#exibicao_mensagem_menu").addClass("alert-sucess");
            }
            $("#md_show_delete_menu").modal("hide");
            $("#md_mensagem_menu").modal("show");
            setTimeout(function () { $("#md_mensagem_menu").modal("hide"); }, 2500);
        },
        error: function (e) {
            $("#dv_mensagem_menu").html(e);
            $("#exibicao_mensagem_menu").removeClass("alert-sucess");
            $("#exibicao_mensagem_menu").addClass("alert-danger");
            $("#md_show_delete_menu").modal("hide");
            $("#md_mensagem_menu").modal("show");
            setTimeout(function () { $("#md_mensagem_menu").modal("hide"); location.reload(); }, 2500);
        }
    });
}

function atualizar_menu(id) {
    var json = monta_json("ATUALIZAR", id);
    var pms = document.getElementById("permissao_menu").getElementsByTagName("option");
    var tamanhoVetor = 0;
    var i;
    for (i = 0; i < pms.length; i++) {
        if (pms[i].selected === true) {
            tamanhoVetor++;
        }
    }
    var perms = [tamanhoVetor];
    var j = 0;
    for (i = 0; i < pms.length; i++) {
        if (pms[i].selected === true) {
            perms[j] = pms[i].value;
            j++;
        }
    }

    $.ajax({
        url: '/Menu/UpdateMenu',
        type: 'PUT',
        data: {
            menuJson: json,
            listaPermissao: perms
        },
        dataType: 'html',
        success: function (h) {
            var objeto = JSON.parse(h);
            console.log(objeto);
            $("#dv_mensagem_menu").html(objeto.Msg);
            if (objeto.sucesso === 0) {
                $("#exibicao_mensagem_menu").removeClass("alert-sucess");
                $("#exibicao_mensagem_menu").addClass("alert-danger");
            } else {
                $("#exibicao_mensagem_menu").removeClass("alert-danger");
                $("#exibicao_mensagem_menu").addClass("alert-sucess");
            }
            $("#md_show_upd_menu").modal("hide");
            $("#md_mensagem_menu").modal("show");
            setTimeout(function () { $("#md_mensagem_menu").modal("hide"); location.reload(); }, 2500);
        },
        error: function (e) {
            console.log(e);
            $("#dv_mensagem_menu").html(e);
            $("#exibicao_mensagem_menu").removeClass("alert-sucess");
            $("#exibicao_mensagem_menu").addClass("alert-danger");
            $("#md_mensagem_menu").modal("show");

            $("#md_show_upd_menu").modal("hide");
            $("#md_mensagem_menu").modal("show");
            setTimeout(function () { $("#md_mensagem_menu").modal("hide"); }, 2500);
        }
    });
}

function close_delete_menu() {
    $("#md_show_delete_menu").modal("hide");
}