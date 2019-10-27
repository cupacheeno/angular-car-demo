export interface Make {
    makerId: string;
    name: string;
}

export interface Maker {
    makerId: string;
    name: string;
}

export interface Model {
    modelId: string;
    name: string;
    maker: Maker;
}

export interface Car {
    bodyType: string;
    doors: number;
    wheels: number;
    id: string;
    make: Make;
    model: Model;
    engine: string;
    salePrice: number;
}

export interface VechType {
    name: string;
}

