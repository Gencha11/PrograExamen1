"use strict";
var DepartamentosGrid;
(function (DepartamentosGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    $("#GridView").DataTable();
})(DepartamentosGrid || (DepartamentosGrid = {}));
//# sourceMappingURL=DepartamentosGrid.js.map