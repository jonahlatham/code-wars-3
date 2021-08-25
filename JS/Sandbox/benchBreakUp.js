function breakDown(x, squirts = []) {
    if (x % 5 != 0) {
        alert('Use multiples of five')
    } else {
        switch (true) {
            case x >= 90:
                squirts.push(45)
                x = ninety(x)
                break;
            case x >= 50:
                squirts.push(25)
                x = fifty(x)
                break;
            case x >= 20:
                squirts.push(10)
                x = twenty(x)
                break;
            case x >= 10:
                squirts.push(5)
                x = ten(x)
                break;
            default:
                squirts.push(2.5)
                x = five(x)
                break;
        }
    }
    if (x > 0) {
        return breakDown(x, squirts)
    } else {
        return squirts
    }
}
const ninety = (x) => {
    return x -= 90
}
const fifty = (x) => {
    return x -= 50
}
const twenty = (x) => {
    return x -= 20
}
const ten = (x) => {
    return x -= 10
}
const five = (x) => {
    return x -= 5
}

const reduceNums = (x) => {
    return x.reduce((r, e) => {
        return r[e] ? ++r[e] : r[e] = 1, r
    }, {});
}
console.log(reduceNums([45, 45, 45, 25, 25, 5]))

const returnCalc = (x) => {
    x -= 45
    let stuff = breakDown(x)
    console.log(stuff)
    let stule = reduceNums(stuff)
    console.log(stule[45])
    console.log(stule[25])
    console.log(stule[10])
    console.log(stule[5])
    console.log(stule[2.5])
    return stule[45]
    // return ['The Bar', ...breakDown(x)]
}
console.log(returnCalc(125))

const perct = (x, y) => {
    return Math.floor((x * (y / 100)) / 5) * 5
}

console.log(perct(215, 85))