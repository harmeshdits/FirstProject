import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import 'rxjs/add/operator/map';

@Injectable()

export class HomeService {
    constructor(private _http: Http) {
        console.log('HomeService is initialized....');
    }

    getDashboardData() {
        const url = 'https://jsonplaceholder.typicode.com/posts';
        return this._http.get(url)
            .map((response:Response)=> response.json());
    }
}

