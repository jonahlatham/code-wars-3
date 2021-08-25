// https://www.codewars.com/kata/57356c55867b9b7a60000bd7

function basicOp(op, val1, val2) {
    if (op === '+') {
        return val1 + val2
    } else if (op === '-') {
        return val1 - val2
    } else if (op === '*') {
        return val1 * val2
    } else {
        return val1 / val2
    }
}

console.log(basicOp('+', 4, 7))

// // Better Solution

function basicOp(o, a, b) {
    return eval(a + o + b);
}