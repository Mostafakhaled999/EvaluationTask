import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Shipment } from '../model/shipment';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ShipmentService {
  private url: string = 'Shipment/';

  
  constructor(private http:HttpClient) { }

  get() : Observable<Shipment[]> {
    return this.http.get<Shipment[]>(environment.apiUrl + this.url);
  }

  delete(id:number):Observable<Shipment>{
    return this.http.delete<Shipment>(environment.apiUrl + this.url + id);
  }

  update(shipment:Shipment):Observable<Shipment>{
    return this.http.put<Shipment>(environment.apiUrl + this.url ,shipment);
  }
  
  add(shipment:Shipment){
    return this.http.post<Shipment>(environment.apiUrl + this.url,shipment);
  }
}
