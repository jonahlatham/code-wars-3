function pigIt(str){
    return str.split(' ').map((e,i)=>{
        if((/[a-zA-Z]/).test(e)){
        return e.slice(1,e.length)+e.slice(0,1)+'ay'
        } else {
            return e
        }
    }).join(' ')
  }

  console.log(pigIt('hello world'))