import { Component, OnInit } from "@angular/core"
import { DataService } from '../shared/dataService';
import { VechType } from '../Shared/sharedTypes';
import { Router } from '@angular/router';

@Component({
    selector: "vehicle-types",
    templateUrl: "vehicleType.component.html",
    styleUrls :[]
})
export class VehicleType implements OnInit {

    constructor(private data: DataService, private router: Router) {
    }

    public selectedType: VechType;
    public vehicleTypes: VechType[] = []

    ngOnInit(): void {
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
}