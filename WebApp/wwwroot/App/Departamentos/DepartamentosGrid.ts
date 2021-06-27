namespace DepartamentosGrid {

    declare var MensajeApp;

    if (MensajeApp != "") {

        Toast.fire({
            icon: "success", title: MensajeApp
        })

    }


    $("#GridView").DataTable();

}