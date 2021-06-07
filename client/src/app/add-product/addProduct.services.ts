import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Product, Product_Phone, Product_Audio, Product_Appliance } from './model';

@Injectable({
    providedIn: 'root',
})

export class AddProductService {
    private urlAPI = 'https://localhost:44372';
    constructor(private http: HttpClient) { }

    public addProduct = async (product: Product) => {
        try {
            const loginUrl = `${this.urlAPI}/api/SanPhams`;
            console.log(product);
            return await this.http.post(loginUrl, product).toPromise();
        }
        catch (error) {
            console.log(error);
            return error;
        }
    }
    // tslint:disable-next-line:variable-name
    public addProduct_DienThoai = async (productdetail: Product_Phone) => {
        try {
            const loginUrl = `${this.urlAPI}/api/SanPham_DienThoai`;
            console.log(productdetail);
            return await this.http.post(loginUrl, productdetail).toPromise();
        }
        catch (error) {
            console.log(error);
            return error;
        }
    }

    // tslint:disable-next-line:variable-name
    public addProduct_Audio = async (productdetail: Product_Audio) => {
        try {
            const loginUrl = `${this.urlAPI}/api/SanPham_Audio`;
            console.log(productdetail);
            return await this.http.post(loginUrl, productdetail).toPromise();
        }
        catch (error) {
            console.log(error);
            return error;
        }
    }

    // tslint:disable-next-line:variable-name
    public addProduct_Appliance = async (productdetail: Product_Appliance) => {
        try {
            const loginUrl = `${this.urlAPI}/api/SanPham_Appliance`;
            console.log(productdetail);
            return await this.http.post(loginUrl, productdetail).toPromise();
        }
        catch (error) {
            console.log(error);
            return error;
        }
    }
}
