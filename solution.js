//task 1

let myArr = ['hello', 'world'];
let copyArr = [...myArr];
console.log(copyArr);

//task 2
let firstArr = [-1,1];
let secondArr = [2,1];
let finalyResult = [firstArr.length + secondArr.length];

for(let i = 0; i < firstArr.length; i++){
    for(let j = 0; j < secondArr.length; j++){
        finalyResult[i + j] += firstArr[i] * secondArr[j]
    }
}
console.log(finalyResult)
