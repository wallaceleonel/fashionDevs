function soma() {
    n1 =document.getElementById('n1').value;
    n2 =document.getElementById('n2').value;
    
    let = msgError = document.getElementsByClassName('error')
    //Validação negada XOR 
    if(!valide(n1,n2)) {
    //Exibe erro 
    msgError = document.getElementsByClassName('error')
    msgError[0].innerHTML=" O preenchimento dos campos é obrigadorio"
    }else{
        // faz o calc
        result = Number.parseInt(n1) + Number.parseInt(n2) 
        document.getElementById('Somar').value = result
        msgError[0].innerHTML=""
    }   
}

function subtracao () {
    n1 =document.getElementById('n1S').value;
    n2 =document.getElementById('n2S').value;

    let = msgError = document.getElementsByClassName('error')
    if(!valide(n1,n2)){
    msgError = document.getElementsByClassName('error')
    msgError[1].innerHTML=" O preenchimento dos campos é obrigadorio"
    }
    else{
        result = Number.parseInt(n1) - Number.parseInt(n2) 
        document.getElementById('Subt').value = result
        msgError[1].innerHTML=""
    }
    
}
function divisao () {
    n1 =document.getElementById('n1D').value;
    n2 =document.getElementById('n2D').value;
    
    let = msgError = document.getElementsByClassName('error')
    if(!valide(n1,n2)){
        msgError = document.getElementsByClassName('error')
        msgError[2].innerHTML=" O preenchimento dos campos é obrigadorio"
    }
    else{
        result =  Number.parseInt(n1) / Number.parseInt(n2) 
        document.getElementById('Divs').value = result.toFixed(2)
        msgError[2].innerHTML=""
    }
}
function multi () {
    n1 =document.getElementById('n1M').value;
    n2 =document.getElementById('n2M').value;
    
    let = msgError = document.getElementsByClassName('error')
    if(!valide(n1,n2)){
        msgError = document.getElementsByClassName('error')
        msgError[3].innerHTML=" O preenchimento dos campos é obrigadorio"
    }
    else{
    result = Number.parseInt(n1) * Number.parseInt(n2) 
    document.getElementById('Multip').value = result.toFixed(2)
    msgError[3].innerHTML=""
   }  
}
function media() {
    n1 = document.getElementById('n1Med').value
    n2 = document.getElementById('n2Med').value
    n3 = document.getElementById('n3Med').value
   
    let = msgError = document.getElementsByClassName('error')
    if(!valideMedia(n1,n2,n3)){
        msgError = document.getElementsByClassName('error')
        msgError[4].innerHTML=" O preenchimento dos campos é obrigadorio"
    }else{
    result = (Number.parseInt(n1) + Number.parseInt(n2) + Number.parseInt(n3))/3
    document.getElementById('resultMed').value = result.toFixed(2)
    window.alert(result.toFixed(2))
    msgError[4].innerHTML=""
}
}
function limpar() {
    inputsText = document.getElementsByClassName('form')
    for(i =0; i< inputsText.length; i++){
        inputsText[i].value =""
    }
    
}
function limparArray() {
    inputsText = document.getElementsByClassName('form')
    for(input in inputsText){
        inputsText[input].value =""
    }
    
}
function limpaForEach() {
    let inputsText = document.getElementsByClassName('form');
    let inputsArray = Array.prototype.slice.call(inputsText);
    inputsArray.forEach(function(e){
        e.value =""
        
    });
}
function valide(n1,n2){
  if (n1.trim() === "" || (n2.trim()) == "") {
      return false;
  }else{
      return true;
  }
}
function valideMedia(n1,n2,n3){
    // && é AND   || é OR 
    if (n1.trim() == "" || (n2.trim()) == ""|| n3.trim() == ""){
        return false;
    }else {
        return true;
    }
}

function exampleForLoop(){
    /*while (condition) {
        
    }
    for (let index = 0; index < array.length; index++) {
        const element = array[index];
        
    
            
        } while (condition);
    }
    do {
        
    } while (condition);
    */
   let loop = document.getElementById('loop')
   let msgLoop = ""
   for(i = 0; i < 10; i++){
       msgLoop +='<p>' +i+ '< 10 </p>'
   }
   loop.innerHTML =msgLoop
}
function exampleWhile() {
    let loop =document.getElementById('loop')
    let msgLoop =""
    while (i< 10) {
        msgLoop +='<p>' +i+ '< 10 </p>'
        i++
    }
}
function exampleDowhile() {
    let loop = document.getElementById('loop')
    let msgLoop =""
    i = 0
    validate = true
    do {
        msgLoop +='<p>' +i+ '< 10 </p>'
        if(i < 10 ) {
            i++
        } else{
            validate =false
        }
    } while (validate);
}