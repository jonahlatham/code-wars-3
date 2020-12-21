let arr = [-1, 3, 7, 7, 4, 2];
function maxTriSum(numbers) {
  const crap = [...new Set(numbers)];
  return crap
    .sort((a, b) => {
      return a - b;
    })
    .slice(crap.length - 3)
    .reduce((r, e) => {
      r += e;
      return r;
    }, 0);
}

console.log(maxTriSum(arr));
