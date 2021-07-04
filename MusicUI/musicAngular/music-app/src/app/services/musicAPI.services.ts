import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { from, Observable } from 'rxjs';
import * as fromModels from '../models';
import { environment } from 'src/environments/environment';

@Injectable()
export class musicAPIService {
    
    sounds: fromModels.ISound [] = [];

    private baseURL = environment.apiUrl;

    constructor(private httpClient: HttpClient){

    }

    getSounds(): Observable<fromModels.ISound[]>{
        return this.httpClient.get<fromModels.ISound[]>
        (this.baseURL + 'Music/GetSounds', {withCredentials: true});
    }
}