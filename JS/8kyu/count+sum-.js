// https://www.codewars.com/kata/576bb71bbbcf0951d5000044

function countPositivesSumNegatives(input) {
    if (input == null || input.length == 0)
        return [];
    let neg = input.filter(e => e < 0)
    let pos = input.filter(e => e > 0)
    let newNeg = neg.reduce((r, e) => {
        return r += e
    }, 0)
    return [pos.length, newNeg]
}

console.log(countPositivesSumNegatives([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]))