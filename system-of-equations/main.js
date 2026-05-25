// для input
function checkRangeInput() {
    const input = document.getElementById('userInput').value;
    const resultBlock = document.getElementById('resultBlock');

    // Проверка, что введено число
    if (isNaN(input) || input === "") {
        resultBlock.textContent = "Пожалуйста, введите корректное число.";
        resultBlock.style.color = "red";
        return;
    }

    const num = parseFloat(input);
    const min = 10;
    const max = 20;

    // Проверка условия, что число в диапазоне?
    if (num >= min && num <= max) {
        resultBlock.textContent = `Число ${num} в диапазоне [${min}, ${max}]. Результат: ${num + 1}`;
        resultBlock.style.color = "green";
    } else {
        resultBlock.textContent = `Число ${num} НЕ в диапазоне [${min}, ${max}].`;
        resultBlock.style.color = "red";
    }
}

// для prompt
function startPromptLoop() {
    let countInRange = 0;
    let totalNumbers = 5; // Сколько чисел запросим у пользователя
    const min = 10;
    const max = 20;

    for (let i = 0; i < totalNumbers; i++) {
        let userAnswer = prompt(`Введите число №${i + 1} из ${totalNumbers}:`);
        
        if (userAnswer === null) {
            alert("Операция отменена пользователем.");
            break;
        }
        
        // Преобразуем строку в число
        let num = parseFloat(userAnswer);
        
        if (isNaN(num)) {
            alert("Вы ввели не число. Попробуйте еще раз.");
            i--; // чтобы запросить число заново уменьшаем счетчик
            continue;
        }
        
        if (num >= min && num <= max) {
            countInRange++;
            console.log(`Число ${num} в диапазоне. Счетчик: ${countInRange}`);
         } else {
            console.log(`Число ${num} вне диапазона.`);
         }
    }
    
    alert(`Вы ввели ${countInRange} чисел из диапазона [${min}, ${max}].`);
}