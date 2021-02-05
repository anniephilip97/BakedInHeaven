import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {fakeitems} from '../fake-data';
import {Item} from '../types';

@Component({
  selector: 'app-item-detail',
  templateUrl: './item-detail.component.html',
  styleUrls: ['./item-detail.component.css']
})
export class ItemDetailComponent implements OnInit {
  item!: Item;

  constructor(
    private route: ActivatedRoute,
  ) { }

  ngOnInit(): void {
    /*
    const id= this.route.snapshot.paramMap.get('id');
    this.item!= fakeitems.find(item=> item.itemId===id);
    */
  }

}
