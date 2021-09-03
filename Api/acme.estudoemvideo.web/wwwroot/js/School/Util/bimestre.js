function add_bimestre() {
    //var json = convert_form_to_json($("#form_add_bimestre"));
    var json = convert_form_to_json_dois("form_add_bimestre");

    $.ajax({
        url: "/Bimestre/Post",
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
            else {
                swal({
                    title: `${h.status}!`,
                    text: `${h.mensagem}!`,
                    icon: "warning",
                    button: "OK!",
                }).then((t) => {
                });
            }
        },
        error: function (e) {
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