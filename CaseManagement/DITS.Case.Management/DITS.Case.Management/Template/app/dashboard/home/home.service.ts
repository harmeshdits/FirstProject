import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import 'rxjs/add/operator/map';

@Injectable()

export class HomeService {
    constructor(private _http: Http) {
        console.log('HomeService is initialized....');
    }

    getDashboardData() {
        const url = 'http://localhost:7544/api/DashBoardAPI/GetTaskCompletedListInMonthsOneYear';
        return this._http.get(url)
            .map((response:Response)=> response.json());
    }
}

