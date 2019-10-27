import { __decorate } from "tslib";
import { Component } from "@angular/core";
let VehicleType = class VehicleType {
    constructor(data, router) {
        this.data = data;
        this.router = router;
        this.vehicleTypes = [];
    }
    ngOnInit() {
        this.data.loadVehicleTypes()
            .subscribe(success => {
            if (success) {
                this.vehicleTypes = this.data.vehicleTypes;
            }
        });
    }
    onSelection() {
        console.log(this.selectedType.name);
        //this.router.navigate([this.selectedType.name]);
        this.router.navigate(["Car"]);
    }
};
VehicleType = __decorate([
    Component({
        selector: "vehicle-types",
        templateUrl: "vehicleType.component.html",
        styleUrls: []
    })
], VehicleType);
export { VehicleType };
//# sourceMappingURL=vehicleType.component.js.map