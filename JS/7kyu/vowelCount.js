function getCount(str) {
    return Array.from(str).filter(e => 'aeiou'.includes(e)).length;
}