import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ILoginCredential } from '../login/login-credentials';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'my-auth-token'
    })
};

@Injectable({
  providedIn: 'root'
})
export class LoginService {
    apiUrl: string = 'http://localhost:9220/api/login/DoLogin';
    constructor(private http: HttpClient) { }

    DoLogin1(data: ILoginCredential): Observable<ILoginCredential> {
        alert(data.userName.toString());
        return this.http.post<ILoginCredential>(this.apiUrl, data)
            .pipe(map(user => {
                if (user) {
                    localStorage.setItem('currentUser', JSON.stringify(user));
                }
                alert(user.userName + '' + user.password);
                return user;
            }));
            
    }
}
