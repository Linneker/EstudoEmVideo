function proximo_escola() {
    $("#nav-escola").removeClass("show");
    $("#nav-escola").removeClass("active");
    $("#nav-endereco-escola").removeClass("hide");
    $("#nav-endereco-escola").addClass("show");
    $("#nav-endereco-escola").addClass("active");
    $("#nav-escola-tab").removeClass("active");
    $("#nav-endereco-escola-tab").addClass("active");
}

function anterior_escola() {
    $("#nav-escola").addClass("show");
    $("#nav-escola").addClass("active");
    $("#nav-endereco-escola").addClass("hide");
    $("#nav-endereco-escola").removeClass("show");
    $("#nav-endereco-escola").removeClass("active");
    $("#nav-escola-tab").addClass("active");
    $("#nav-endereco-escola-tab").removeClass("active");
}

function salvar_escola() {
    var convertendo = convert_form_to_json($("#modal_cadastro_escola"));
    var elemento = convert_form_to_json_dois("modal_cadastro_escola");

    var nome = $("#nome_escola").val();
    var cnpj = $("#cnpj_escola").val().replaceAll(".", "").replaceAll("/", "").replaceAll("-","");
    var razao_social = $("#razao_social_escola").val();
    var cep = $("#cep_escola").val();
    var estado = $("#estado_escola").val();
    var cidade = $("#cidade_escola").val();
    var bairro = $("#bairro_escola").val();
    var rua = $("#rua_escola").val();
    var numero = $("#numero_escola").val();
    var complemento = $("#complemento_escola").val();
    var pais = "Brasil";

    var json = `{
	    "Nome":"${nome}",
	    "Cnpj":"${cnpj}",
        "EnderecoEscolas": [{
            "Numero" : ${numero},
            "Complemento": "${complemento}",
            "Endereco": {
                "Cep": "${cep}",
                "Pais": "${pais}",
                "Estado": "${estado}",
                "Cidade": "${cidade}",
                "Bairro": "${bairro}",
                "Rua": "${rua}"
            }
        }]
    }`;

    $.ajax({
        url: "/Escola/Post",
        type: "POST",
        data: {
            json: json
        },
        dataType: 'json',
        success: function (h) {
            $("#md_layout").modal('hide');
            if (h.codigo == 200) {     
                swal({
                    title: `${h.status}!`,
                    text: `${h.mensagem}!`,
                    icon: "success",
                    button: "OK!",
                }).then((t) => {
                    location.reload();
                });
            }
            else{
                swal({
                    title: `${h.status}!`,
                    text: `${h.mensagem}!`,
                    icon: "warning",
                    button: "OK!",
                }).then((t) => {
                });
            }
        },
        error: function(e){
            $("#md_layout").modal('hide');
            swal({
                title: `${h.status}!`,
                text: `${h.mensagem}!`,
                icon: "success",
                button: "OK!",
            }).then((t) => {
                location.reload();
            });
        }
    });
}