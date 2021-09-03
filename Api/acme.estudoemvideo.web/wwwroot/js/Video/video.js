function dataGridElement() {

}
function open_modal_cadastro() {
    $.ajax({
        url: "/Video/Modal/ModalCadastroVideo",
        type: 'GET',
        dataType: 'html',
        success: function (h) {
            console.log(h);
            var elemento = '<div class="modal-header">'
                + '\n' + '    <h4 class="modal-title" id="titulo_modal_cad_menu">Cadastro Video</h4>'
                + '\n' + '    <button type="button" class="close" data-dismiss="modal" aria-label="Close">'
                + '\n' + '        <span aria-hidden="true">×</span>'
                + '\n' + '    </button>'
                + '\n' + '</div>'
                + '\n' + '<div id="body_modal_cadastro_video" class="modal-body">'
                + '\n' + '' + h + ''
                + '\n' + '</div>';
            // abre_moda(elemento, 'md_show_upd_menu', 'dv_modal_show_upd_menu');
            $("#md_default").modal("show");
            $("#dv_modal_show_default").html(elemento);
        }
    });
}



function carregar(e) {

    //if ($("#condominio_nome").val() === "" || $("#condominio_nome").val() === undefined) {
    //    $("#condominio_cadastro_logo").val("");
    //    $("#imagem_apos_load").val("");
    //    mostra_alerta_condominio("Nome do condominio não inserido", "waning");
    //    return;
    //}
    var formData = new FormData();
    formData.append("logo", $('#condominio_cadastro_logo')[0].files[0]);

    $.ajax({
        url: "/Video/UploadVideo",
        data: formData,
        type: "POST",
        contentType: false,
        processData: false,
        success: function (retorno) {
            var elemento = `<div class="right col-sm-3 text-center exibindo-logo">
                <button type="button" class="close" onclick="deletar_logo()">
                   <span>&times;</span>
                </button>
                <label>${retorno.mensagem}</label>
                </div>`;
            $("#imagem_apos_load").html(elemento);
        }
    });


    return false;
    //$("#submit_logo").click(); 
}

async function AJAXSubmit(oFormElement) {

    var nomeArquivo = `${$("#nome").val()}.mp4`;
    var descricao = $("#descricao").val();
    var categoriaVideo = $("#categoria_id_video").val();

    //oFormElement[0].files[0].name = nomeArquivo;

    //if (nomeArquivo != oFormElement[0].files[0].name) {
    //    oFormElement[0].files[0].name(nomeArquivo);
    //    console.log(oFormElement[0].files[0].name);
    //}   

    var formData = new FormData(oFormElement);

    try {
        var cook = getCookie('RequestVerificationToken');
        const response = await fetch(oFormElement.action, {
            method: 'POST',
            headers: {
                'RequestVerificationToken': cook,
                'descicaoVideo': descricao,
                'nome': nomeArquivo,
                'categoriaidvideo': categoriaVideo
            },
            body: formData
        }).then((e) => {
            e.json().then(function (json) {
                if (json.codigo == 200) {
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
            })
        });
    
        console.log(response);
        console.log('Result: ' + response.status + ' ' + response.statusText);
    } catch (error) {
        console.log('Error:', error);
    }
}

function getCookie(name) {
    var value = "; " + document.cookie;
    var parts = value.split("; " + name + "=");
    if (parts.length == 2) return parts.pop().split(";").shift();
}


function delete_video(id){
    swal({
        title: "Tem certeza?",
        text: "Deseja realmente remover esse vídeo!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
        .then((willDelete) => {
            if (willDelete) {
                $.ajax({
                    url: `Delete?id=${id}`,
                    type: "DELETE",
                    data: { id: id },
                    dataType: 'json',
                    success: function (json) {
                        if (json.codigo == 200) {
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
                    error: function (e) {
                        console.log(e);
                    }
                });


            } else {
                swal("Ufa... Essa foi por pouco, remoção não efetuada!");
            }
        });
}