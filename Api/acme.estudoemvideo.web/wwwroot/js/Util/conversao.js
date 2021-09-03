function convert_to_json(listElemento,listaNomeElemento,listaTipoElemento) {
    var length = listElemento.length;
    var json = "{";
    for (var i = 0; i < length; i++) {
        if (i + 1 === length) {
            json += "\"" + listaNomeElemento[i] + "\": " + (listaTipoElemento[i] === "String" ? "\"" + listElemento[i] + "\"" : listElemento[i]);
            json += "\n";
        } else {
            json += "\"" + listaNomeElemento[i] + "\": " + (listaTipoElemento[i] === "String" ? "\"" + listElemento[i] + "\"" : listElemento[i]);
            json += ",";
            json += "\n";
        }
    }
    json += "}";
    return json;
}

function convert_form_to_json(form) {
    console.log('ConvertFormToJSON invoked!');
    var array = jQuery(form).serializeArray();
    var json = {};

    jQuery.each(array, function () {
        json[this.name] = this.value || '';
    });

    console.log('JSON: ' + json);
    return json;
}

function convert_form_to_json_dois(nomeForm) {
    var formData = $("#" + nomeForm).serializeArray();
    var object = {};
    formData.forEach(function (value, key) {
        if (value.name != "__RequestVerificationToken") {
            object[value.name] = value.value;
        }
    });
    var objetoJson = JSON.stringify(object);
    return objetoJson;
}