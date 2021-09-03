function open_cadastro_categoraia() {
    $.ajax({
        url: "/Categoria/ModalCadastraCategoria",
        type: 'GET',
        dataType: 'html',
        success: function (h) {
            console.log(h);
            var elemento = '<div class="modal-header">'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_cad_menu">Cadastro Categoria</h4>'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_cadastro_video" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            // abre_moda(elemento, 'md_show_upd_menu', 'dv_modal_show_upd_menu');
            $("#md_cad_categoria").modal("show");
            $("#dv_modal_show_cad_categoria").html(elemento);
        }
    });

}

function cadastro_categoria() {
    var nome = $("#nome_categoria").val();
    var tipo = $("#tipo_categoria").val();
   
    var formData = `{ "Nome": "${nome}","Tipo": ${tipo} }`;
    $.ajax({
        url: "/Categoria/Post",
        type: "POST",
        data: { json: formData },
        dataType: 'json',
        success: function (json) {
            if (json.codigo == 200)
            {
                swal({
                    title: `${json.status}!`,
                    text: `${json.mensagem}!`,
                    icon: "success",
                    button: "OK!",
                }).then((t) => {
                    location.reload();
                });
            }
            else {
                swal(`${json.status}!`, `${json.mensagem}!`, json.codigo == 500 ? "error" : "warning");

            }
            console.log(json);
        },
        error: function (erro) {
            console.log(erro);
        }
    });

    

}

function getCookie(name) {
    var value = "; " + document.cookie;
    var parts = value.split("; " + name + "=");
    if (parts.length == 2) return parts.pop().split(";").shift();
}

