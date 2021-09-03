function cadastro_permissao_conta_padrao(contaId) {

    var arrayElemento = preenche_array_elemento_permissao_conta_padrao(contaId);
    var arrayNomeElemento = preenche_array_lista_nome_elemento_conta_padrao();
    var arrayTipoElemento = preenche_array_lista_tipo_elemento_conta_padrao()
    var elemento = false;
    var json = convert_to_json(arrayElemento, arrayNomeElemento, arrayTipoElemento);

    $.ajax({
        url: "/PermissaoConta/AddPadrao",
        type: "POST",
        data: {
            json: json
        },
        dataType: 'json',
        success: function (h) {
            console.log(h);
            elemento = h.permC !== 0 ? true : false;
        },
        error: function (h) {
            console.log(h);
        }
    });
    return elemento;
}

function preenche_array_elemento_permissao_conta_padrao(contaId) {

    var conta_id = contaId;

    var arrayElemento = [1];
    for (var i = 0; i < 1; i++) {

        switch (i) {
            case 0:
                arrayElemento[i] = conta_id;
                break;
        }
    }
    return arrayElemento;
}

function preenche_array_lista_nome_elemento_conta_padrao() {
    var arrayNomeElemento = [1];
    for (var i = 0; i < 1; i++) {

        switch (i) {
            case 0:
                arrayNomeElemento[i] = "ContaId";
                break;

        }
    }
    return arrayNomeElemento;
}

function preenche_array_lista_tipo_elemento_conta_padrao() {
    var arrayTipoElemento = [1];
    for (var i = 0; i < 1; i++) {
        arrayTipoElemento[i] = i === 3 ? "long" : "String";
    }
    return arrayTipoElemento;

}


function cadastro_permissao_conta() {

    var arrayElemento = preenche_array_elemento_permissao_conta();
    var arrayNomeElemento = preenche_array_lista_nome_elemento_conta();
    var arrayTipoElemento = preenche_array_lista_nome_elemento_conta()
    var elemento = false;
    var json = convert_to_json(arrayElemento, arrayNomeElemento, arrayTipoElemento);

    $.ajax({
        url: "/PermissaoConta/Add",
        type: "POST",
        data: {
            json: json
        },
        dataType: 'json',
        success: function (h) {
            console.log(h);
            elemento = h.permC !== 0 ? true : false;
        },
        error: function (h) {
            console.log(h);
        }
    });
    return elemento;
}

function preenche_array_elemento_permissao_conta() {

    var conta_id = $("#usuario").val();
    var permissaoId = $("#permissao").val();
    var permissaoValida = true;

    var arrayElemento = [3];
    for (var i = 0; i < 3; i++) {

        switch (i) {
            case 0:
                arrayElemento[i] = conta_id;
                break;
            case 1:
                arrayElemento[i] = permissaoId;
                break;
            case 2:
                arrayElemento[i] = permissaoValida;
                break;
        }
    }
    return arrayElemento;
}

function preenche_array_lista_nome_elemento_conta() {
    var arrayNomeElemento = [3];
    for (var i = 0; i < 3; i++) {

        switch (i) {
            case 0:
                arrayNomeElemento[i] = "ContaId";
                break;
            case 1:
                arrayNomeElemento[i] = "PermissaoId";
                break;
            case 2:
                arrayNomeElemento[i] = "PermissaoValida";
                break;

        }
    }
    return arrayNomeElemento;
}

function preenche_array_lista_tipo_elemento_conta() {
    var arrayTipoElemento = [3];
    for (var i = 0; i < 3; i++) {
        arrayTipoElemento[i] = i === 3 ? "long" : "String";
    }
    return arrayTipoElemento;

}

