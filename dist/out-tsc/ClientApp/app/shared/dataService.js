import { __decorate } from "tslib";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
let DataService = class DataService {
    constructor(http) {
        this.http = http;
        this.vehicleTypes = [];
        this.makers = [];
        this.models = [];
    }
    loadVehicleTypes() {
        return this.http.get("/api/vehicle")
            .pipe(map((data) => {
            this.vehicleTypes = data;
            return true;
        }));
    }
    loadMakes() {
        return this.http.get("/api/make")
            .pipe(map((data) => {
            this.makers = data;
            return true;
        }));
    }
    loadModel() {
        return this.http.get("/api/model")
            .pipe(map((data) => {
            this.models = data;
            return true;
        }));
    }
};
DataService = __decorate([
    Injectable()
], DataService);
export { DataService };
//# sourceMappingURL=dataService.js.map