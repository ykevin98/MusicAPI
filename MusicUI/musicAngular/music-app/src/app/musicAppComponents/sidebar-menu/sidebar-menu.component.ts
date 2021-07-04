import { Component, OnInit } from '@angular/core';
import * as fromServices from '../../services';
import * as fromModels from '../../models';

@Component({
  selector: 'app-sidebar-menu',
  templateUrl: './sidebar-menu.component.html',
  styleUrls: ['./sidebar-menu.component.scss']
})
export class SidebarMenuComponent implements OnInit {

  menuItems: fromModels.IMenuItems[] = [];

  constructor(private musicAPIService: fromServices.musicAPIService) { }

  ngOnInit(): void {
    this.musicAPIService.getMenuItems().subscribe(results => (this.menuItems = results));
  }

}
