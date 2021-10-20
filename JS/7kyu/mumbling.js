function accum(s) {
    return s.split('').map((e, i) => {
        return e.toUpperCase() + e.repeat(i).toLowerCase()
    }).join('-')
}

console.log(accum("abcd"))