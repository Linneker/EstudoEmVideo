function open_cadastro_categoraia() {
    $.ajax({
        url: "AutorizacaoApi/Modal/ModalCadastroAutorizacao",
        type: 'GET',
        dataType: 'html',
        success: function (h) {
            console.log(h);
            var elemento = '<div class="modal-header">'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_cad_autorizacao">Cadastro Autorizacao Api</h4>'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_cadastro_autorizacao_api" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            // abre_moda(elemento, 'md_show_upd_menu', 'dv_modal_show_upd_menu');
            $("#md_default").modal("show");
            $("#dv_modal_show_cad_autorizacao").html(elemento);
        }
    });

}

