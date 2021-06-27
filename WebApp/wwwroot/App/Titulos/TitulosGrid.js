"use strict";
var TitulosGrid;
(function (TitulosGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    $("#GridView").DataTable();
})(TitulosGrid || (TitulosGrid = {}));
//# sourceMappingURL=TitulosGrid.js.map