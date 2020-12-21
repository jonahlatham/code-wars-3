let arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

function sumEvenNumbers(input) {
  return input.reduce((r, e) => {
    if (e % 2 === 0) {
      r += e;
    }
    return r;
  }, 0);
}

console.log(sumEvenNumbers(arr));
