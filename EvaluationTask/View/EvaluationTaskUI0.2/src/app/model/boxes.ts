export interface Boxes{
    id:number,
    name:string,
    code:string,
    fromDate: string,
    toDate: string,
    noEnvelopes:number
}

export const BOXES_TABLE_SCHEMA = [
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
        key:'noEnvelope',
        type:'number',
        label:'No.Envelope'
    },

]