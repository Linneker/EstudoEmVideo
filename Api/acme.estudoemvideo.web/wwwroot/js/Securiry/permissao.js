function cadastro_permissao() {

    var arrayElemento = preenche_array_elemento_permissao();
    var arrayNomeElemento = preenche_array_lista_nome_elemento();
    var arrayTipoElemento = preenche_array_lista_tipo_elemento_conta()
    var elemento = false;
    var json = convert_to_json(arrayElemento, arrayNomeElemento, arrayTipoElemento);

    $.ajax({
        url: "/Permissao/Post",
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
                title: `${h.status}!`,
                text: `${h.mensagem}!`,
                icon: "success",
                button: "OK!",
            }).then((t) => {
                location.reload();
            });
        }
    });
    return elemento;
}

function preenche_array_elemento_permissao() {

    var nome = $("#nome").val();
    var nivel = $("#nivel").val();

    var arrayElemento = [2];
    for (var i = 0; i < 2; i++) {

        switch (i) {
            case 0:
                arrayElemento[i] = nome;
                break;
            case 1:
                arrayElemento[i] = nivel;
                break;
        }
    }
    return arrayElemento;
}

function preenche_array_lista_nome_elemento() {
    var arrayNomeElemento = [2];
    for (var i = 0; i < 2; i++) {

        switch (i) {
            case 0:
                arrayNomeElemento[i] = "Nome";
                break;
            case 1:
                arrayNomeElemento[i] = "Nivel";
                break;
        }
    }
    return arrayNomeElemento;
}

function preenche_array_lista_tipo_elemento_conta() {
    var arrayTipoElemento = [2];
    for (var i = 0; i < 2; i++) {
        arrayTipoElemento[i] = i ===0  ? "String" : "long";
    }
    return arrayTipoElemento;

}