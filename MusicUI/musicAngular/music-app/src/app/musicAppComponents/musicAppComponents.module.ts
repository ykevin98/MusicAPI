
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";

import { MatrixBoardComponent } from './matrix-board/matrix-board.component';
import { NavBarComponentComponent } from './nav-bar-component/nav-bar-component.component';
import { SidebarMenuComponent } from './sidebar-menu/sidebar-menu.component';
import { DashboardComponentComponent } from './dashboard-component/dashboard-component.component';
import { UserComponentComponent } from './user-component/user-component.component';

@NgModule({
  imports: [CommonModule, RouterModule],
  declarations: [MatrixBoardComponent, NavBarComponentComponent, SidebarMenuComponent, DashboardComponentComponent, UserComponentComponent],
  exports: [MatrixBoardComponent, NavBarComponentComponent, SidebarMenuComponent, DashboardComponentComponent]
})

export class musicAppComponents {}
