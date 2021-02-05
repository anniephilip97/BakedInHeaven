export interface Item{
    itemId: number,
        itemName: string,
        quantity: string,
        price: string,
        kcal: number,
        veg: string,
        spl: string,
        no_Available: number,
        availableDate: string,

}

export interface Order{
    orderId: number,
        customerId: number,
        itemId: number,
        totalNo: number,
        price: string,
        dateOfDelivery: string,
        status: string
}


export interface Customer{
    customerId: number,
        name: string,
        phoneNo: string,
        address: string,
        zipcode: string
}