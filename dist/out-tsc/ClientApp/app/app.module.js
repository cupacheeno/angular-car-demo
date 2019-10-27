import { __decorate } from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { VehicleMain } from './vehMain/VehicleMain.component';
import { VehicleType } from './vehicleType/vehicleType.component';
import { VehicleAdd } from './vehAdd/vehicleAdd.component';
import { VehicleSuccess } from './vehSuccess/vehicleSuccess.component';
import { DataService } from './shared/dataService';
import { RouterModule } from '@angular/router';
let routes = [
    { path: "", component: VehicleMain },
    { path: "Car", component: VehicleAdd },
    { path: "success", component: VehicleSuccess }
];
let AppModule = class AppModule {
};
AppModule = __decorate([
    NgModule({
        declarations: [
            AppComponent,
            VehicleType,
            VehicleMain,
            VehicleAdd,
            VehicleSuccess
        ],
        imports: [
            BrowserModule,
            FormsModule,
            HttpClientModule,
            RouterModule.forRoot(routes, {
                useHash: true,
                enableTracing: true
            })
        ],
        providers: [
            DataService
        ],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map