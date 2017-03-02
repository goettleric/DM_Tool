var rollDiceButton = document.getElementById('btnRollDice');

function rollDice () {

  var output = document.getElementById('rollValue');

  var numOfd4 = document.getElementById('numOfd4').value;
  var numOfd6 = document.getElementById('numOfd6').value;
  var numOfd8 = document.getElementById('numOfd8').value;
  var numOfd10 = document.getElementById('numOfd10').value;
  var numOfd10Pct = document.getElementById('numOfd10Pct').value;
  var numOfd12 = document.getElementById('numOfd12').value;
  var numOfd20 = document.getElementById('numOfd20').value;

  var rollTotal = (Math.ceil(Math.random()*4) * numOfd4) +
    (Math.ceil(Math.random()*6) * numOfd6) +
    (Math.ceil(Math.random()*8) * numOfd8) +
    (Math.ceil(Math.random()*10) * numOfd10) +
    ((Math.floor(Math.random()*10)%10*10) * numOfd10Pct) +
    (Math.ceil(Math.random()*12) * numOfd12) +
    (Math.ceil(Math.random()*20) * numOfd20);

  output.innerHTML = rollTotal;
}
