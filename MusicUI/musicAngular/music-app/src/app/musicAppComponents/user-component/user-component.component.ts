import { Component, OnInit } from '@angular/core';
import * as fromServices from '../../services';
import * as fromModels from '../../models';
import { identifierModuleUrl } from '@angular/compiler';

@Component({
  selector: 'app-user-component',
  templateUrl: './user-component.component.html',
  styleUrls: ['./user-component.component.scss']
})
export class UserComponentComponent implements OnInit {

  user: fromModels.IUser = {
    Id: 0,
    firstName: '',
    lastName: '',
    userName: '',
    Age: -1
  };
  
  constructor(private musicAPIService: fromServices.musicAPIService) { }

  ngOnInit(): void {
    this.musicAPIService.getUser().subscribe(result => (this.user = result));
  }

}
