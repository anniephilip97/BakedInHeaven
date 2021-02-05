import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {Item} from '../types';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-item-data-form',
  templateUrl: './item-data-form.component.html',
  styleUrls: ['./item-data-form.component.css']
})
export class ItemDataFormComponent implements OnInit {
  @Input() buttonText:string='';
  @Input() currentName!: string;
  @Input() currentPrice!:string;
  @Input() currentQuantity!:string;
  @Input() currentKcal!:number;
  @Input() currentVeg!:string;
  @Input() currentSpl!:string;
  @Input() currentNo_Available!:number;
  @Input() currentAvailableDate!:string;

  itemId!:number;
  itemName: string='';
  quantity!: string;
  price!: string;
  kcal!: number;
  veg!: string;
  spl!: string;
  no_Available!: number;
  availableDate!: string;

  @Output() OnSubmit= new EventEmitter<Item>();

  

  constructor(
    private router : Router,
    private route: ActivatedRoute,
  ) { }

  ngOnInit(): void {

    this.itemId = Number(this.route.snapshot.paramMap.get('id'))!;

    this.itemName=this.currentName;
    this.price=this.currentPrice;
    this.quantity=this.currentQuantity;
    this.kcal=this.currentKcal;
    this.veg=this.currentVeg;
    this.spl=this.currentSpl;
    this.no_Available=this.currentNo_Available;
    this.availableDate=this.currentAvailableDate;
  }

  OnButtonClicked(): void{
    this.OnSubmit.emit({
      itemId: this.itemId,
      itemName: this.itemName,
      price: this.price,
      quantity: this.quantity,
      kcal: this.kcal,
      veg: this.veg,
      spl: this.spl,
      no_Available: this.no_Available,
      availableDate: this.availableDate
    })
  }

}
