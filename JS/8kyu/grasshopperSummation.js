var summation = function (num) {
    let num = 0
    for (let i = 0; i <= num; i++) {
        num += i
    }
    return num
}


// //better solution
// const summation = n => n * (n + 1) / 2;