import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {fakeitems} from './fake-data';
import {Item} from './types';

const httpOptions={
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  })
};

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  constructor(
    private http: HttpClient,
  ) { }

  getItems(): Observable<Item[]> {
     return this.http.get<Item[]>('/api/items');
  }

  getItemById(id: number): Observable<Item>{
    return this.http.get<Item>('/api/items/');
  }

  addViewToItem(id: number):Observable<Item>{
    return this.http.post<Item>(`/api/items/${id}/add-view`,{}, httpOptions,);
  }

  getItemsForUser():Observable<Item[]>{
    return this.http.get<Item[]>('/api/customers');
  }

  deleteItem(id: number):Observable<any>{
    return this.http.delete(`/api/items/${id}`);
  }

  createItem(itemName: string, quantity: string, price: string, kcal: number, veg: string, spl: string, no_Available: number, availableDate: string): Observable<Item>{
    return this.http.post<Item>(
      '/api/items',
      {itemName, quantity, price, kcal, veg, spl, no_Available, availableDate },
      httpOptions,
    )
  }
/*
  editItem(itemName: string, quantity: string, price: string, kcal: number, veg: string, spl: string, no_Available: number, availableDate: string): Observable<Item>{
    return this.http.put<Item>(
      `/api/items/${id}`,
      {itemName, quantity, price, kcal, veg, spl, no_Available, availableDate },
      httpOptions,
    )
  }
*/
}
