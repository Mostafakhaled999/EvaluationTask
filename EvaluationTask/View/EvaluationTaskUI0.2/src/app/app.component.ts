import { Component } from '@angular/core';
import { SHIPMENT_TABLE_SCHEMA,SHIPMENT_DIALOG_SCHEMA, Shipment } from './model/shipment';
import  {BOXES_TABLE_SCHEMA }from './model/boxes';
import { ShipmentService } from './services/shipment.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'EvaluationTaskUI0.2';
  shipmentSchema = SHIPMENT_TABLE_SCHEMA;
  boxesSchema = BOXES_TABLE_SCHEMA;
  shipmentDialogSchema = SHIPMENT_DIALOG_SCHEMA;
  constructor(public shipmentService:ShipmentService) {};
}
