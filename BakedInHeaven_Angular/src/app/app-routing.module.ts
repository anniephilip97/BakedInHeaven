import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddItemComponent } from './add-item/add-item.component';
import { EditItemComponent } from './edit-item/edit-item.component';
import { HomeComponent } from './home/home.component';
import { ItemDetailComponent } from './item-detail/item-detail.component';
import { ItemsComponent } from './items/items.component';
import { LoginComponent } from './login/login.component';
import { MymenuComponent } from './mymenu/mymenu.component';
import { OrderComponent } from './order/order.component';

const routes: Routes = [
  {path: '', component:HomeComponent},
  {path: 'items', component: ItemsComponent, pathMatch: 'full'},
  {path: 'items/:id', component: ItemDetailComponent},
  {path: 'order', component: OrderComponent},
  {path: 'add-item', component: AddItemComponent},
  {path: 'edit-item/:id', component: EditItemComponent},
  {path: 'mymenu', component: MymenuComponent},
  {path: 'login', component: LoginComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
