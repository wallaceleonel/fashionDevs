function soma () {
    n1 =document.getElementById('n1').value;
    n2 =document.getElementById('n2').value;

    result = Number.parseInt(n1) + Number.parseInt(n2) 

    document.getElementById('Somar').value = result
}
function subtracao () {
    n1 =document.getElementById('n1S').value;
    n2 =document.getElementById('n2S').value;

    result = Number.parseInt(n1) - Number.parseInt(n2) 

    document.getElementById('Subt').value = result
}
function divisao () {
    n1 =document.getElementById('n1D').value;
    n2 =document.getElementById('n2D').value;

    result =  Number.parseInt(n1) / Number.parseInt(n2) 

    document.getElementById('Divs').value = result.toFixed(2)
}
function multi () {
    n1 =document.getElementById('n1M').value;
    n2 =document.getElementById('n2M').value;

    result = Number.parseInt(n1) * Number.parseInt(n2) 

    document.getElementById('Multip').value = result.toFixed(2)
    
}
function media() {
    n1 = document.getElementById('n1Med').value
    n2 = document.getElementById('n2Med').value
    n3 = document.getElementById('n3Med').value

    result = (Number.parseInt(n1) + Number.parseInt(n2) + Number.parseInt(n3))/3
    document.getElementById('resultMed').value = result.toFixed(2)
    window.alert(result.toFixed(2))
}
function limpar() {
    document.getElementById('n1').value = null;
    document.getElementById('n2').value = null;
    document.getElementById('result').value = null;
    
}