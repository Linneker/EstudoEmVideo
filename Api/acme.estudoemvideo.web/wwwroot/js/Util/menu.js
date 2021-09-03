get_menu();
function get_menu() {

    $.ajax({
        url: '/Menu/GetMenuByPermissao',
        type: 'GET',
        dataType: 'html',
        success: function (h) {
            var objeto = JSON.parse(h);
            var contador = 0;
            document.getElementById("menu_principal").innerHTML += "<ul class=\"nav side-menu\">";
            for (var i = 0; i < objeto.length; i++) {
                if (objeto[i]["MenuIdPai"] === 'ae21b5ad-2124-4307-a44d-fb126c7046fb') {
                    if (objeto[i]["Caminho"] !== "") {
                        document.getElementById("menu_principal").innerHTML +=
                            "<li class=\"nav-item\"><a class=\"nav-link\" href=\"" + objeto[i]["Caminho"] + "\"><i class=\"" + objeto[i]["Icone"] + "\"></i>" + objeto[i]["Nome"] + "</a>"
                            + "</li>";
                    } else {
                    document.getElementById("menu_principal").innerHTML +=
                        "<li class=\"nav-item\">" +
                    "<a  class=\"nav-link collapsed\" href=\"#A" + objeto[i]["Id"].replaceAll("-","") + "\"  data-bs-toggle=\"collapse\" "
                    + "role=\"button\" aria-expanded=\"false\" aria-controls=\"A" + objeto[i]["Id"].replaceAll("-", "") +"\"> " +
                            "<i class=\"" + objeto[i]["Icone"] + "\"></i>" + objeto[i]["Nome"] + " <span class=\"fa fa-chevron-down\"></span></a>"
                    //+ "<div class=\"\" id=" + objeto[i]["Id"] + ">"
                    + "<div id=\"A" + objeto[i]["Id"].replaceAll("-", "") +"\" class=\"collapse multi-collapse py-2 collapse-inner rounded\">"
                    
                    + "</div>"
                    //+ "</div>"
                            + "</li>";
                    }
                } else {
                    try {
                        document.getElementById("A" + objeto[i]["MenuIdPai"].replaceAll("-", "")).innerHTML += "<div style=\"margin-left:20%;margin-top: -10%;margin-bottom: 10%;\"><a style=\"color:white; text-decoration: none;\" class=\"text-write collapse-item\" href=\"" + objeto[i]["Caminho"] + "\">" + objeto[i]["Nome"] +"</a></div>";
                    } catch (e) {
                        console.log(e);
                    }
                }
            }
           
            $("li").removeClass("active");
        },
        error: function (h) {
            console.log(h);
            $("#mdCarregando").modal('hide');
            document.getElementById("mensagem").innerHTML = 'Foram encontrados alguns problemas por favor entre em contato eisindico.acmesistemas.com.br/help ou ligue: (35) 99920-6354 !';
            document.getElementById("modalTitle").innerHTML = "Problema!";
            document.getElementById("botao").innerHTML = "<button class=\"btn btn-danger\" onclick=\"fechar_modal()\">OK</button>";
            $("#mdMensagem").modal('show');


        }
    });
}

function sair(login)
{
    $.ajax({
        url: '/Conta/Logout',
        type: 'POST',
        data: {
            login : login 
        },
        dataType: 'html',
        success: function (h) {
            console.log(h);
            voltar_para_login();
        }
    });
}
function voltar_para_login() {
    window.location.replace("/Conta/Login");
}
$('#index').click(function () {
    $.ajax({
        url: '/RedirecionamentoPagina/RedirectLogin',
        type: 'POST',
        dataType: 'html',
        success: function (h) {
            var msg = JSON.parse(h);
            window.location.replace(msg["msg"]);
        },
        error: function (h) {
            document.getElementById("mensagem").innerHTML = "Olá.<br/> Desculpe pelo transtorno, já estamos trabalhando para resolver. <br/>Obrigado pela compreenção!";
            document.getElementById("modalTitle").innerHTML = "Problema reportado";
            document.getElementById("botao").innerHTML = "<button class=\"btn btn-danger\" onclick=\"fechar_modal()\">OK</button>";
            $("#mdMensagem").modal('show');
            $("#mdCarregando").modal('hide');
            console.log(h);
        }
    });
});

