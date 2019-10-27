import { __decorate } from "tslib";
import { Component } from '@angular/core';
let VehicleAdd = class VehicleAdd {
    constructor(data, router) {
        this.data = data;
        this.router = router;
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
            maker: null,
        };
        this.newCar = {
            bodyType: "",
            doors: null,
            wheels: null,
            make: null,
            model: null,
            engine: ""
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
    }
    OnSubmit() {
        this.newCar.model = this.model;
        this.newCar.make = this.make;
        this.data.Submit(this.newCar)
            .subscribe(success => {
            if (success) {
                this.router.navigate(["/"]);
            }
        }, err => this.errorMessage = "Failed to save car");
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