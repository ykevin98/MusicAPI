import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { from, Observable } from 'rxjs';
import * as fromModels from '../models';
import { environment } from 'src/environments/environment';

@Injectable()
export class musicAPIService {
    
    sounds: fromModels.ISound [] = [];
    menuItems: fromModels.IMenuItems[] = [];
    user: fromModels.IUser = {
        Id: 0,
        firstName: '',
        lastName: '',
        userName: '',
        Age: -1
    };

    private baseURL = environment.apiUrl;

    constructor(private httpClient: HttpClient){

    }

    getSounds(): Observable<fromModels.ISound[]>{
        return this.httpClient.get<fromModels.ISound[]>
        (this.baseURL + 'Music/GetSounds', {withCredentials: true});
    }

    getMenuItems(): Observable<fromModels.IMenuItems[]>{
        return this.httpClient.get<fromModels.IMenuItems[]>
        (this.baseURL + 'Music/GetMenuItems', {withCredentials: true});
    }

    getUser(): Observable<fromModels.IUser>{
        return this.httpClient.get<fromModels.IUser>
        (this.baseURL + 'Music/GetUser' + '?userName=TestUser123', {withCredentials: true});
    }
}