import {Item} from "./types";
import {Order} from "./types";
import {Customer} from "./types";


export const fakeitems: Item[]= [
    {
        itemId: 1,
        
        itemName: "Chocolate Cupcake",
        quantity: "75g",
        price: "Rs. 40",
        kcal: 230,
        veg: "Veg",
        spl: "Not Special",
        no_Available: 25,
        availableDate: "2021-01-20"
    },
    {
        itemId: 2,
        
        itemName: "Choco Chip Cupcake",
        quantity: "75g",
        price: "Rs. 45",
        kcal: 290,
        veg: "Non-Veg",
        spl: "Special",
        no_Available: 20,
        availableDate: "2021-01-20"
    },
    {
        itemId: 3,
        
        itemName: "ButterScotch cake",
        quantity: "500g",
        price: "Rs. 400",
        kcal: 780,
        veg: "Veg",
        spl: "Not Special",
        no_Available: 3,
        availableDate: "2021-01-20"
    },
    {
        itemId: 4,
        
        itemName: "Chocolate Truffles Cake",
        quantity: "1000g",
        price: "Rs. 950",
        kcal: 1100,
        veg: "Non-Veg",
        spl: "Special",
        no_Available: 2,
        availableDate: "2021-01-20"
    }
]


export const fakeorders: Order[]= [
    {
        orderId: 2,
        customerId: 2,
        itemId: 3,
        totalNo: 1,
        price: "Rs. 400",
        dateOfDelivery: "2021-01-20",
        status: "Not Delivered"
    },
    {
        orderId: 3,
        customerId: 3,
        itemId: 4,
        totalNo: 1,
        price: "Rs. 950",
        dateOfDelivery: "2021-01-20",
        status: "Not Delivered"
    },
    {
        orderId: 4,
        customerId: 4,
        itemId: 1,
        totalNo: 5,
        price: "Rs. 200",
        dateOfDelivery: "2021-01-20",
        status: "Not Delivered"
    },
    {
        orderId: 1,
        customerId: 3,
        itemId: 2,
        totalNo: 5,
        price: "Rs. 225",
        dateOfDelivery: "2021-01-20",
        status: "Not Delivered"
    }
]



export const fakecustomers: Customer[]=[
    {
        customerId: 1,
        name: "Tia",
        phoneNo: "2563968475",
        address: "ABC Street",
        zipcode: "526548"
    },
    {
        customerId: 2,
        name: "Ruby",
        phoneNo: "9586856974",
        address: "Lazy Street",
        zipcode: "560092"
    },
    {
        customerId: 3,
        name: "Nella",
        phoneNo: "9587532174",
        address: "Nanny Cross",
        zipcode: "560072"
    },
    {
        customerId: 4,
        name: "Kim",
        phoneNo: "8797532174",
        address: "Lily Cross Street",
        zipcode: "569572"
    },
    {
        customerId: 5,
        name: "JiHyo",
        phoneNo: "6241359877",
        address: "Itewon Street",
        zipcode: "569892"
    }
]