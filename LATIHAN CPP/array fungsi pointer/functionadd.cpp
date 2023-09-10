
#include <iostream>
#include <string>
#include <vector>

using namespace std;

// Function to show the hangman
void showHangman(int tries){
    if (tries == 0){
        cout << " _________\n|         |\n|\n|\n|\n|\n|\n|\n|\n|\n";
    }
    else if (tries == 1){
        cout << " _________\n|         |\n|         O\n|\n|\n|\n|\n|\n|\n|\n";
    }
    else if (tries == 2){
        cout << " _________\n|         |\n|         O\n|         |\n|         |\n|\n|\n|\n|\n|\n";
    }
    else if (tries == 3){
        cout << " _________\n|         |\n|         O\n|        /|\n|         |\n|\n|\n|\n|\n|\n";
    }
    else if (tries == 4){
        cout << " _________\n|         |\n|         O\n|        /|\\\n|         |\n|        /\n|\n|\n|\n|\n";
    }
    else if (tries == 5){
        cout << " _________\n|         |\n|         O\n|        /|\\\n|         |\n|        / \\\n|\n|\n|\n|\n";
    }
    else {
        cout << " _________\n|         |\n|         O\n|        /|\\\n|         |\n|        / \\\n|\n|\n|\n|\nGAME OVER!";
    }
}

int main(){
    //Initializing variables
    string word;
    int tries = 0;
    char letter;
    vector<char> guessedLetters;
    bool found;
    bool gameOver = false;
    
    //Getting secret word
    cout << "Enter secret word: ";
    cin >> word;
    
    //Setting up the vector for the guessed letters
    for (int i = 0; i < word.length(); i++){
        guessedLetters.push_back('_');
    }
    
    //Game loop
    while (!gameOver){
        //Printing out the hangman
        showHangman(tries);
        
        //Printing out the guessed letters
        for (int i = 0; i < guessedLetters.size(); i++){
            cout << guessedLetters[i] << " ";
        }
        cout << endl;
        
        //Getting guessed letter
        cout << "Guess a letter: ";
        cin >> letter;
        
        //Checking if letter is in the word
        found = false;
        for (int i = 0; i < word.length(); i++){
            if (word[i] == letter){
                found = true;
                guessedLetters[i] = letter;
            }
        }
        
        //If letter is wrong, increment tries
        if (!found){
            tries++;
        }
        
        //Checking if the game is over
        gameOver = true;
        for (int i = 0; i < guessedLetters.size(); i++){
            if (guessedLetters[i] == '_'){
                gameOver = false;
            }
        }
        
        //If the game is over, show the secret word
        if (gameOver){
            cout << "The secret word was " << word << endl;
        }
        
        //If the hangman is complete, show game over
        if (tries == 6){
            showHangman(tries);
            cout << "The secret word was " << word << endl;
        }
    }
    return 0;
}
