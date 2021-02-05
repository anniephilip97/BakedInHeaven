import { Component, OnInit } from '@angular/core';
import {ItemsService} from '../items.service';
import {fakeitems} from '../fake-data';
import {Item} from '../types';

@Component({
  selector: 'app-mymenu',
  templateUrl: './mymenu.component.html',
  styleUrls: ['./mymenu.component.css']
})
export class MymenuComponent implements OnInit {
  isLoading: boolean=true;
  items: Item[]=[];

  constructor(
    private itemsService: ItemsService,
  ) { }

  ngOnInit(): void {
    this.itemsService.getItems()
    .subscribe(items => {this.items=items; this.isLoading=false;});
    
  }

  OnDeleteClicked(itemId: number): void{
    this.itemsService.deleteItem(itemId)
    .subscribe(()=>{
        this.items=this.items.filter(
          item=>item.itemId !== itemId
        );
    });
    
  }

}
