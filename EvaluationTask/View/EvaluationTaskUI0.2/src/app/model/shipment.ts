export interface Shipment{
    id: number,
    name: string,
    fromDate: string,
    toDate: string,
    noBoxes: number
}

export const SHIPMENT_TABLE_SCHEMA = [
    {
        key:'id',
        type:'number',
        label:'ID'
    },
    {
        key:'name',
        type:'string',
        label:'Name'
    },
    {
        key:'fromDate',
        type:'string',
        label:'From Date'
    },
    {
        key:'toDate',
        type:'string',
        label:'To Date'
    },
    {
        key:'noBoxes',
        type:'number',
        label:'No.Boxes'
    },
   
]
export const SHIPMENT_DIALOG_SCHEMA= {
    name:'',
    noBoxes:'',
    fromDate:'',
    toDate:''
}