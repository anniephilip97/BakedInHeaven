import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import { Item } from '../types';
import {fakeitems} from '../fake-data';
import {ItemsService} from '../items.service';

@Component({
  selector: 'app-add-item',
  templateUrl: './add-item.component.html',
  styleUrls: ['./add-item.component.css']
})
export class AddItemComponent implements OnInit {

  constructor(
    private router : Router,
    private itemsService: ItemsService,
  ) { }

  ngOnInit(): void {
  }
/*
  OnSubmit(): void{
    var len=ItemsService.length;

    if(len>=5)
    {
      alert('15 items are there in your menu. You cannot add more...');
    }
    else{
           alert('Adding a new item...');
          this.router.navigateByUrl('/mymenu');
    }
  }
*/

 
  OnSubmit({itemName, quantity, price, kcal, veg, spl, no_Available, availableDate}): void{

    var len=ItemsService.length;

    if(len>=5)
    {
      alert('15 items are there in your menu. You cannot add more...');
    }
    else{
      this.itemsService.createItem(itemName, quantity, price, kcal, veg, spl, no_Available, availableDate)
      .subscribe(()=>{
        this.router.navigateByUrl('/mymenu');
      });
      
    
    }
    
  }
  

}

