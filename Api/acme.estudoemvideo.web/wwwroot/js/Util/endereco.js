$("#cep_escola").blur(function () {
    console.log();
    $("#rua_escola").val("...");
    $("#bairro_escola").val("...");
    $("#cidade_escola").val("...");
    $("#estado_escola").val("...");
    $.get('/Endereco/GetEnderecoByCep', { cep: this.value },
        function (data) {
            var json = JSON.parse(data);
            console.log(json.length == 0);
            if (json.length == 0) {

                //Nova variável "cep" somente com dígitos.
                var cep = $("#cep_escola").val().replace("-", "");

                //Verifica se campo cep possui valor informado.
                if (cep != "") {

                    //Expressão regular para validar o CEP.
                    var validacep = /^[0-9]{8}$/;

                    //Valida o formato do CEP.
                    if (validacep.test(cep)) {

                        //Preenche os campos com "..." enquanto consulta webservice.


                        //Consulta o webservice viacep.com.br/
                        $.getJSON(`https://viacep.com.br/ws/${cep}/json`, function (dados) {

                            if (!("erro" in dados)) {
                                //Atualiza os campos com os valores da consulta.
                                $("#rua_escola").val(dados.logradouro);
                                $("#bairro_escola").val(dados.bairro);
                                $("#cidade_escola").val(dados.localidade);
                                $("#estado_escola").val(dados.uf);
                            } //end if.
                            else {
                                //CEP pesquisado não foi encontrado.
                                limpa_formulário_cep();
                                swal("CEP não encontrado!", {
                                    icon: "error"
                                });
                            }
                        });
                    } //end if.
                    else {
                        //cep é inválido.
                        limpa_formulário_cep();
                        swal("Formato de CEP inválido!", {
                            icon: "error"
                        });
                    }
                } //end if.
                else {
                    //cep sem valor, limpa formulário.
                    limpa_formulário_cep();
                }
            } else {
                $("#rua_escola").val(json[0].Rua);
                $("#bairro_escola").val(json[0].Bairro);
                $("#cidade_escola").val(json[0].Cidade);
                $("#estado_escola").val(json[0].Estado);
            }
        }
    )
});

function limpa_formulario_cep(){
    $("#rua_escola").val("");
    $("#bairro_escola").val("");
    $("#cidade_escola").val("");
    $("#estado_escola").val("");
}