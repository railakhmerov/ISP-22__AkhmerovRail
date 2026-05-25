let currentInput = '';
let operator = null;
let previousInput = '';

function append(number) {
  currentInput += number;
  updateDisplay();
}

function clearDisplay() {
  currentInput = '';
  operator = null;
  previousInput = '';
  updateDisplay();
}

function setOperator(operation) { // operation - хранит символ операции
  if (currentInput === '') return;
  if (previousInput !== '') calculate();
  operator = operation;
  previousInput = currentInput;
  currentInput = '';
}

function calculate() {
  let result;
  const prev = parseFloat(previousInput);
  const current = parseFloat(currentInput);

  if (isNaN(prev) || isNaN(current)) return;

  switch (operator) {
   case '+': 
      result = prev + current; 
      break;
   case '-': 
      result = prev - current; 
      break;
   case '*': 
      result = prev * current; 
      break;
   case '/': 
      result = prev / current; 
      break;
   default: 
      return;
  }

  currentInput = result;
  operator = null;
  previousInput = '';
  updateDisplay();
}

function updateDisplay() {
  document.getElementById('display').value = currentInput;
}