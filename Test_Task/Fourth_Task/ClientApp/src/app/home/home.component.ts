import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { FormControl } from '@angular/forms';
import { User } from '../models/user';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  
  public users = [];
  private _users = [];

  public searchNameControl:FormControl;

  constructor(private _userService:UserService){

  }

  ngOnInit(): void {
    this._userService.getAll().subscribe((r) => {

      if(r === null || r === undefined){
        this._users = [];
      }
      else{
        this._users = r as User[];
      }
      this.users = this._users;
    });

    this.searchNameControl = new FormControl();
    this.searchNameControl.valueChanges.subscribe((value) => {
      // this.users = this._users.filter((user, index)=>{
      //   return user.name.startsWith(value);
      // })

      this._userService.getAllByName(value).subscribe((r) => {

        if(r === null || r === undefined){
          this.users = [];
        }
        else{
          this.users = r as User[];
        }
      });
    });
  }

  update(user : User) : void{
    user.isEditMode = false;
    this._userService.update(user);
  }

}
