#include <iostream>
#include <string>
#include <vector>

//Player class
class Player
{
    private:
        int health;
        int attack;
        int defense;
        std::string name;
        std::vector<std::string> inventory;

    public:
        Player(int h, int a, int d, std::string n)
        {
            health = h;
            attack = a;
            defense = d;
            name = n;
        }

        void setHealth(int h) { health = h; }
        int getHealth() { return health; }

        void setAttack(int a) { attack = a; }
        int getAttack() { return attack; }

        void setDefense(int d) { defense = d; }
        int getDefense() { return defense; }

        void setName(std::string n) { name = n; }
        std::string getName() { return name; }

        void addItemToInventory(std::string item) { inventory.push_back(item); }
        std::vector<std::string> getInventory() { return inventory; }
};

//Enemy class
class Enemy
{
    private:
        int health;
        int attack;
        int defense;
        std::string name;

    public:
        Enemy(int h, int a, int d, std::string n)
        {
            health = h;
            attack = a;
            defense = d;
            name = n;
        }

        void setHealth(int h) { health = h; }
        int getHealth() { return health; }

        void setAttack(int a) { attack = a; }
        int getAttack() { return attack; }

        void setDefense(int d) { defense = d; }
        int getDefense() { return defense; }

        void setName(std::string n) { name = n; }
        std::string getName() { return name; }
};

//Battle class
class Battle
{
    private:
        Player* player;
        Enemy* enemy;
        bool playing;
    public:
        Battle(Player* p, Enemy* e)
        {
            player = p;
            enemy = e;
            playing = true;
        }

        void start()
        {
            while(playing)
            {
                int player_attack = player->getAttack() - enemy->getDefense();
                int enemy_attack = enemy->getAttack() - player->getDefense();

                enemy->setHealth(enemy->getHealth() - player_attack);
                player->setHealth(player->getHealth() - enemy_attack);

                std::cout << player->getName() << " dealt " << player_attack << " damage to " << enemy->getName() << std::endl;
                std::cout << enemy->getName() << " dealt " << enemy_attack << " damage to " << player->getName() << std::endl;

                std::cout << player->getName() << " has " << player->getHealth() << " health left!" << std::endl;
                std::cout << enemy->getName() << " has " << enemy->getHealth() << " health left!" << std::endl;

                if(player->getHealth() <= 0)
                {
                    playing = false;
                    std::cout << player->getName() << " was defeated by " << enemy->getName() << std::endl;
                }
                else if(enemy->getHealth() <= 0)
                {
                    playing = false;
                    std::cout << enemy->getName() << " was defeated by " << player->getName() << std::endl;
                }
            }
        }
};

//Main
int main()
{
    Player* p = new Player(100, 10, 5, "Link");
    Enemy* e = new Enemy(50, 7, 3, "Ganon");

    Battle* b = new Battle(p, e);
    b->start();

    return 0;
}
