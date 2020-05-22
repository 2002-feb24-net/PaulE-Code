const guesses = document.querySelector('.guesses');
const lastResult = document.querySelector('.lastResult');
const lowOrHi = document.querySelector('.lowOrHi');
const guessSubmit = document.querySelector('.guessSubmit');
const guessField = document.querySelector('.guessField');

guessSubmit.addEventListener('click', checkGuess);

let randomNumber = (Math.floor(Math.random()*100)) + 1;
let guessCount = 1;
let totalGuesses = 10;
let resetButton;
guessField.focus();

function checkGuess()
{
    if (!ValidateInput)
    {
        lastResult.textContent("You need to put in a number!");
        return;
    }
    let userGuess = Number(guessField.value);

    if(guessCount === 1)
    {
        guesses.textContent = 'Previous Guesses: ';
    }

    guesses.textContent += ' ' + userGuess;

    if(userGuess === randomNumber)
    {
        lastResult.textContent = 'Congratulations! You got the number correct!';
        lastResult.style.backgroundColor = 'green';
        lowOrHi.textContent = '';
    }
    else if (guessCount >= totalGuesses)
    {
        lastResult.style.backgroundColor = 'red';
        lastResult.textContent = 'GAME OVER!';
    }
    else
    {
        lastResult.textContent = 'Wrong number';

        if(userGuess < randomNumber)
        {
            lowOrHi.textContent = 'That guess was too low.';
        }
        else if (userGuess > randomNumber)
        {
            lowOrHi.textContent = 'That guess was too high.';
        }
        else
        {
            // ???
        }
    }

    guessCount++;
    guessField.value = '';
}

function setGameOver()
{
    guessField.disabled = true;
    guessSubmit.disabled = true;
    resetButton = document.createElement('button');
    resetButton.textContent = 'Start new game';
    document.body.append(resetButton);
    resetButton.addEventListener('click', resetGame);
}

function resetGame()
{
    guessCount = 1;

    const resetParas = document.querySelectorAll('.resultParas p');
    for (let i = 0 ; i < resetParas.length ; i++)
    {
        resetParas[i].textContent = '';
    }

    resetButton.parentNode.removeChild(resetButton);

    guessField.disabled = false;
    guessSubmit.disabled = false;
    guessField.value = '';
    guessField.focus();

    lastResult.style.backgroundColor = 'white';

    randomNumber = Math.floor(Math.random() * 100) + 1;
}

function ValidateInput()
{

}