export interface User {
    username: string;
    knownAs: string;
    gender: string;
    token: string;
    photoUrl?: string;
}

/* Brief intro to Typescript */

// let data: number | string = 42;
// data = "10";


// interface Car {
//     color: string,
//     model: string,
//     topSpeed?: number
// }

// const car1: Car = {
//     color: 'blue',
//     model: 'BMW',

// }

// const car2: Car = {
//     color: 'red',
//     model: 'Mercedes',
//     topSpeed: 100
// }


// const multiply = (x: number, y: number) => {
//     return x * y;
// }