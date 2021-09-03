function exibirEscola() {

    var el = document.getElementById("permissao_id_usuario")
    var opt = el.options[el.selectedIndex].text;

    var exibirEscola = (opt == "Aluno" || opt == "Professor" || opt == "Diretor");
    if (exibirEscola ) {
        $("#label_escola").removeClass("visually-hidden");
        $("#escola_professor").removeClass("visually-hidden");
        if (opt == "Aluno") {
            $("#escola_id_usuario_aluno").removeClass("visually-hidden");
            $("#exibir_escola_professor").addClass("visually-hidden");
            $("#exibir_materias_professor").addClass("visually-hidden");
            $("#materia_professor").addClass("visually-hidden");
            $("#label_materias").addClass("visually-hidden");

        } else if (opt == "Professor") {
            $("#materia_professor").removeClass("visually-hidden");
            $("#label_materias").removeClass("visually-hidden");

            $("#escola_id_usuario_professor").removeClass("visually-hidden");
            $("#exibir_escola_professor").removeClass("visually-hidden");
            $("#exibir_materias_professor").removeClass("visually-hidden");
            $("#escola_id_usuario_aluno").addClass("visually-hidden");
        } else {

        }
    } else {
        $("#label_escola").removeClass("visually-hidden");
        $("#escola_professor").removeClass("visually-hidden");
        $("#escola_id_usuario").removeClass("visually-hidden");
        $("#materia_professor").removeClass("visually-hidden");

        $("#label_escola").addClass("visually-hidden");
        $("#escola_professor").addClass("visually-hidden");
        $("#materia_professor").addClass("visually-hidden");
        $("#escola_id_usuario_professor").addClass("visually-hidden");
        $("#escola_id_usuario_aluno").addClass("visually-hidden");
        $("#exibir_escola_professor").addClass("visually-hidden");
        $("#exibir_materias_professor").addClass("visually-hidden");
        $("#label_materias").addClass("visually-hidden");

    }
}
function getListUsuario() {
    $ajax({
        type: "GET",
        url: "/User/Usuario",
        dataType: "JSON",
        contentType: "application/json; charset=utf-8",
        success: function (json) {

        },
        error: function (erro) {

        }
    });
}

function add() {

    var json = `{
                "Nome" : "${$("#nome_usuario").val()}",
                "Cpf": "${$("#cpf_usuario").val()}",
                "Email": "${$("#email_usuario").val()}",
                "Telefone":"${$("#telefone_usuario").val()}",
                "DataDeNascimento":"${$("#data_nascimento_usuario").val()}",
                "Contas": [{
                    "AlterarSenha": false,
                    "ContaAtiva": true,
                    "Login": "${$("#email_usuario").val()}",
                    "Logado": false,
                    "Senha": "${$("#senha_usuario").val()}",
                    "TermoDeAceite": ${$("#termo_de_aceite_usuario").prop('checked')},
                    "PermissoesContas": [{
                        "PermissaoId": "${$("#permissao_id_usuario").val()}",
                        "Add": ${$("#add_usuario").prop('checked')},
                        "Update":${$("#update_usuario").prop('checked')},
                        "Delete":${$("#delete_usuario").prop('checked')},
                        "Read":${$("#read_usuario").prop('checked')},
                        "PermissaoValida": ${$("#permissao_valida_usuario").prop('checked')},
                        "DataAtribuicao": "${getDataAtual()}"
                    }]
                 }]
            }`;
    console.log(json);

    var el = document.getElementById("permissao_id_usuario")
    var opt = el.options[el.selectedIndex].text;
    var idEscola = "";
    var idMateria = "";
    if (opt == "Aluno") {
        idEscola = document.getElementById("escola_id_usuario").value;
    } else if (opt == "Professor") {
        idEscola = $("#escola_id_usuario_professor option:selected").map(function () {
            return `${this.value}`;
        }).get().join(", ");
        idMateria = $("#materia_id_usuario_professor option:selected").map(function () {
            return `${this.value}`;
        }).get().join(", ");

    }
    $.ajax({
        url: "/Usuario/Cadastrar",
        type: "POST",
        data: {
            json: json,
            escolaId: idEscola,
            materiaId: idMateria
        },
        dataType: 'json',
        success: function (h) {
            console.log(h);
            $("#md_default").modal("hide");
            if (h.codigo == 200) {

                swal({
                    title: `${h.status}!`,
                    text: `${h.mensagem}!`,
                    icon: "success",
                    button: "OK!",
                }).then((t) => {
                    location.reload();
                });

            } else {
                swal({
                    title: `${h.status}!`,
                    text: `${h.mensagem}!`,
                    icon: "warning",
                    button: "OK!",
                }).then((t) => {
                });

            }
        },
        error: function (h) {
            console.log(h);
            $("#md_layout").modal('hide');
            swal({
                title: `Problema ao Cadastrar Usuario!`,
                text: `Houve alguns problemas, por favor entre em contato com suporte!`,
                icon: "error",
                button: "OK!",
            }).then((t) => {
                location.reload();
            });
        }
    });
    return elemento;
}

function getDataAtual() {
    var data = new Date();
    var dia = String(data.getDate()).padStart(2, '0');
    var mes = String(data.getMonth() + 1).padStart(2, '0');
    var ano = data.getFullYear();
    dataAtual = ano + '-' + mes + '-' + dia;
    console.log(dataAtual);
    return dataAtual;
}