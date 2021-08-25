// https://www.codewars.com/kata/515e271a311df0350d00000f/javascript

function squareSum(numbers) {
    return numbers.reduce((r, e) => {
        r += Math.pow(e, 2)
        return r
    }, 0)
}

console.log(squareSum([0, 3, 4, 5]))