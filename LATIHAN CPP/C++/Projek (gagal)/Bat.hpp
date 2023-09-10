#ifndef Bat_hpp
#define Bat_hpp
 
#include 
 
using namespace sf;
 
class Bat
{
private:
    Vector2f position;
 
    RectangleShape batShape;
    float batSpeed= .5f;
public:
    Bat(float StartX, float startY );
    FloatRect getPosition();
    RectangleShape getShape();
    void moveLeft();
    void moveRight();
    void update();
 
};
 
#endif /* Bat_hpp */
