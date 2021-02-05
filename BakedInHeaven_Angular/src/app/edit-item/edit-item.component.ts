import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import{ItemsService} from '../items.service';
import {Item} from '../types';
import{fakeitems} from '../fake-data';

@Component({
  selector: 'app-edit-item',
  templateUrl: './edit-item.component.html',
  styleUrls: ['./edit-item.component.css']
})
export class EditItemComponent implements OnInit {

  item!: Item;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private itemsService: ItemsService,
  ) { }


  ngOnInit(): void {
    const id=Number(this.route.snapshot.paramMap.get('id'));
    this.item!=fakeitems.find(item=> item.itemId === id);
  }


  OnSubmit(): void{
    alert('Saving Changes to the Item Details...');
    this.router.navigateByUrl('/mymenu');
  }

/*

  ngOnInit(): void {
    const id=this.route.snapshot.paramMap.get('id');
    this.itemsService.getItemById(id)
    .subscribe(item =>this.item=item);
  }

  

  OnSubmit({itemName, quantity, price, kcal, veg, spl, no_Available, availableDate}): void{
    this.itemsService.editItem(this.item.itemId,itemName, quantity, price, kcal, veg, spl, no_Available, availableDate)
    .subscribe(()=> {
      this.router.navigateByUrl('/mymenu');
    });

   
    
  }
   */

}
