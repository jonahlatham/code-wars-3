function evenChars(string) {
  return string.length > 1 && string.length < 100
    ? string.split('').filter((e, i) => i % 2 !== 0)
    : 'invalid string';
}

console.log(evenChars('abcdefghijklmnop'));
