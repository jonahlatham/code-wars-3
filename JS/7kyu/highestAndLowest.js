function highAndLow(numbers) {
    let crap = numbers.split(' ').sort((a, b) => { return a - b })
    return `${crap[crap.length - 1]} ${crap[0]}`
}

console.log(highAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"))