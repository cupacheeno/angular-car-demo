import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from 'rxjs';
import { map } from "rxjs/operators";
import { VechType, Make, Car } from "./sharedTypes";


@Injectable()
export class DataService {

    constructor(private http: HttpClient) { }

    public vehicleTypes: VechType[] = [];

    public makers: Make[] = [];

    public models = [];

    loadVehicleTypes(): Observable<boolean> {
        return this.http.get("/api/vehicle")
            .pipe(
                map((data: any[]) => {
                    this.vehicleTypes = data;
                    return true;
                }));
    }

    loadMakes(): Observable<boolean> {
        return this.http.get("/api/make")
            .pipe(
                map((data: any[]) => {
                    this.makers = data;
                    return true;
                }));
    }

    loadModel(): Observable<boolean> {
        return this.http.get("/api/model")
            .pipe(
                map((data: any[]) => {
                    this.models = data;
                    return true;
                }));
    }

    Submit(newCar) {
        return this.http.post("/api/cars", newCar).pipe(
            map(response => {
                return true;
            }));
    }
}