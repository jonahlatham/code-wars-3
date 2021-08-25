// https://www.codewars.com/kata/54edbc7200b811e956000556/csharp

const arr = [true, true, true, false,
    true, true, true, true,
    true, false, true, false,
    true, false, false, true,
    true, true, true, true,
    false, false, true, true]

function countSheeps(arrayOfSheep) {
    return arrayOfSheep.reduce((r, e) => {
        if (e === true)
            r += 1
        return r
    }, 0)
}

console.log(countSheeps(arr))

// // Better Solution
function countSheeps(arrayOfSheeps) {
    return arrayOfSheeps.filter(Boolean).length;
}