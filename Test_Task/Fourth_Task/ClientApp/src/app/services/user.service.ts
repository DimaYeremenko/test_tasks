import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from "../models/user";

@Injectable()
export class UserService {

  private url = "/api/test";
 
    constructor(private http: HttpClient) {
    }

  public getAll(){
    return this.http.get(this.url);
  }

  public getAllByName(name:string){
    return this.http.get(this.url + '/' + name);
  }

  public update(user: User) {  
    return this.http.put(this.url + '/' + user.id, user).subscribe(
      (r)=>{},
      (e) => {}
    );
}
}
