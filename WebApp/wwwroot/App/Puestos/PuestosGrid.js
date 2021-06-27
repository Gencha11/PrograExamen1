"use strict";
var PuestosGrid;
(function (PuestosGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    $("#GridView").DataTable();
})(PuestosGrid || (PuestosGrid = {}));
//# sourceMappingURL=PuestosGrid.js.map