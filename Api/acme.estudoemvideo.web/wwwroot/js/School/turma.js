async function submit_default_substituto(oFormElement, complementoMensagem, metodo, mdShow, tela, url, idTable, camposTabela) {

    var formData = new FormData(oFormElement);

    let materias = $("#cad_turma_materia option:selected").map(function () {
        return `{"MateriaId" : "${this.value}"}`;
    }).get().join(", ");

    let professorEscola = $("#cad_turma_professor_escola option:selected").map(function () {
        return `{"ProfessorEscolaId" : "${this.value}"}`;
    }).get().join(", ");

    let turmaAluno = $("#cad_turma_alunos_escola option:selected").map(function () {
        return `{"AlunoEscolaId" : "${this.value}"}`;
    }).get().join(", ");
    let valor = $("#cad_turma_bimestre option:selected").map(function () {
        return `{"BimestreId" : "${this.value}"}`;
    }).get().join(", ");

    var json = `{
                    "Nome" : "${$("#cad_turma_nome").val()}",
                    "Periodo": ${$("#cad_turma_periodo").val()},
                    "EscolaId": "${$("#cad_turma_escola").val()}",
                    "SerieId": "${$("#cad_turma_serie").val()}",
                    "TurmaBimestres": [${valor}],
                    "TurmasAlunosEscolas": [${turmaAluno}],
                    "TurmaProfessorEscolas": [${professorEscola }],
                    "TurmaMaterias": [${materias}]
                }`;
    try {
        var cook = getCookie('RequestVerificationToken');
        $.ajax({
            url: '/Turma/Post',
            type: "POST",
            data: {
                json: json
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
                        //location.reload();
                        loadgrid_padrao(url, idTable, camposTabela);
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
                    title: `${h.status}!`,
                    text: `${h.mensagem}!`,
                    icon: "success",
                    button: "OK!",
                }).then((t) => {
                    location.reload();
                });
            }
        });
        //const response = await fetch(oFormElement.action, {
        //    method: metodo,
        //    headers: {
        //        'RequestVerificationToken': cook
        //    },
        //    body: json
        //}).then((e) => {
        //    if (e.ok) {
        //        swal(`${tela} ${complementoMensagem} Com Sucesso!`, {
        //            icon: "success"
        //        });
        //        loadgrid_padrao(url, idTable, camposTabela);
        //        $("#" + mdShow).modal('hide');
        //    } else {
        //        swal(`${tela} Não ${complementoMensagem}!`, {
        //            icon: "warning"
        //        });
        //    }

        //});
    } catch (error) {
        swal(`${tela} Não ${complementoMensagem}!`, {
            icon: "error"
        });
    }
}


function exibirProfessorluno() {
    var escolaId = $("#cad_turma_escola").val();
    if (escolaId == "") {
        $("#div_turma_professor_escola").addClass("visually-hidden");
        $("#div_turma_aluno_escola").addClass("visually-hidden");
        $("#div_turma_materia_professor").addClass("visually-hidden");
        return;
    }
    $.ajax({
        url: `/ProfessorEscola/GetProfessorEscolaByEscolaId?EscolaId=${escolaId}`,
        type: "GET",
        dataType: 'json',
        success: function (h) {

            $("#cad_turma_professor_escola").empty();
            if (h.$values.length == 0) {
                $("#div_turma_materia_professor").addClass("visually-hidden");
                swal({
                    title: `Professores não encontrados!`,
                    text: `Olá, selecione outra instituição, pois essa escola não possui Professores vinculados!`,
                    icon: "success",
                    button: "OK!",
                }).then((t) => {

                });
            }
            for (var i = 0; i < h.$values.length; i++) {
                $("#cad_turma_professor_escola").append(`<option value=${h.$values[i].Id}>${h.$values[i].Usuario.Nome}</option>`);
            }
            $("#div_turma_professor_escola").removeClass("visually-hidden");
        },
        error: function (h) {
            console.log(h);
            $("#md_layout").modal('hide');
            swal({
                title: `${h.status}!`,
                text: `${h.mensagem}!`,
                icon: "success",
                button: "OK!",
            }).then((t) => {
              
            });
        }
    });

    $.ajax({
        url: `/AlunoEscola/GetAlunosEscolaByEscolaId?escolaId=${escolaId}`,
        type: "GET",
        dataType: 'json',
        success: function (e) {
            $("#cad_turma_alunos_escola").empty();
            $("#cad_turma_materia").empty();
            for (var i = 0; i < e.$values.length; i++) {
                $("#cad_turma_alunos_escola").append(`<option value=${e.$values[i].Id}>${e.$values[i].Aluno.Nome}</option>`);
            }
            $("#div_turma_aluno_escola").removeClass("visually-hidden");
        },
        error: function (h) {
            console.log(h);
            $("#md_layout").modal('hide');
            swal({
                title: `${h.status}!`,
                text: `${h.mensagem}!`,
                icon: "success",
                button: "OK!",
            }).then((t) => {

            });
        }
    });
}

function exibirMateria() {
    var professorId = $("#cad_turma_escola").val();

    let professorEscola = $("#cad_turma_professor_escola option:selected").map(function () {
        return this.value;
    }).get().join(", ");

    $.ajax({
        url: `/Materia/GetMateriasByProfessorId?ProfessorId=${professorEscola}`,
        type: "GET",
        dataType: 'json',
        success: function (e) {
            $("#cad_turma_materia").empty();
            for (var i = 0; i < e.length; i++) {
                $("#cad_turma_materia").append(`<option value=${e[i].id}>${e[i].nome}</option>`);
            }
            $("#div_turma_materia_professor").removeClass("visually-hidden");
        },
        error: function (h) {
            console.log(h);
            $("#md_layout").modal('hide');
            swal({
                title: `${h.status}!`,
                text: `${h.mensagem}!`,
                icon: "success",
                button: "OK!",
            }).then((t) => {
            });
        }
    });
}