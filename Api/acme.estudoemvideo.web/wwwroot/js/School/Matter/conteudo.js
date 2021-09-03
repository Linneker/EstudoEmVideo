function submit_default_conteudo(oFormElement, complementoMensagem, metodo, mdShow, tela, url, idTable, camposTabela) {
    let json = `{
            "Nome": "${$("#conteudo_nome").val()}",
            "Descricao": "${$("#conteudo_descricao").val()}",
            "ConteudosMaterias": [{
                "MateriaId": "${$("#conteudo_materia").val()}",
                "DataAtribuicao": "${getDataAtual()}"
            }]
        }`; try {

        var cook = getCookie('RequestVerificationToken');

        $.ajax({
            url: "/Conteudo/Post",
            type: 'POST',
            headers: {
                'RequestVerificationToken': cook
            },
            dataType: 'json',
            data: {
                json: json
            },
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
                else {
                    swal({
                        title: `${h.status}!`,
                        text: `${h.mensagem}!`,
                        icon: "warning",
                        button: "OK!",
                    }).then((t) => {
                    });
                }
            }
        });
    } catch (error) {
        swal(`${tela} Não ${complementoMensagem}!`, {
            icon: "error"
        });
    }

}