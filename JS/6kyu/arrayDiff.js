let crap = [1, 2, 3, 4, 5, 6, 7];
let crud = [2, 4, 6];

function arrayDiff(a, b) {
  return a.filter(e => !b.includes(e));
}

console.log(arrayDiff(crap, crud));
