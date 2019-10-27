import { Component, OnInit } from '@angular/core';
import { Make, Car, Model } from '../Shared/sharedTypes';
import { DataService } from '../shared/dataService';
import { Router } from '@angular/router';

@Component({
    selector: 'vehicle-add',
    templateUrl: "./VehicleAdd.component.html",
    styles: []
})
export class VehicleAdd implements OnInit {

    constructor(private data: DataService, private router: Router) {
    }

    errorMessage: string = "";
    public creds = {
        username: "",
        password: ""
    };

    public makers: Make[] = [];
    public models = [];

    public make: Make = {
    makerId: "",
    name: ""
    };
    public model : Model = {
        modelId: "",
        name: "",
        maker: null,
    };

    public newCar = {
        bodyType: "",
        doors: null,
        wheels: null,
        make: null,
        model: null,
        engine: ""};

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

        this.newCar.model = this.model
        this.newCar.make = this.make;

        this.data.Submit(this.newCar)
            .subscribe(success => {
                if (success) {
                    this.router.navigate(["/"]);
                }
            }, err => this.errorMessage = "Failed to save car");
    }
}