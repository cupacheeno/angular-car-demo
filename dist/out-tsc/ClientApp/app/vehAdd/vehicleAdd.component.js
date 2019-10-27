import { __decorate } from "tslib";
import { Component } from '@angular/core';
let VehicleAdd = class VehicleAdd {
    constructor(data) {
        this.data = data;
        this.errorMessage = "";
        this.creds = {
            username: "",
            password: ""
        };
        this.makers = [];
        this.models = [];
        this.make = {
            makerId: "",
            name: ""
        };
        this.model = {
            modelId: "",
            name: "",
            maker: "",
        };
    }
    ngOnInit() {
        this.data.loadMakes()
            .subscribe(success => {
            if (success) {
                this.makers = this.data.makers;
            }
        });
        this.data.loadModel()
            .subscribe(success => {
            if (success) {
                this.models = this.data.models;
            }
        });
    }
    SetModel() {
        console.log(this.make.makerId);
        var tempId = this.makers.find(mak => mak.name == this.make.makerId).makerId;
        console.log(tempId);
        this.models.find(mod => mod.Maker.makerId == tempId);
    }
};
VehicleAdd = __decorate([
    Component({
        selector: 'vehicle-add',
        templateUrl: "./VehicleAdd.component.html",
        styles: []
    })
], VehicleAdd);
export { VehicleAdd };
//# sourceMappingURL=vehicleAdd.component.js.map