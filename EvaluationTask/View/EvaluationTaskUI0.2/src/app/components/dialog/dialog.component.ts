import { DialogRef } from '@angular/cdk/dialog';
import { Component,Inject,Input } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import {DataTableComponent} from './../../data-table/data-table.component';
@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent {
  form: FormGroup;
   skeleton:any;
   constructor(private _formBuilder:FormBuilder,private _diaglodRef:MatDialogRef<DialogComponent>,@Inject(MAT_DIALOG_DATA) public data: any){
    
    console.log(this.data.builder);
      this.form = this._formBuilder.group(
      this.data.builder
        );
   }
   ngOnInit() {
    this.skeleton = this.data.dialogSchema;
    this.form.patchValue(this.data.value);
  }
   onSavePressed(){
    if(this.data.action === 'update'){
      this.data.service.update({...this.form.value,...{id:this.data.value.id}}).subscribe({
        next: (val:any)=>{console.log('success update');console.log(this.data.value);},
        error: (val:any)=>{console.log('error');console.log(this.data.value);},
        
        
      });
    }else{
      this.data.service.add(this.form.value).subscribe();
    }
      this._diaglodRef.close(true);
   }
   onCancelPressed(){
      this._diaglodRef.close();
   }
}
