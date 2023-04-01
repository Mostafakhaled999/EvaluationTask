import { AfterViewInit, Component, Input, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { DialogComponent } from '../components/dialog/dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { DataTableItem } from './data-table-datasource';
import { DialogRef } from '@angular/cdk/dialog';

@Component({
  selector: 'app-data-table',
  templateUrl: './data-table.component.html',
  styleUrls: ['./data-table.component.css'],
})
export class DataTableComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<DataTableItem>;
  @Input() service: any;
  @Input() columnSchema: any;
  @Input() label: string = 'Shipment';
  @Input() dialogBuilder: any;
  displayedColumns: any;
  dataSource: any;

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */

  constructor(private dialog: MatDialog) {}
  ngOnInit() {
    this.getTableDataList();
  }

  ngAfterViewInit(): void {}

  getTableDataList() {
    this.service.get().subscribe((response: any) => {
      this.dataSource = new MatTableDataSource(response);
      this.dataSource.sort = this.sort;
      this.dataSource.paginator = this.paginator;
      this.table.dataSource = this.dataSource;
      this.displayedColumns = this.columnSchema.map((col: any) => col.key);
      this.displayedColumns.push('action');
    });
  }

  removeRow(id: number) {
    this.service.delete(id).subscribe(() => {
      this.getTableDataList();
    });
  }


  openDialog(action: string,row?: any) {
    const dialogRef = this.dialog.open(DialogComponent, {
      data: {
        dialogSchema: this.columnSchema,
        builder: this.dialogBuilder,
        value: row!,
        action,
        service: this.service,
      },
    });
    dialogRef.afterClosed().subscribe({
      next: (val) => {
        if (val) this.getTableDataList();
      },
    });
  }
}
