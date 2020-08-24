function crap() {
  let crap = 45;
  let crapper = [
    { id: 1, crap: 45 },
    { id: 2, crap: 67 }
  ];

  return crapper.find(x => x.crap === crap);
}

console.log(crap());
